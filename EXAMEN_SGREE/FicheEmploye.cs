using EXAMEN_SGREE.Enums;
using SGREE.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace EXAMEN_SGREE
{
    public partial class FicheEmploye : Form
    {
        private readonly Employe _employe;

        public FicheEmploye(Employe employe)
        {
            InitializeComponent();
            _employe = employe;
        }

        private void FicheEmploye_Load(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode ==
                System.ComponentModel.LicenseUsageMode.Designtime) return;

            // Construire les labels d'infos ici (pas dans le Designer)
            InitInfosTab();

            ChargerInfosPersonnelles();
            ChargerContrats();

            // Niveaux depuis enum
            cboNiveau.Items.Clear();
            foreach (NiveauCompetence n in Enum.GetValues(typeof(NiveauCompetence)))
                cboNiveau.Items.Add(n);
            cboNiveau.SelectedIndex = -1;

            ChargerListeCompetences();
            ChargerCompetences();
        }

        // ─── CONSTRUCTION DYNAMIQUE TAB INFOS ────────────────────────────
        private void InitInfosTab()
        {
            // Header bleu
            var panelTop = new Panel();
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 55;
            panelTop.BackColor = Color.FromArgb(0, 122, 204);
            var lblTitreInfo = new Label();
            lblTitreInfo.Text = "Informations personnelles";
            lblTitreInfo.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            lblTitreInfo.ForeColor = Color.White;
            lblTitreInfo.AutoSize = true;
            lblTitreInfo.Location = new Point(15, 13);
            panelTop.Controls.Add(lblTitreInfo);
            tabInfos.Controls.Add(panelTop);

            // 2 colonnes bien espacées
            int lx1 = 30, vx1 = 190; // colonne gauche  : label à 30, valeur à 190
            int lx2 = 510, vx2 = 670; // colonne droite  : label à 510, valeur à 670
            int startY = 75, rowH = 52;

            // Colonne gauche             // Colonne droite
            AddInfoRow(lx1, vx1, startY + rowH * 0, "Matricule :", lblMatricule, lblMatriculeVal);
            AddInfoRow(lx2, vx2, startY + rowH * 0, "Nom Complet :", lblNom, lblNomVal);

            AddInfoRow(lx1, vx1, startY + rowH * 1, "Date Naissance :", lblDateNaissance, lblDateNaissanceVal);
            AddInfoRow(lx2, vx2, startY + rowH * 1, "CNI :", lblCNI, lblCNIVal);

            AddInfoRow(lx1, vx1, startY + rowH * 2, "Adresse :", lblAdresse, lblAdresseVal);
            AddInfoRow(lx2, vx2, startY + rowH * 2, "Telephone :", lblTelephone, lblTelephoneVal);

            AddInfoRow(lx1, vx1, startY + rowH * 3, "Email :", lblEmail, lblEmailVal);
            AddInfoRow(lx2, vx2, startY + rowH * 3, "Situation :", lblSituation, lblSituationVal);

            AddInfoRow(lx1, vx1, startY + rowH * 4, "Nbr Enfants :", lblEnfants, lblEnfantsVal);

            var sep = new Panel();
            sep.Location = new Point(20, startY + rowH * 5 + 5);
            sep.Size = new Size(950, 2);
            sep.BackColor = Color.FromArgb(0, 122, 204);
            tabInfos.Controls.Add(sep);
        }

        private void AddInfoRow(int x1, int x2, int y, string labelText, Label lbl, Label val)
        {
            var boldFont = new Font("Century Gothic", 10F, FontStyle.Bold);
            var valueFont = new Font("Century Gothic", 10F);
            var valueColor = Color.FromArgb(50, 50, 50);

            lbl.AutoSize = true;
            lbl.Font = boldFont;
            lbl.Location = new Point(x1, y);
            lbl.Text = labelText;
            if (!tabInfos.Controls.Contains(lbl))
                tabInfos.Controls.Add(lbl);

            val.AutoSize = true;
            val.Font = valueFont;
            val.ForeColor = valueColor;
            val.Location = new Point(x2, y);
            val.Text = "-";
            if (!tabInfos.Controls.Contains(val))
                tabInfos.Controls.Add(val);
        }

        // ─── INFOS PERSONNELLES ──────────────────────────────────────────
        private void ChargerInfosPersonnelles()
        {
            lblMatriculeVal.Text = _employe.Id.ToString();
            lblNomVal.Text = $"{_employe.Nom} {_employe.Prenom}";
            lblDateNaissanceVal.Text = _employe.DateNaissance.ToString("dd/MM/yyyy");
            lblCNIVal.Text = _employe.CNI ?? "-";
            lblAdresseVal.Text = _employe.Adresse ?? "-";
            lblTelephoneVal.Text = _employe.Telephone ?? "-";
            lblEmailVal.Text = _employe.Email ?? "-";
            lblSituationVal.Text = _employe.SituationMatrimoniale.ToString();
            lblEnfantsVal.Text = _employe.NombreEnfants.ToString();
        }

        // ─── CONTRATS ────────────────────────────────────────────────────
        private void ChargerContrats()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var contrats = db.Contrats
                        .Where(c => c.EmployeId == _employe.Id)
                        .Select(c => new
                        {
                            c.Id,
                            c.NumeroContrat,
                            Departement = c.Departement.Libelle,
                            Employeur = c.Employeur.RaisonSociale,
                            c.DateDebut,
                            c.DateFin,
                            Type = c.TypeContrat.ToString(),
                            c.Poste,
                            c.SalaireBase,
                            Statut = c.Statut.ToString()
                        })
                        .ToList();

                    dgvContrats.DataSource = null;
                    dgvContrats.DataSource = contrats;

                    if (dgvContrats.Columns.Count > 0)
                    {
                        dgvContrats.Columns["Id"].Visible = false;
                        dgvContrats.Columns["NumeroContrat"].HeaderText = "N Contrat";
                        dgvContrats.Columns["Departement"].HeaderText = "Departement";
                        dgvContrats.Columns["Employeur"].HeaderText = "Employeur";
                        dgvContrats.Columns["DateDebut"].HeaderText = "Debut";
                        dgvContrats.Columns["DateFin"].HeaderText = "Fin";
                        dgvContrats.Columns["Type"].HeaderText = "Type";
                        dgvContrats.Columns["Poste"].HeaderText = "Poste";
                        dgvContrats.Columns["SalaireBase"].HeaderText = "Salaire (FCFA)";
                        dgvContrats.Columns["Statut"].HeaderText = "Statut";

                        dgvContrats.Columns["DateDebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvContrats.Columns["DateFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvContrats.Columns["SalaireBase"].DefaultCellStyle.Format = "N0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement contrats :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── LISTE COMPETENCES DISPONIBLES ───────────────────────────────
        private void ChargerListeCompetences()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var liste = db.Competences.ToList();
                    if (liste.Count == 0)
                    {
                        MessageBox.Show("Aucune competence dans la base.\nAjoutez d'abord des competences.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    cboCompetence.DataSource = liste;
                    cboCompetence.DisplayMember = "Libelle";
                    cboCompetence.ValueMember = "Id";
                    cboCompetence.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement competences :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── COMPETENCES DE L'EMPLOYE ────────────────────────────────────
        private void ChargerCompetences()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var competences = db.EmployeCompetences
                        .Where(ec => ec.EmployeId == _employe.Id)
                        .Select(ec => new
                        {
                            ec.CompetenceId,
                            Competence = ec.Competence.Libelle,
                            Niveau = ec.Niveau.ToString(),
                            ec.DateAcquisition,
                            Certifie = ec.Certifie ? "Oui" : "Non"
                        })
                        .ToList();

                    dgvCompetences.DataSource = null;
                    dgvCompetences.DataSource = competences;

                    if (dgvCompetences.Columns.Count > 0)
                    {
                        dgvCompetences.Columns["CompetenceId"].Visible = false;
                        dgvCompetences.Columns["Competence"].HeaderText = "Competence";
                        dgvCompetences.Columns["Niveau"].HeaderText = "Niveau";
                        dgvCompetences.Columns["DateAcquisition"].HeaderText = "Date Acquisition";
                        dgvCompetences.Columns["Certifie"].HeaderText = "Certifie";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement competences employe :\n{ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── AJOUTER COMPETENCE ──────────────────────────────────────────
        private void btnAjouterCompetence_Click(object sender, EventArgs e)
        {
            if (cboCompetence.SelectedIndex < 0 || cboCompetence.SelectedValue == null)
            { MessageBox.Show("Selectionnez une competence.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (cboNiveau.SelectedIndex < 0)
            { MessageBox.Show("Selectionnez un niveau.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                int competenceId = (int)cboCompetence.SelectedValue;

                using (var db = new SGREE.Data.DbContextSgree())
                {
                    bool existe = db.EmployeCompetences
                        .Any(ec => ec.EmployeId == _employe.Id && ec.CompetenceId == competenceId);

                    if (existe)
                    { MessageBox.Show("Competence deja assignee.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

                    db.EmployeCompetences.Add(new SGREE.Models.EmployeCompetence
                    {
                        EmployeId = _employe.Id,
                        CompetenceId = competenceId,
                        Niveau = (NiveauCompetence)cboNiveau.SelectedItem,
                        DateAcquisition = dtpDateObtention.Value,
                        Certifie = chkCertifie.Checked
                    });
                    db.SaveChanges();
                }

                cboCompetence.SelectedIndex = -1;
                cboNiveau.SelectedIndex = -1;
                chkCertifie.Checked = false;
                dtpDateObtention.Value = DateTime.Today;

                ChargerCompetences();
                MessageBox.Show("Competence ajoutee avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajout :\n{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SUPPRIMER COMPETENCE ────────────────────────────────────────
        private void btnSupprimerCompetence_Click(object sender, EventArgs e)
        {
            if (dgvCompetences.CurrentRow == null)
            { MessageBox.Show("Selectionnez une competence.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Supprimer cette competence ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int competenceId = Convert.ToInt32(dgvCompetences.CurrentRow.Cells["CompetenceId"].Value);

                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var ec = db.EmployeCompetences.FirstOrDefault(
                        x => x.EmployeId == _employe.Id && x.CompetenceId == competenceId);
                    if (ec != null) { db.EmployeCompetences.Remove(ec); db.SaveChanges(); }
                }

                ChargerCompetences();
                MessageBox.Show("Competence supprimee.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur suppression :\n{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── FERMER ──────────────────────────────────────────────────────
        private void btnFermer_Click(object sender, EventArgs e) => this.Close();

        private void tabInfos_Click(object sender, EventArgs e)
        {

        }
    }
}