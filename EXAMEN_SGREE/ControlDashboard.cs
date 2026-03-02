using EXAMEN_SGREE.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class ControlDashboard : UserControl
    {
        private readonly DashboardService service = new DashboardService();
        private Timer timerActualisation;
        private Timer timerClignotement;
        private bool etatClignotement = false;

        public ControlDashboard()
        {
            InitializeComponent();
        }

        private void ControlDashboard_Load(object sender, EventArgs e)
        {
            ChargerTout();

            // Actualisation automatique toutes les 5 minutes
            timerActualisation = new Timer { Interval = 300000 };
            timerActualisation.Tick += (s, ev) => ChargerTout();
            timerActualisation.Start();
        }

        // ═══════════════════════════════════════════════════════════════
        //  CHARGEMENT GLOBAL
        // ═══════════════════════════════════════════════════════════════
        private void ChargerTout()
        {
            try
            {
                lblDerniereMAJ.Text = "Dernière mise à jour : " + DateTime.Now.ToString("HH:mm:ss");
                ChargerKpis();
                ChargerGraphiques();
                ChargerAlertes();
                ChargerTopEmployeurs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement dashboard :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  KPIs
        // ═══════════════════════════════════════════════════════════════
        private void ChargerKpis()
        {
            var kpis = service.GetKpis();

            // Carte 1 : Employés
            lblKpi1Val.Text = kpis.TotalEmployes.ToString();
            lblKpi1Sub.Text = kpis.EmployesSansContrat + " sans contrat actif";
            lblKpi1Sub.ForeColor = kpis.EmployesSansContrat > 0
                ? Color.FromArgb(220, 80, 80) : Color.FromArgb(120, 200, 120);

            // Carte 2 : Employeurs
            lblKpi2Val.Text = kpis.TotalEmployeurs.ToString();
            lblKpi2Sub.Text = kpis.EmployeursActifs + " actifs";
            lblKpi2Sub.ForeColor = Color.FromArgb(120, 200, 120);

            // Carte 3 : Contrats
            lblKpi3Val.Text = kpis.TotalContrats.ToString();
            lblKpi3Sub.Text = kpis.ContratsActifs + " en cours";
            lblKpi3Sub.ForeColor = Color.FromArgb(120, 200, 120);

            // Carte 4 : Masse salariale
            lblKpi4Val.Text = FormatMontant(kpis.MasseSalarialeGlobale);
            lblKpi4Sub.Text = "Moy. " + FormatMontant(kpis.SalaireMoyen) + " FCFA";
            lblKpi4Sub.ForeColor = Color.FromArgb(180, 180, 180);

            // Carte 5 : Alertes expiration
            lblKpi5Val.Text = kpis.ContratsExpirantSoon.ToString();
            lblKpi5Sub.Text = "expirent dans 30 jours";
            panelKpi5.BackColor = kpis.ContratsExpirantSoon > 0
                ? Color.FromArgb(180, 60, 60) : Color.FromArgb(45, 45, 55);
            lblKpi5Val.ForeColor = kpis.ContratsExpirantSoon > 0
                ? Color.White : Color.FromArgb(100, 200, 100);

            // Clignotement si alertes critiques
            if (timerClignotement != null) { timerClignotement.Stop(); timerClignotement.Dispose(); }
            if (kpis.ContratsExpirantSoon > 0)
            {
                timerClignotement = new Timer { Interval = 900 };
                timerClignotement.Tick += (s, ev) =>
                {
                    etatClignotement = !etatClignotement;
                    panelKpi5.BackColor = etatClignotement
                        ? Color.FromArgb(220, 50, 50) : Color.FromArgb(150, 40, 40);
                };
                timerClignotement.Start();
            }
        }

        private string FormatMontant(decimal val)
        {
            if (val >= 1_000_000_000) return (val / 1_000_000_000m).ToString("N1") + " Mrd";
            if (val >= 1_000_000) return (val / 1_000_000m).ToString("N1") + " M";
            if (val >= 1_000) return (val / 1_000m).ToString("N0") + " K";
            return val.ToString("N0");
        }

        // ═══════════════════════════════════════════════════════════════
        //  GRAPHIQUES (dessin GDI+)
        // ═══════════════════════════════════════════════════════════════
        private void ChargerGraphiques()
        {
            // Invalider les panels pour forcer le repaint
            panelPieSecteur.Tag = service.GetRepartitionSecteur();
            panelBarEvolution.Tag = service.GetEvolutionMensuelle();
            panelPieType.Tag = service.GetRepartitionTypeContrat();

            panelPieSecteur.Invalidate();
            panelBarEvolution.Invalidate();
            panelPieType.Invalidate();
        }

        // ─── Camembert Secteurs ───────────────────────────────────────
        private void PanelPieSecteur_Paint(object sender, PaintEventArgs e)
        {
            var data = panelPieSecteur.Tag as List<(string Secteur, int NbEmployeurs, int NbEmployes)>;
            if (data == null || data.Count == 0) { DrawEmpty(e.Graphics, panelPieSecteur, "Aucune donnée"); return; }

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var couleurs = GetPalette();
            int total = data.Sum(x => x.NbEmployeurs);
            if (total == 0) { DrawEmpty(g, panelPieSecteur, "Aucune donnée"); return; }

            var rect = new RectangleF(20, 30, 180, 180);
            float startAngle = -90f;

            for (int i = 0; i < data.Count; i++)
            {
                float sweep = (data[i].NbEmployeurs * 360f) / total;
                using (var brush = new SolidBrush(couleurs[i % couleurs.Length]))
                    g.FillPie(brush, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweep);
                using (var pen = new Pen(Color.FromArgb(30, 30, 40), 1.5f))
                    g.DrawPie(pen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweep);
                startAngle += sweep;
            }

            // Légende
            int ly = 30;
            for (int i = 0; i < data.Count && i < 7; i++)
            {
                using (var b = new SolidBrush(couleurs[i % couleurs.Length]))
                    g.FillRectangle(b, 215, ly, 12, 12);
                using (var b = new SolidBrush(Color.FromArgb(220, 220, 220)))
                using (var font = new Font("Century Gothic", 7.5f))
                {
                    string txt = Truncate(data[i].Secteur, 16) + " (" + data[i].NbEmployeurs + ")";
                    g.DrawString(txt, font, b, 232, ly - 1);
                }
                ly += 20;
            }

            // Titre
            DrawTitreGraphique(g, "Répartition par Secteur", panelPieSecteur.Width);
        }

        // ─── Graphique en barres : Évolution mensuelle ────────────────
        private void PanelBarEvolution_Paint(object sender, PaintEventArgs e)
        {
            var data = panelBarEvolution.Tag as List<(string Mois, int NbContrats, decimal MasseSalariale)>;
            if (data == null || data.Count == 0) { DrawEmpty(e.Graphics, panelBarEvolution, "Aucune donnée"); return; }

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int margin = 55;
            int bottom = panelBarEvolution.Height - 35;
            int top = 40;
            int right = panelBarEvolution.Width - 20;
            float chartW = right - margin;
            float chartH = bottom - top;
            int n = data.Count;
            float barW = (chartW / n) * 0.55f;
            float gap = chartW / n;
            int maxContr = data.Max(x => x.NbContrats);
            if (maxContr == 0) maxContr = 1;

            // Axes
            using (var pen = new Pen(Color.FromArgb(80, 80, 90), 1f))
            {
                g.DrawLine(pen, margin, top, margin, bottom);
                g.DrawLine(pen, margin, bottom, right, bottom);
            }

            // Lignes horizontales
            for (int li = 1; li <= 4; li++)
            {
                float y = bottom - (chartH * li / 4f);
                using (var pen = new Pen(Color.FromArgb(55, 55, 65), 1f) { DashStyle = DashStyle.Dot })
                    g.DrawLine(pen, margin, y, right, y);
                using (var b = new SolidBrush(Color.FromArgb(130, 130, 140)))
                using (var font = new Font("Century Gothic", 7f))
                    g.DrawString((maxContr * li / 4).ToString(), font, b, 5, y - 7);
            }

            // Barres + étiquettes
            var coulPrimaire = Color.FromArgb(0, 140, 230);
            for (int i = 0; i < n; i++)
            {
                float x = margin + gap * i + (gap - barW) / 2f;
                float ratio = data[i].NbContrats / (float)maxContr;
                float barH = chartH * ratio;
                float y = bottom - barH;

                // Dégradé barre
                using (var brush = new LinearGradientBrush(
                    new PointF(x, y), new PointF(x, bottom),
                    Color.FromArgb(60, 180, 255), Color.FromArgb(0, 100, 180)))
                    g.FillRectangle(brush, x, y, barW, barH);

                using (var pen = new Pen(Color.FromArgb(0, 160, 220), 1f))
                    g.DrawRectangle(pen, x, y, barW, barH);

                // Valeur au-dessus
                if (data[i].NbContrats > 0)
                {
                    using (var b = new SolidBrush(Color.FromArgb(200, 200, 210)))
                    using (var font = new Font("Century Gothic", 7.5f, FontStyle.Bold))
                        g.DrawString(data[i].NbContrats.ToString(), font, b, x + barW / 2 - 6, y - 16);
                }

                // Label mois
                using (var b = new SolidBrush(Color.FromArgb(160, 160, 175)))
                using (var font = new Font("Century Gothic", 7.5f))
                    g.DrawString(data[i].Mois, font, b, x + barW / 2 - 12, bottom + 5);
            }

            DrawTitreGraphique(g, "Évolution des Effectifs (6 mois)", panelBarEvolution.Width);
        }

        // ─── Camembert Type de Contrat ────────────────────────────────
        private void PanelPieType_Paint(object sender, PaintEventArgs e)
        {
            var data = panelPieType.Tag as List<(string Type, int Nombre)>;
            if (data == null || data.Count == 0) { DrawEmpty(e.Graphics, panelPieType, "Aucune donnée"); return; }

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var couleurs = GetPalette2();
            int total = data.Sum(x => x.Nombre);
            if (total == 0) { DrawEmpty(g, panelPieType, "Aucune donnée"); return; }

            var rect = new RectangleF(20, 30, 160, 160);
            float startAngle = -90f;

            for (int i = 0; i < data.Count; i++)
            {
                float sweep = (data[i].Nombre * 360f) / total;
                using (var brush = new SolidBrush(couleurs[i % couleurs.Length]))
                    g.FillPie(brush, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweep);
                using (var pen = new Pen(Color.FromArgb(30, 30, 40), 1.5f))
                    g.DrawPie(pen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweep);
                startAngle += sweep;
            }

            // Légende
            int ly = 30;
            for (int i = 0; i < data.Count; i++)
            {
                float pct = total > 0 ? data[i].Nombre * 100f / total : 0;
                using (var b = new SolidBrush(couleurs[i % couleurs.Length]))
                    g.FillRectangle(b, 195, ly, 12, 12);
                using (var b = new SolidBrush(Color.FromArgb(220, 220, 220)))
                using (var font = new Font("Century Gothic", 7.5f))
                    g.DrawString(data[i].Type + "  " + pct.ToString("N0") + "%", font, b, 212, ly - 1);
                ly += 20;
            }

            DrawTitreGraphique(g, "Types de Contrats", panelPieType.Width);
        }

        // ─── Helpers graphiques ───────────────────────────────────────
        private void DrawTitreGraphique(Graphics g, string titre, int width)
        {
            using (var b = new SolidBrush(Color.FromArgb(210, 210, 225)))
            using (var font = new Font("Century Gothic", 9f, FontStyle.Bold))
                g.DrawString(titre, font, b, 10, 8);
        }

        private void DrawEmpty(Graphics g, Control ctrl, string msg)
        {
            using (var b = new SolidBrush(Color.FromArgb(120, 120, 135)))
            using (var font = new Font("Century Gothic", 9f))
                g.DrawString(msg, font, b, 10, ctrl.Height / 2 - 10);
        }

        private string Truncate(string s, int max) =>
            s.Length <= max ? s : s.Substring(0, max - 1) + "…";

        private Color[] GetPalette() => new[]
        {
            Color.FromArgb(0, 150, 220),  Color.FromArgb(0, 200, 150),
            Color.FromArgb(240, 170, 30), Color.FromArgb(220, 80, 80),
            Color.FromArgb(150, 90, 220), Color.FromArgb(220, 130, 30),
            Color.FromArgb(60, 200, 200), Color.FromArgb(200, 60, 140)
        };

        private Color[] GetPalette2() => new[]
        {
            Color.FromArgb(30, 160, 255),  Color.FromArgb(255, 190, 30),
            Color.FromArgb(50, 210, 140),  Color.FromArgb(255, 100, 80),
            Color.FromArgb(180, 100, 255)
        };

        // ═══════════════════════════════════════════════════════════════
        //  ALERTES
        // ═══════════════════════════════════════════════════════════════
        private void ChargerAlertes()
        {
            var alertes = service.GetAlertes();
            dgvAlertes.DataSource = null;

            if (alertes.Count == 0)
            {
                lblNbAlertes.Text = "Aucune alerte";
                lblNbAlertes.ForeColor = Color.FromArgb(100, 200, 100);
                dgvAlertes.DataSource = null;
                return;
            }

            lblNbAlertes.Text = alertes.Count + " alerte(s)";
            lblNbAlertes.ForeColor = alertes.Any(a => a.Niveau == NiveauAlerte.Critique)
                ? Color.FromArgb(255, 80, 80) : Color.FromArgb(255, 180, 50);

            dgvAlertes.DataSource = alertes.Select(a => new
            {
                Niveau = GetIconeAlerte(a.Niveau),
                Categorie = a.Categorie,
                Message = a.Message,
                Detail = a.Detail,
                Echeance = a.DateEcheance.ToString("dd/MM/yyyy")
            }).ToList();

            if (dgvAlertes.Columns.Count > 0)
            {
                dgvAlertes.Columns["Niveau"].HeaderText = "";
                dgvAlertes.Columns["Niveau"].Width = 30;
                dgvAlertes.Columns["Niveau"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvAlertes.Columns["Categorie"].HeaderText = "Catégorie";
                dgvAlertes.Columns["Categorie"].Width = 130;
                dgvAlertes.Columns["Categorie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvAlertes.Columns["Message"].HeaderText = "Message";
                dgvAlertes.Columns["Detail"].HeaderText = "Détail";
                dgvAlertes.Columns["Echeance"].HeaderText = "Échéance";
                dgvAlertes.Columns["Echeance"].Width = 80;
                dgvAlertes.Columns["Echeance"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // Colorier par niveau
            for (int i = 0; i < dgvAlertes.Rows.Count && i < alertes.Count; i++)
            {
                var row = dgvAlertes.Rows[i];
                switch (alertes[i].Niveau)
                {
                    case NiveauAlerte.Critique:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(60, 30, 30);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 150, 150);
                        break;
                    case NiveauAlerte.Urgent:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(55, 40, 20);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 200, 100);
                        break;
                    case NiveauAlerte.Attention:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 25);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(240, 230, 100);
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.FromArgb(35, 35, 50);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(160, 180, 220);
                        break;
                }
            }
        }

        private string GetIconeAlerte(NiveauAlerte n)
        {
            switch (n)
            {
                case NiveauAlerte.Critique: return "⛔";
                case NiveauAlerte.Urgent: return "⚠";
                case NiveauAlerte.Attention: return "ℹ";
                default: return "○";
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  TOP EMPLOYEURS
        // ═══════════════════════════════════════════════════════════════
        private void ChargerTopEmployeurs()
        {
            var top = service.GetTopEmployeurs();
            dgvTopEmployeurs.DataSource = null;
            dgvTopEmployeurs.DataSource = top.Select(x => new
            {
                Employeur = x.RaisonSociale,
                Secteur = x.Secteur,
                NbEmployes = x.NbEmployes,
                MasseSalariale = x.MasseSalariale.ToString("N0") + " FCFA"
            }).ToList();

            if (dgvTopEmployeurs.Columns.Count > 0)
            {
                dgvTopEmployeurs.Columns["Employeur"].HeaderText = "Employeur";
                dgvTopEmployeurs.Columns["Secteur"].HeaderText = "Secteur";
                dgvTopEmployeurs.Columns["NbEmployes"].HeaderText = "Employés";
                dgvTopEmployeurs.Columns["NbEmployes"].Width = 70;
                dgvTopEmployeurs.Columns["NbEmployes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvTopEmployeurs.Columns["MasseSalariale"].HeaderText = "Masse Salariale";
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  EVENTS
        // ═══════════════════════════════════════════════════════════════
        private void BtnActualiser_Click(object sender, EventArgs e) => ChargerTout();

        protected override void OnHandleDestroyed(EventArgs e)
        {
            timerActualisation?.Stop();
            timerActualisation?.Dispose();
            timerClignotement?.Stop();
            timerClignotement?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}