using EXAMEN_SGREE.Services;
using SGREE.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class ControlDashboard : UserControl
    {
        // ─── Services (même pattern que ControlContrat) ───────────────────
        private readonly ContratService _contratService = new ContratService();
        private readonly EmployeService _employeService = new EmployeService();
        private readonly EmployeurService _employeurService = new EmployeurService();

        // ─── KPI ─────────────────────────────────────────────────────────
        private int _nbEmployes;
        private int _nbEmployeurs;
        private int _nbContrats;
        private decimal _masseSalariale;
        private int _nbAlertes;

        // ─── Données graphiques ───────────────────────────────────────────
        private List<(string Label, int Val)> _secteurs = new List<(string, int)>();
        private List<(string Label, int Val)> _evolution = new List<(string, int)>();
        private List<(string Label, int Val)> _typesContrat = new List<(string, int)>();

        // ─── Données grilles ──────────────────────────────────────────────
        private DataTable _dtAlertes;
        private DataTable _dtTopEmployeurs;

        // ─── Palettes (readonly) ──────────────────────────────────────────
        private readonly Color[] _pieColors =
        {
            Color.FromArgb(0,   122, 204),
            Color.FromArgb(0,   160, 110),
            Color.FromArgb(200, 150,   0),
            Color.FromArgb(200,  60,  60),
            Color.FromArgb(120,  80, 200),
            Color.FromArgb(0,   180, 200),
            Color.FromArgb(210, 100,   0),
            Color.FromArgb(80,  180,  60)
        };

        private readonly Color[] _barColors =
        {
            Color.FromArgb(0,   122, 204),
            Color.FromArgb(0,   140, 190),
            Color.FromArgb(0,   158, 170),
            Color.FromArgb(0,   168, 145),
            Color.FromArgb(0,   170, 110),
            Color.FromArgb(0,   165,  75),
            Color.FromArgb(55,  160,  50),
            Color.FromArgb(95,  155,  28),
            Color.FromArgb(140, 148,  18),
            Color.FromArgb(178, 138,   8),
            Color.FromArgb(198, 108,   8),
            Color.FromArgb(208,  78,  18)
        };

        // ================================================================
        public ControlDashboard()
        {
            InitializeComponent();
            SetDoubleBuffered();
        }

        private void SetDoubleBuffered()
        {
            var prop = typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            foreach (var p in new Control[] { panelPieSecteur, panelBarEvolution, panelPieType })
                prop?.SetValue(p, true);
        }

        // ================================================================
        //  LOAD
        // ================================================================
        private void ControlDashboard_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            ChargerDashboard();
        }

        private void BtnActualiser_Click(object sender, EventArgs e) => ChargerDashboard();

        private void ChargerDashboard()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new DbContextSgree())
                {
                    ChargerKPIs(db);
                    ChargerSecteurs(db);
                    ChargerEvolution(db);
                    ChargerTypeContrat(db);
                    ChargerAlertes(db);
                    ChargerTopEmployeurs(db);
                }

                MettreAJourCartes();
                MettreAJourGrids();
                MettreAJourBandeau();

                panelPieSecteur.Invalidate();
                panelBarEvolution.Invalidate();
                panelPieType.Invalidate();

                lblDerniereMAJ.Text = "Mise a jour : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement dashboard :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        // ================================================================
        //  REQUÊTES
        // ================================================================
        private void ChargerKPIs(DbContextSgree db)
        {
            _nbEmployes = db.Employes.Count();
            _nbEmployeurs = db.Employeurs.Count();

            var contratsActifs = db.Contrats
                .Where(c => c.Statut.ToString() == "EnCours" ||
                            c.Statut.ToString() == "Actif")
                .ToList();

            _nbContrats = contratsActifs.Count;
            _masseSalariale = contratsActifs.Sum(c => (decimal?)c.SalaireBase) ?? 0m;

            var expirables = _contratService.GetContratsExpirant(30);
            var idsAvecContrat = contratsActifs.Select(c => c.EmployeId).Distinct().ToList();
            int sansContrat = db.Employes.Count(e => !idsAvecContrat.Contains(e.Id));

            _nbAlertes = expirables.Count + sansContrat;
        }

        private void ChargerSecteurs(DbContextSgree db)
        {
            var employeurs = db.Employeurs.ToList();
            var contratsActifs = db.Contrats
                .Where(c => c.Statut.ToString() == "EnCours" ||
                            c.Statut.ToString() == "Actif")
                .ToList();

            _secteurs = employeurs
                .GroupBy(er => string.IsNullOrEmpty(er.SecteurActivite)
                    ? "Non defini" : er.SecteurActivite)
                .Select(g =>
                {
                    var idsEmployeurs = g.Select(x => x.Id).ToList();
                    int nb = contratsActifs
                        .Where(c => idsEmployeurs.Contains(c.EmployeurId))
                        .Select(c => c.EmployeId)
                        .Distinct()
                        .Count();
                    return (Label: g.Key, Val: nb);
                })
                .OrderByDescending(x => x.Val)
                .ToList();
        }

        private void ChargerEvolution(DbContextSgree db)
        {
            var debut = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-11);

            _evolution = db.Contrats
                .Where(c => c.DateDebut >= debut)
                .ToList()
                .GroupBy(c => new { c.DateDebut.Year, c.DateDebut.Month })
                .Select(g => (
                    Label: string.Format("{0:D4}-{1:D2}", g.Key.Year, g.Key.Month),
                    Val: g.Count()))
                .OrderBy(x => x.Label)
                .ToList();
        }

        private void ChargerTypeContrat(DbContextSgree db)
        {
            _typesContrat = db.Contrats
                .Where(c => c.Statut.ToString() == "EnCours" ||
                            c.Statut.ToString() == "Actif")
                .ToList()
                .GroupBy(c => c.TypeContrat.ToString())
                .Select(g => (Label: g.Key, Val: g.Count()))
                .OrderByDescending(x => x.Val)
                .ToList();
        }

        private void ChargerAlertes(DbContextSgree db)
        {
            var expirables = _contratService.GetContratsExpirant(30);
            var today = DateTime.Today;
            var contratsActifs = db.Contrats
                .Where(c => c.Statut.ToString() == "EnCours" ||
                            c.Statut.ToString() == "Actif")
                .ToList();
            var idsAvecContrat = contratsActifs.Select(c => c.EmployeId).Distinct().ToList();
            var sansContrat = db.Employes
                .Where(e => !idsAvecContrat.Contains(e.Id))
                .ToList();

            _dtAlertes = new DataTable();
            _dtAlertes.Columns.Add("Niveau");
            _dtAlertes.Columns.Add("Employe");
            _dtAlertes.Columns.Add("Employeur");
            _dtAlertes.Columns.Add("Type");
            _dtAlertes.Columns.Add("Echeance");
            _dtAlertes.Columns.Add("JoursRestants");

            foreach (var c in expirables.OrderBy(c => c.DateFin))
            {
                int jours = c.DateFin.HasValue
                    ? (int)(c.DateFin.Value - today).TotalDays : 0;
                string niveau = jours <= 7 ? "Critique" : jours <= 15 ? "Urgent" : "Attention";
                _dtAlertes.Rows.Add(
                    niveau,
                    c.Employe != null ? c.Employe.Nom + " " + c.Employe.Prenom : "-",
                    c.Employeur != null ? c.Employeur.RaisonSociale : "-",
                    c.TypeContrat.ToString(),
                    c.DateFin.HasValue ? c.DateFin.Value.ToString("dd/MM/yyyy") : "-",
                    jours);
            }

            foreach (var e in sansContrat)
            {
                _dtAlertes.Rows.Add(
                    "Sans contrat",
                    e.Nom + " " + e.Prenom,
                    "-", "-", "-", DBNull.Value);
            }
        }

        private void ChargerTopEmployeurs(DbContextSgree db)
        {
            var employeurs = db.Employeurs.ToList();
            var contratsActifs = db.Contrats
                .Where(c => c.Statut.ToString() == "EnCours" ||
                            c.Statut.ToString() == "Actif")
                .ToList();

            var top = employeurs
                .Select(er => new
                {
                    er.RaisonSociale,
                    NbEmployes = contratsActifs
                        .Where(c => c.EmployeurId == er.Id)
                        .Select(c => c.EmployeId)
                        .Distinct()
                        .Count(),
                    NbContrats = contratsActifs.Count(c => c.EmployeurId == er.Id),
                    MasseSalariale = contratsActifs
                        .Where(c => c.EmployeurId == er.Id)
                        .Sum(c => (decimal?)c.SalaireBase) ?? 0m
                })
                .OrderByDescending(x => x.NbEmployes)
                .Take(5)
                .ToList();

            _dtTopEmployeurs = new DataTable();
            _dtTopEmployeurs.Columns.Add("Employeur");
            _dtTopEmployeurs.Columns.Add("Employes", typeof(int));
            _dtTopEmployeurs.Columns.Add("Contrats", typeof(int));
            _dtTopEmployeurs.Columns.Add("Masse sal. (FCFA)", typeof(decimal));

            string[] medals = { "1.", "2.", "3.", "4.", "5." };
            for (int i = 0; i < top.Count; i++)
                _dtTopEmployeurs.Rows.Add(
                    medals[i] + " " + top[i].RaisonSociale,
                    top[i].NbEmployes,
                    top[i].NbContrats,
                    top[i].MasseSalariale);
        }

        // ================================================================
        //  MISE À JOUR UI
        // ================================================================
        private void MettreAJourCartes()
        {
            lblKpi1Val.Text = _nbEmployes.ToString("N0");
            lblKpi1Sub.Text = "Total enregistres";

            lblKpi2Val.Text = _nbEmployeurs.ToString("N0");
            lblKpi2Sub.Text = "Entreprises actives";

            lblKpi3Val.Text = _nbContrats.ToString("N0");
            lblKpi3Sub.Text = "Contrats en cours";

            lblKpi4Val.Text = FormatMontant(_masseSalariale);
            lblKpi4Sub.Text = "FCFA / mois";

            lblKpi5Val.Text = _nbAlertes.ToString("N0");
            lblKpi5Sub.Text = "Actions requises";

            panelKpi5.BackColor = _nbAlertes > 0
                ? Color.FromArgb(255, 220, 220)
                : Color.FromArgb(220, 255, 235);
            lblKpi5Val.ForeColor = _nbAlertes > 0
                ? Color.FromArgb(180, 0, 0)
                : Color.FromArgb(0, 130, 70);
        }

        private void MettreAJourBandeau()
        {
            if (_nbAlertes == 0) { panelAlertesBandeau.Visible = false; return; }

            int critique = _dtAlertes?.AsEnumerable()
                .Count(r => r["Niveau"].ToString() == "Critique") ?? 0;
            int urgent = _dtAlertes?.AsEnumerable()
                .Count(r => r["Niveau"].ToString() == "Urgent") ?? 0;

            if (critique > 0)
            {
                panelAlertesBandeau.BackColor = Color.FromArgb(255, 220, 220);
                lblBandeauIcone.ForeColor = Color.FromArgb(180, 0, 0);
                lblBandeauTexte.ForeColor = Color.FromArgb(140, 0, 0);
            }
            else if (urgent > 0)
            {
                panelAlertesBandeau.BackColor = Color.FromArgb(255, 237, 200);
                lblBandeauIcone.ForeColor = Color.FromArgb(180, 90, 0);
                lblBandeauTexte.ForeColor = Color.FromArgb(140, 70, 0);
            }
            else
            {
                panelAlertesBandeau.BackColor = Color.FromArgb(255, 252, 210);
                lblBandeauIcone.ForeColor = Color.FromArgb(130, 110, 0);
                lblBandeauTexte.ForeColor = Color.FromArgb(100, 85, 0);
            }

            var parties = new List<string>();
            if (critique > 0) parties.Add(critique + " critique(s) <=7j");
            if (urgent > 0) parties.Add(urgent + " urgent(s) <=15j");

            lblBandeauTexte.Text = _nbAlertes + " alerte(s) active(s)"
                + (parties.Count > 0 ? "  [" + string.Join("  |  ", parties) + "]" : "");

            panelAlertesBandeau.Visible = true;
        }

        private void BtnMasquerBandeau_Click(object sender, EventArgs e)
        {
            panelAlertesBandeau.Visible = false;
        }

        private void MettreAJourGrids()
        {
            dgvAlertes.DataSource = null;
            if (_dtAlertes != null && _dtAlertes.Rows.Count > 0)
            {
                dgvAlertes.DataSource = _dtAlertes;
                RenommerCol(dgvAlertes, "Niveau", "Niveau");
                RenommerCol(dgvAlertes, "Employe", "Employe");
                RenommerCol(dgvAlertes, "Employeur", "Employeur");
                RenommerCol(dgvAlertes, "Type", "Type");
                RenommerCol(dgvAlertes, "Echeance", "Echeance");
                RenommerCol(dgvAlertes, "JoursRestants", "Jours restants");

                if (dgvAlertes.Columns.Contains("JoursRestants"))
                {
                    dgvAlertes.Columns["JoursRestants"].Width = 100;
                    dgvAlertes.Columns["JoursRestants"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvAlertes.Columns["JoursRestants"].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    dgvAlertes.Columns["JoursRestants"].DefaultCellStyle.Font =
                        new Font("Century Gothic", 9F, FontStyle.Bold);
                }

                foreach (DataGridViewRow row in dgvAlertes.Rows)
                {
                    var jCell = row.Cells["JoursRestants"]?.Value;
                    if (jCell == null || jCell == DBNull.Value)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(80, 80, 80);
                        continue;
                    }
                    int j = Convert.ToInt32(jCell);
                    if (j <= 7)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 180, 180);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(140, 0, 0);
                        row.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
                        row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(220, 50, 50);
                        row.Cells["JoursRestants"].Style.ForeColor = Color.White;
                    }
                    else if (j <= 15)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 160);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(120, 60, 0);
                        row.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
                        row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(220, 140, 30);
                        row.Cells["JoursRestants"].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 252, 180);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(80, 70, 0);
                        row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(200, 180, 30);
                        row.Cells["JoursRestants"].Style.ForeColor = Color.White;
                    }
                }

                lblNbAlertes.Text = "(" + _dtAlertes.Rows.Count + " element(s))";
            }
            else
            {
                lblNbAlertes.Text = "(aucune alerte)";
            }

            dgvTopEmployeurs.DataSource = null;
            if (_dtTopEmployeurs != null && _dtTopEmployeurs.Rows.Count > 0)
            {
                dgvTopEmployeurs.DataSource = _dtTopEmployeurs;
                if (dgvTopEmployeurs.Columns.Contains("Masse sal. (FCFA)"))
                    dgvTopEmployeurs.Columns["Masse sal. (FCFA)"]
                        .DefaultCellStyle.Format = "N0";
            }
        }

        private void RenommerCol(DataGridView dgv, string name, string header)
        {
            if (dgv.Columns.Contains(name))
                dgv.Columns[name].HeaderText = header;
        }

        private string FormatMontant(decimal m)
        {
            if (m >= 1_000_000_000m) return (m / 1_000_000_000m).ToString("N1") + " G";
            if (m >= 1_000_000m) return (m / 1_000_000m).ToString("N1") + " M";
            if (m >= 1_000m) return (m / 1_000m).ToString("N0") + " K";
            return m.ToString("N0");
        }

        // ================================================================
        //  GRAPHIQUES GDI+
        // ================================================================
        private void PanelPieSecteur_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var panel = (Panel)sender;
            DrawTitre(g, panel, "Repartition par Secteur d'activite", Color.FromArgb(0, 122, 204));
            if (_secteurs.Count > 0)
                DrawCamembert(g, panel,
                    _secteurs.Select(x => x.Label).ToList(),
                    _secteurs.Select(x => (double)x.Val).ToList(), 34);
            else
                DrawSansDonnee(g, panel);
        }

        private void PanelBarEvolution_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var panel = (Panel)sender;
            DrawTitre(g, panel, "Evolution des Effectifs (12 mois)", Color.FromArgb(0, 160, 110));
            if (_evolution.Count > 0)
                DrawBarres(g, panel,
                    _evolution.Select(x => x.Label).ToList(),
                    _evolution.Select(x => (double)x.Val).ToList(), 34);
            else
                DrawSansDonnee(g, panel);
        }

        private void PanelPieType_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var panel = (Panel)sender;
            DrawTitre(g, panel, "Types de Contrat actifs", Color.FromArgb(180, 130, 0));
            if (_typesContrat.Count > 0)
                DrawCamembert(g, panel,
                    _typesContrat.Select(x => x.Label).ToList(),
                    _typesContrat.Select(x => (double)x.Val).ToList(), 34);
            else
                DrawSansDonnee(g, panel);
        }

        private void DrawCamembert(Graphics g, Panel panel,
            List<string> labels, List<double> values, int topOffset)
        {
            double total = values.Sum();
            if (total == 0) return;

            int h = panel.Height - topOffset;
            int pieSize = Math.Min(panel.Width / 2 - 18, h - 14);
            if (pieSize < 10) return;

            int pieX = 10;
            int pieY = topOffset + (h - pieSize) / 2;
            var rect = new Rectangle(pieX, pieY, pieSize, pieSize);

            float startAngle = -90f;
            var legend = new List<(Color c, string lbl, double v)>();

            for (int i = 0; i < values.Count; i++)
            {
                float sweep = (float)(values[i] / total * 360.0);
                Color col = _pieColors[i % _pieColors.Length];
                using (var br = new SolidBrush(col))
                    g.FillPie(br, rect, startAngle, sweep);
                using (var pen = new Pen(Color.White, 1.5f))
                    g.DrawPie(pen, rect, startAngle, sweep);
                legend.Add((col, labels[i], values[i]));
                startAngle += sweep;
            }

            int legX = pieX + pieSize + 12;
            int legY = topOffset + 4;
            using (var fBold = new Font("Century Gothic", 7.5F, FontStyle.Bold))
            using (var fNorm = new Font("Century Gothic", 7F))
            {
                foreach (var (c, lbl, v) in legend)
                {
                    if (legY + 24 > panel.Height - 4) break;
                    using (var br = new SolidBrush(c))
                        g.FillRectangle(br, legX, legY + 4, 9, 9);
                    string s = lbl.Length > 17 ? lbl.Substring(0, 15) + "..." : lbl;
                    g.DrawString(s, fBold, Brushes.Black, legX + 13, legY);
                    g.DrawString(
                        (int)v + "  (" + (v / total * 100).ToString("F1") + "%)",
                        fNorm, Brushes.Gray, legX + 13, legY + 13);
                    legY += 28;
                }
            }
        }

        private void DrawBarres(Graphics g, Panel panel,
            List<string> labels, List<double> values, int topOffset)
        {
            int areaW = panel.Width - 50;
            int areaH = panel.Height - topOffset - 34;
            int originX = 42;
            int originY = topOffset + areaH;

            double maxVal = values.Max();
            if (maxVal == 0) maxVal = 1;

            const int lines = 5;
            using (var gridPen = new Pen(Color.FromArgb(220, 220, 220), 1f))
            using (var axisFont = new Font("Century Gothic", 6.5F))
            {
                for (int i = 0; i <= lines; i++)
                {
                    int gy = originY - (int)(areaH * i / lines);
                    g.DrawLine(gridPen, originX, gy, originX + areaW, gy);
                    g.DrawString(((int)(maxVal * i / lines)).ToString(),
                        axisFont, Brushes.Gray, 2, gy - 7);
                }
            }

            int n = values.Count;
            int barW = Math.Max(8, areaW / n - 5);
            int gap = Math.Max(2, (areaW - barW * n) / (n + 1));

            using (var fVal = new Font("Century Gothic", 6F, FontStyle.Bold))
            using (var fLabel = new Font("Century Gothic", 6F))
            {
                for (int i = 0; i < n; i++)
                {
                    int barH = Math.Max(2, (int)(areaH * values[i] / maxVal));
                    int bx = originX + gap + i * (barW + gap);
                    int by = originY - barH;
                    Color col = _barColors[i % _barColors.Length];
                    Color top = Color.FromArgb(
                        Math.Min(255, col.R + 28),
                        Math.Min(255, col.G + 28),
                        Math.Min(255, col.B + 28));
                    using (var lgb = new LinearGradientBrush(
                        new Point(bx, by), new Point(bx, originY), top, col))
                        g.FillRectangle(lgb, bx, by, barW, barH);
                    if (barH > 14)
                        g.DrawString(((int)values[i]).ToString(), fVal,
                            Brushes.Black, bx + barW / 2f - 7, by - 13);
                    string lbl = labels[i];
                    if (lbl.Length > 7) lbl = lbl.Substring(lbl.Length - 5);
                    g.DrawString(lbl, fLabel, Brushes.Gray,
                        bx + barW / 2f - 13, originY + 4);
                }
            }

            using (var axPen = new Pen(Color.FromArgb(180, 180, 180), 1.5f))
            {
                g.DrawLine(axPen, originX, topOffset + 10, originX, originY);
                g.DrawLine(axPen, originX, originY, originX + areaW, originY);
            }
        }

        private void DrawTitre(Graphics g, Panel panel, string titre, Color couleur)
        {
            using (var f = new Font("Century Gothic", 9F, FontStyle.Bold))
            using (var b = new SolidBrush(couleur))
                g.DrawString(titre, f, b, 10, 8);
            using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1f))
                g.DrawLine(pen, 10, 27, panel.Width - 10, 27);
        }

        private void DrawSansDonnee(Graphics g, Panel panel)
        {
            using (var f = new Font("Century Gothic", 9F, FontStyle.Italic))
                g.DrawString("Aucune donnee disponible", f,
                    new SolidBrush(Color.LightGray),
                    panel.Width / 2f - 75, panel.Height / 2f - 10);
        }

        // ================================================================
        //  RAPPORT CRYSTAL REPORTS
        // ================================================================
        private void BtnRapport_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                var rapport = new SGREE.Reports.RptDashboardKPI();
                rapport.SetDataSource(PreparerDataSet());
                rapport.SetParameterValue("DateGeneration", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                rapport.SetParameterValue("NbEmployes",    _nbEmployes);
                rapport.SetParameterValue("NbEmployeurs",  _nbEmployeurs);
                rapport.SetParameterValue("NbContrats",    _nbContrats);
                rapport.SetParameterValue("MasseSalariale", _masseSalariale.ToString("N0") + " FCFA");
                rapport.SetParameterValue("NbAlertes",     _nbAlertes);
                var viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer
                    { Dock = DockStyle.Fill, ReportSource = rapport };
                var frm = new Form
                {
                    Text = "Rapport Tableau de Bord SGREE",
                    Size = new Size(1100, 750),
                    StartPosition = FormStartPosition.CenterScreen
                };
                frm.Controls.Add(viewer);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur Crystal Reports",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            MessageBox.Show(
                "Rapport Crystal Reports non encore configure.\n\n" +
                "1. Ajoutez RptDashboardKPI.rpt au projet (un seul fichier)\n" +
                "2. Decommentez le bloc dans BtnRapport_Click",
                "Rapport", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DataSet PreparerDataSet()
        {
            var ds = new DataSet("DashboardDS");
            var kpi = new DataTable("KPIs");
            kpi.Columns.Add("Indicateur");
            kpi.Columns.Add("Valeur");
            kpi.Rows.Add("Employes", _nbEmployes.ToString("N0"));
            kpi.Rows.Add("Employeurs", _nbEmployeurs.ToString("N0"));
            kpi.Rows.Add("Contrats actifs", _nbContrats.ToString("N0"));
            kpi.Rows.Add("Masse salariale", _masseSalariale.ToString("N0") + " FCFA");
            kpi.Rows.Add("Alertes", _nbAlertes.ToString());
            ds.Tables.Add(kpi);
            if (_dtAlertes != null) { var c = _dtAlertes.Copy(); c.TableName = "Alertes"; ds.Tables.Add(c); }
            if (_dtTopEmployeurs != null) { var c = _dtTopEmployeurs.Copy(); c.TableName = "TopEmployeurs"; ds.Tables.Add(c); }
            return ds;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }
    }
}