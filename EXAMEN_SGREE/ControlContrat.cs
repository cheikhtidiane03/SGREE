using EXAMEN_SGREE.Enums;
using EXAMEN_SGREE.Services;
using SGREE.Data;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class ControlContrat : UserControl
    {
        private readonly ContratService service = new ContratService();
        private int selectedId = 0;
        private int pageActuelle = 1;
        private int totalPages = 1;
        private List<Contrat> listeFiltree = new List<Contrat>();
        private int PageSize => (int)npuPageSize.Value;

        public ControlContrat()
        {
            InitializeComponent();
        }

        // ═══════════════════════════════════════════════════════════════
        //  LOAD
        // ═══════════════════════════════════════════════════════════════
        private void ControlContrat_Load(object sender, EventArgs e)
        {
            ChargerComboBoxes();
            AppliquerFiltres();
            Effacer();
            MettreAJourAlertes();
        }

        private void ChargerComboBoxes()
        {
            // TypeContrat
            cboTypeContrat.Items.Clear();
            foreach (TypeContrat t in Enum.GetValues(typeof(TypeContrat)))
                cboTypeContrat.Items.Add(t);
            cboTypeContrat.SelectedIndex = 0;

            // StatutContrat
            cboStatut.Items.Clear();
            foreach (StatutContrat s in Enum.GetValues(typeof(StatutContrat)))
                cboStatut.Items.Add(s);
            cboStatut.SelectedIndex = 0;

            // Filtre type
            cboFiltreType.Items.Clear();
            cboFiltreType.Items.Add("Tous");
            foreach (TypeContrat t in Enum.GetValues(typeof(TypeContrat)))
                cboFiltreType.Items.Add(t);
            cboFiltreType.SelectedIndex = 0;

            // Filtre statut
            cboFiltreStatut.Items.Clear();
            cboFiltreStatut.Items.Add("Tous");
            foreach (StatutContrat s in Enum.GetValues(typeof(StatutContrat)))
                cboFiltreStatut.Items.Add(s);
            cboFiltreStatut.SelectedIndex = 0;

            // Employés
            ChargerEmployes();

            // Employeurs
            ChargerEmployeurs();
        }

        private void ChargerEmployes()
        {
            cboEmploye.Items.Clear();
            cboEmploye.Items.Add(new ComboItem(0, "-- Selectionnez --"));
            using (var db = new DbContextSgree())
            {
                db.Employes.OrderBy(e => e.Nom).ToList()
                  .ForEach(e => cboEmploye.Items.Add(new ComboItem(e.Id, e.Nom + " " + e.Prenom)));
            }
            cboEmploye.SelectedIndex = 0;
        }

        private void ChargerEmployeurs()
        {
            cboEmployeur.Items.Clear();
            cboEmployeur.Items.Add(new ComboItem(0, "-- Selectionnez --"));
            using (var db = new DbContextSgree())
            {
                db.Employeurs.OrderBy(e => e.RaisonSociale).ToList()
                  .ForEach(e => cboEmployeur.Items.Add(new ComboItem(e.Id, e.RaisonSociale)));
            }
            cboEmployeur.SelectedIndex = 0;
        }

        private void CboEmployeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recharger les départements selon l'employeur sélectionné
            cboDepartement.Items.Clear();
            cboDepartement.Items.Add(new ComboItem(0, "-- Selectionnez --"));
            if (cboEmployeur.SelectedItem is ComboItem item && item.Id > 0)
            {
                using (var db = new DbContextSgree())
                {
                    db.Departements.Where(d => d.EmployeurId == item.Id)
                      .OrderBy(d => d.Libelle).ToList()
                      .ForEach(d => cboDepartement.Items.Add(new ComboItem(d.Id, d.Libelle)));
                }
            }
            cboDepartement.SelectedIndex = 0;
        }

        private void CboTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CDI : pas de date de fin
            bool isCDI = cboTypeContrat.SelectedItem is TypeContrat t && t == TypeContrat.CDI;
            dtpDateFin.Enabled = !isCDI;
            lblDateFin.ForeColor = isCDI ? Color.Gray : Color.Black;
            if (isCDI) dtpDateFin.Value = DateTime.Today.AddYears(10);
        }

        // ═══════════════════════════════════════════════════════════════
        //  ALERTES CONTRATS EXPIRANT
        // ═══════════════════════════════════════════════════════════════
        // ─── Timer clignotement alerte critique ──────────────────────
        private Timer timerClignotement;
        private bool etatClignotement = false;

        private void MettreAJourAlertes()
        {
            var expirables = service.GetContratsExpirant(30);

            // Arrêter l'ancien timer si existant
            if (timerClignotement != null)
            {
                timerClignotement.Stop();
                timerClignotement.Dispose();
                timerClignotement = null;
            }

            if (expirables.Count == 0)
            {
                panelAlerte.Visible = false;
                return;
            }

            // ── Compter par seuil ─────────────────────────────────────
            int nbCritiques = expirables.Count(c => c.DateFin.HasValue && (c.DateFin.Value - DateTime.Today).TotalDays <= 7);
            int nbUrgents = expirables.Count(c => c.DateFin.HasValue && (c.DateFin.Value - DateTime.Today).TotalDays > 7 && (c.DateFin.Value - DateTime.Today).TotalDays <= 15);
            int nbAttention = expirables.Count(c => c.DateFin.HasValue && (c.DateFin.Value - DateTime.Today).TotalDays > 15);

            // ── Couleur et icône du panneau selon niveau max ───────────
            if (nbCritiques > 0)
            {
                panelAlerte.BackColor = Color.FromArgb(255, 220, 220); // rouge clair
                lblAlerteIcone.Text = "⛔";
                lblAlerteIcone.ForeColor = Color.FromArgb(180, 0, 0);
                lblAlerteTexte.ForeColor = Color.FromArgb(140, 0, 0);

                // Clignotement pour les urgences critiques
                timerClignotement = new Timer { Interval = 800 };
                timerClignotement.Tick += (s, ev) =>
                {
                    etatClignotement = !etatClignotement;
                    panelAlerte.BackColor = etatClignotement
                        ? Color.FromArgb(255, 180, 180)
                        : Color.FromArgb(255, 220, 220);
                };
                timerClignotement.Start();
            }
            else if (nbUrgents > 0)
            {
                panelAlerte.BackColor = Color.FromArgb(255, 237, 200); // orange clair
                lblAlerteIcone.Text = "⚠";
                lblAlerteIcone.ForeColor = Color.FromArgb(180, 90, 0);
                lblAlerteTexte.ForeColor = Color.FromArgb(140, 70, 0);
            }
            else
            {
                panelAlerte.BackColor = Color.FromArgb(255, 252, 210); // jaune clair
                lblAlerteIcone.Text = "ℹ";
                lblAlerteIcone.ForeColor = Color.FromArgb(130, 110, 0);
                lblAlerteTexte.ForeColor = Color.FromArgb(100, 85, 0);
            }

            // ── Texte résumé avec badges ──────────────────────────────
            string resume = expirables.Count + " contrat(s) expirent dans les 30 prochains jours";
            var parties = new System.Collections.Generic.List<string>();
            if (nbCritiques > 0) parties.Add(nbCritiques + " critique(s) ≤ 7j");
            if (nbUrgents > 0) parties.Add(nbUrgents + " urgent(s) ≤ 15j");
            if (nbAttention > 0) parties.Add(nbAttention + " à surveiller");
            if (parties.Count > 0) resume += "  [" + string.Join("  |  ", parties) + "]";
            lblAlerteTexte.Text = resume;

            // ── Données grille ────────────────────────────────────────
            var donnees = expirables.Select(c => new
            {
                Urgence = GetUrgenceLabel(c),
                Numero = c.NumeroContrat,
                Employe = c.Employe != null ? c.Employe.Nom + " " + c.Employe.Prenom : "-",
                Employeur = c.Employeur != null ? c.Employeur.RaisonSociale : "-",
                Type = c.TypeContrat.ToString(),
                DateFin = c.DateFin,
                JoursRestants = c.DateFin.HasValue ? (int)(c.DateFin.Value - DateTime.Today).TotalDays : 0
            })
            .OrderBy(r => r.JoursRestants)
            .ToList();

            dgvAlertes.DataSource = null;
            dgvAlertes.DataSource = donnees;

            if (dgvAlertes.Columns.Count > 0)
            {
                dgvAlertes.Columns["Urgence"].HeaderText = "Niveau";
                dgvAlertes.Columns["Urgence"].Width = 90;
                dgvAlertes.Columns["Urgence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvAlertes.Columns["Numero"].HeaderText = "N° Contrat";
                dgvAlertes.Columns["Employe"].HeaderText = "Employe";
                dgvAlertes.Columns["Employeur"].HeaderText = "Employeur";
                dgvAlertes.Columns["Type"].HeaderText = "Type";
                dgvAlertes.Columns["DateFin"].HeaderText = "Expire le";
                dgvAlertes.Columns["DateFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvAlertes.Columns["DateFin"].Width = 90;
                dgvAlertes.Columns["DateFin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvAlertes.Columns["JoursRestants"].HeaderText = "Jours restants";
                dgvAlertes.Columns["JoursRestants"].Width = 100;
                dgvAlertes.Columns["JoursRestants"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvAlertes.Columns["JoursRestants"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAlertes.Columns["JoursRestants"].DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            }

            // ── Couleur et tooltip par ligne ──────────────────────────
            var toolTip = new ToolTip { ShowAlways = true };
            foreach (DataGridViewRow row in dgvAlertes.Rows)
            {
                if (row.Cells["JoursRestants"].Value == null) continue;
                int jours = Convert.ToInt32(row.Cells["JoursRestants"].Value);

                if (jours <= 7)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 180, 180);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(140, 0, 0);
                    row.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
                }
                else if (jours <= 15)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 160);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(120, 60, 0);
                    row.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 252, 180);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(80, 70, 0);
                }

                // Cellule "Jours restants" : fond plus intense
                if (jours <= 7)
                    row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(220, 50, 50);
                else if (jours <= 15)
                    row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(220, 140, 30);
                else
                    row.Cells["JoursRestants"].Style.BackColor = Color.FromArgb(200, 180, 30);

                row.Cells["JoursRestants"].Style.ForeColor = Color.White;
            }

            panelAlerte.Visible = true;
        }

        private string GetUrgenceLabel(Contrat c)
        {
            if (!c.DateFin.HasValue) return "-";
            int jours = (int)(c.DateFin.Value - DateTime.Today).TotalDays;
            if (jours <= 7) return "⛔ Critique";
            if (jours <= 15) return "⚠ Urgent";
            return "ℹ Attention";
        }

        // ═══════════════════════════════════════════════════════════════
        //  FILTRES
        // ═══════════════════════════════════════════════════════════════
        private void AppliquerFiltres()
        {
            var tous = service.GetAll();

            string rech = txtRecherche.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(rech))
                tous = tous.Where(c =>
                    (c.NumeroContrat != null && c.NumeroContrat.ToLower().Contains(rech)) ||
                    (c.Poste != null && c.Poste.ToLower().Contains(rech)) ||
                    (c.Employe != null && (c.Employe.Nom + " " + c.Employe.Prenom).ToLower().Contains(rech)) ||
                    (c.Employeur != null && c.Employeur.RaisonSociale.ToLower().Contains(rech))
                ).ToList();

            if (cboFiltreType.SelectedIndex > 0 && cboFiltreType.SelectedItem is TypeContrat ft)
                tous = tous.Where(c => c.TypeContrat == ft).ToList();

            if (cboFiltreStatut.SelectedIndex > 0 && cboFiltreStatut.SelectedItem is StatutContrat fs)
                tous = tous.Where(c => c.Statut == fs).ToList();

            listeFiltree = tous;
            pageActuelle = 1;
            LoadData();
        }

        // ═══════════════════════════════════════════════════════════════
        //  CHARGER DONNÉES
        // ═══════════════════════════════════════════════════════════════
        private void LoadData()
        {
            totalPages = (int)Math.Ceiling((double)listeFiltree.Count / PageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageActuelle > totalPages) pageActuelle = totalPages;
            if (pageActuelle < 1) pageActuelle = 1;

            var page = listeFiltree
                .Skip((pageActuelle - 1) * PageSize)
                .Take(PageSize)
                .Select(c => new
                {
                    c.Id,
                    c.NumeroContrat,
                    Type = c.TypeContrat.ToString(),
                    Employe = c.Employe != null ? c.Employe.Nom + " " + c.Employe.Prenom : "-",
                    Employeur = c.Employeur != null ? c.Employeur.RaisonSociale : "-",
                    Departement = c.Departement != null ? c.Departement.Libelle : "-",
                    c.Poste,
                    c.DateDebut,
                    DateFin = c.DateFin,
                    Salaire = c.SalaireBase,
                    Statut = c.Statut.ToString()
                }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = page;

            lblPage.Text = "Page " + pageActuelle + " / " + totalPages;
            btnPrecedent.Enabled = pageActuelle > 1;
            btnSuivant.Enabled = pageActuelle < totalPages;

            var cols = dataGridView1.Columns;
            if (cols.Count == 0) return;
            if (cols.Contains("Id")) cols["Id"].Visible = false;
            if (cols.Contains("NumeroContrat")) cols["NumeroContrat"].HeaderText = "N° Contrat";
            if (cols.Contains("Type")) cols["Type"].HeaderText = "Type";
            if (cols.Contains("Employe")) cols["Employe"].HeaderText = "Employe";
            if (cols.Contains("Employeur")) cols["Employeur"].HeaderText = "Employeur";
            if (cols.Contains("Departement")) cols["Departement"].HeaderText = "Departement";
            if (cols.Contains("Poste")) cols["Poste"].HeaderText = "Poste";
            if (cols.Contains("DateDebut")) { cols["DateDebut"].HeaderText = "Debut"; cols["DateDebut"].DefaultCellStyle.Format = "dd/MM/yyyy"; }
            if (cols.Contains("DateFin")) { cols["DateFin"].HeaderText = "Fin"; cols["DateFin"].DefaultCellStyle.Format = "dd/MM/yyyy"; }
            if (cols.Contains("Salaire")) { cols["Salaire"].HeaderText = "Salaire (FCFA)"; cols["Salaire"].DefaultCellStyle.Format = "N0"; }
            if (cols.Contains("Statut")) cols["Statut"].HeaderText = "Statut";

            // Colorier les lignes selon statut et expiration
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string statut = row.Cells["Statut"].Value?.ToString() ?? string.Empty;
                var contrat = listeFiltree.Skip((pageActuelle - 1) * PageSize).Take(PageSize).ElementAtOrDefault(row.Index);
                if (contrat == null) continue;

                if (statut == StatutContrat.Resilie.ToString())
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                else if (statut == StatutContrat.Termine.ToString())
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
                else if (statut == StatutContrat.Suspendu.ToString())
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 200);
                else if (contrat.DateFin.HasValue && contrat.DateFin.Value <= DateTime.Today.AddDays(30))
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 200); // expiration proche
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  EFFACER
        // ═══════════════════════════════════════════════════════════════
        private void Effacer()
        {
            selectedId = 0;
            lblNumeroVal.Text = "(genere automatiquement)";
            cboTypeContrat.SelectedIndex = 0;
            cboEmploye.SelectedIndex = 0;
            cboEmployeur.SelectedIndex = 0;
            cboDepartement.Items.Clear();
            cboDepartement.Items.Add(new ComboItem(0, "-- Selectionnez --"));
            cboDepartement.SelectedIndex = 0;
            txtPoste.Text = string.Empty;
            dtpDateDebut.Value = DateTime.Today;
            dtpDateFin.Value = DateTime.Today.AddYears(1);
            dtpDateFin.Enabled = true;
            nudSalaire.Value = SMIG;
            cboStatut.SelectedIndex = 0;
        }

        private const decimal SMIG = 60000m;

        // ═══════════════════════════════════════════════════════════════
        //  SÉLECTION GRILLE
        // ═══════════════════════════════════════════════════════════════
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            var c = service.GetById(id);
            if (c == null) return;
            PopulerFormulaire(c);
        }

        private void PopulerFormulaire(Contrat c)
        {
            selectedId = c.Id;
            lblNumeroVal.Text = c.NumeroContrat;
            cboTypeContrat.SelectedItem = c.TypeContrat;
            nudSalaire.Value = c.SalaireBase;
            txtPoste.Text = c.Poste;
            dtpDateDebut.Value = c.DateDebut;

            // CDI : date fin fictive
            bool isCDI = c.TypeContrat == TypeContrat.CDI;
            dtpDateFin.Enabled = !isCDI;
            dtpDateFin.Value = c.DateFin ?? DateTime.Today.AddYears(10);

            cboStatut.SelectedItem = c.Statut;

            // Employé
            SelectComboItem(cboEmploye, c.EmployeId);

            // Employeur (déclenche le rechargement des départements)
            SelectComboItem(cboEmployeur, c.EmployeurId);

            // Département (après rechargement)
            SelectComboItem(cboDepartement, c.DepartementId);
        }

        private void SelectComboItem(ComboBox cbo, int id)
        {
            foreach (var item in cbo.Items)
            {
                if (item is ComboItem ci && ci.Id == id)
                { cbo.SelectedItem = ci; return; }
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  BUILD CONTRAT FROM FORM
        // ═══════════════════════════════════════════════════════════════
        private Contrat GetFromForm()
        {
            bool isCDI = cboTypeContrat.SelectedItem is TypeContrat t && t == TypeContrat.CDI;
            return new Contrat
            {
                Id = selectedId,
                NumeroContrat = lblNumeroVal.Text,
                TypeContrat = cboTypeContrat.SelectedItem is TypeContrat tc ? tc : TypeContrat.CDI,
                DateDebut = dtpDateDebut.Value,
                DateFin = isCDI ? (DateTime?)null : dtpDateFin.Value,
                SalaireBase = nudSalaire.Value,
                EmployeId = cboEmploye.SelectedItem is ComboItem emp ? emp.Id : 0,
                EmployeurId = cboEmployeur.SelectedItem is ComboItem empr ? empr.Id : 0,
                DepartementId = cboDepartement.SelectedItem is ComboItem dep ? dep.Id : 0,
                Poste = txtPoste.Text.Trim(),
                Statut = cboStatut.SelectedItem is StatutContrat sc ? sc : StatutContrat.EnCours
            };
        }

        // ═══════════════════════════════════════════════════════════════
        //  CRUD
        // ═══════════════════════════════════════════════════════════════
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            var contrat = GetFromForm();
            var res = service.Add(contrat);
            if (!res.Succes)
            { MessageBox.Show(res.Message, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            AppliquerFiltres();
            MettreAJourAlertes();
            Effacer();
            MessageBox.Show(res.Message, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Selectionnez un contrat.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var contrat = GetFromForm();
            var res = service.Update(contrat);
            if (!res.Succes)
            { MessageBox.Show(res.Message, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            AppliquerFiltres();
            MettreAJourAlertes();
            Effacer();
            MessageBox.Show(res.Message, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Selectionnez un contrat.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Supprimer ce contrat ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.Delete(selectedId);
                AppliquerFiltres();
                MettreAJourAlertes();
                Effacer();
                MessageBox.Show("Contrat supprime.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e) => Effacer();

        // ─── Renouvellement ───────────────────────────────────────────
        private void BtnRenouveler_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Selectionnez un contrat a renouveler.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            using (var dlg = new FormRenouvellement(selectedId, service))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    AppliquerFiltres();
                    MettreAJourAlertes();
                    Effacer();
                }
            }
        }

        // ─── Résiliation ──────────────────────────────────────────────
        private void BtnResilier_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            { MessageBox.Show("Selectionnez un contrat a resilier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string motif = DemanderMotif("Saisissez le motif de resiliation :", "Resiliation de contrat");
            if (string.IsNullOrWhiteSpace(motif)) return;

            var res = service.Resilier(selectedId, motif);
            if (!res.Succes)
            { MessageBox.Show(res.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            AppliquerFiltres();
            MettreAJourAlertes();
            Effacer();
            MessageBox.Show(res.Message, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Remplace Microsoft.VisualBasic.Interaction.InputBox
        /// par un formulaire WinForms natif.
        /// </summary>
        private string DemanderMotif(string prompt, string titre)
        {
            string result = string.Empty;

            using (var frm = new Form())
            using (var lbl = new Label())
            using (var txt = new TextBox())
            using (var btnOk = new Button())
            using (var btnKo = new Button())
            {
                frm.Text = titre;
                frm.ClientSize = new Size(420, 140);
                frm.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;

                lbl.Text = prompt;
                lbl.AutoSize = true;
                lbl.Location = new Point(12, 14);

                txt.Location = new Point(12, 38);
                txt.Size = new Size(396, 26);
                txt.Font = new Font("Century Gothic", 10F);

                btnOk.Text = "OK";
                btnOk.DialogResult = DialogResult.OK;
                btnOk.Location = new Point(240, 95);
                btnOk.Size = new Size(80, 30);

                btnKo.Text = "Annuler";
                btnKo.DialogResult = DialogResult.Cancel;
                btnKo.Location = new Point(328, 95);
                btnKo.Size = new Size(80, 30);

                frm.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnKo });
                frm.AcceptButton = btnOk;
                frm.CancelButton = btnKo;

                if (frm.ShowDialog(this) == DialogResult.OK)
                    result = txt.Text.Trim();
            }

            return result;
        }

        // ─── Pagination ───────────────────────────────────────────────
        private void BtnPrecedent_Click(object sender, EventArgs e)
        { if (pageActuelle > 1) { pageActuelle--; LoadData(); } }

        private void BtnSuivant_Click(object sender, EventArgs e)
        { if (pageActuelle < totalPages) { pageActuelle++; LoadData(); } }

        private void NpuPageSize_ValueChanged(object sender, EventArgs e)
        { pageActuelle = 1; LoadData(); }

        private void TxtRecherche_TextChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void CboFiltreType_SelectedIndexChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void CboFiltreStatut_SelectedIndexChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void BtnReinitFiltres_Click(object sender, EventArgs e)
        { txtRecherche.Text = string.Empty; cboFiltreType.SelectedIndex = 0; cboFiltreStatut.SelectedIndex = 0; }

        private void BtnContrat_Click(object sender, EventArgs e) { }

        private void BtnMasquerAlerte_Click(object sender, EventArgs e)
        { panelAlerte.Visible = false; }

        private void BtnExportCsv_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Contrats_" + DateTime.Now.ToString("yyyyMMdd") + ".csv" };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("Numero;Type;Employe;Employeur;Departement;Poste;Debut;Fin;Salaire;Statut");
                foreach (var c in listeFiltree)
                    sb.AppendLine(c.NumeroContrat + ";" + c.TypeContrat + ";" +
                        (c.Employe != null ? c.Employe.Nom + " " + c.Employe.Prenom : "") + ";" +
                        (c.Employeur != null ? c.Employeur.RaisonSociale : "") + ";" +
                        (c.Departement != null ? c.Departement.Libelle : "") + ";" +
                        c.Poste + ";" + c.DateDebut.ToString("dd/MM/yyyy") + ";" +
                        (c.DateFin.HasValue ? c.DateFin.Value.ToString("dd/MM/yyyy") : "CDI") + ";" +
                        c.SalaireBase.ToString("N0") + ";" + c.Statut);
                System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                MessageBox.Show("Export reussi !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    // ─── Helper ComboBox item avec ID ─────────────────────────────────────
    public class ComboItem
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public ComboItem(int id, string libelle) { Id = id; Libelle = libelle; }
        public override string ToString() => Libelle;
    }
}