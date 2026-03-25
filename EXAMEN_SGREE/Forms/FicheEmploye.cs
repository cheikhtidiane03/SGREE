using EXAMEN_SGREE.Enums;
using SGREE.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            if (this.DesignMode) return;

            InitInfosTab();
            ChargerInfosPersonnelles();
            ChargerContrats();

            cboNiveau.Items.Clear();
            foreach (NiveauCompetence n in Enum.GetValues(typeof(NiveauCompetence)))
                cboNiveau.Items.Add(n);
            cboNiveau.SelectedIndex = -1;

            ChargerListeCompetences();
            ChargerCompetences();
        }

        // ================================================================
        //  CONSTRUCTION DYNAMIQUE TAB INFOS
        // ================================================================
        private void InitInfosTab()
        {
            // ── Header bleu ──────────────────────────────────────────────
            var panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                BackColor = Color.FromArgb(0, 122, 204)
            };
            var lblTitreInfo = new Label
            {
                Text = "Informations personnelles",
                Font = new Font("Century Gothic", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(15, 13)
            };
            panelTop.Controls.Add(lblTitreInfo);
            tabInfos.Controls.Add(panelTop);

            // ── PictureBox photo (côté droit du header) ──────────────────
            picFichePhoto = new PictureBox
            {
                Size = new Size(110, 110),
                Location = new Point(tabInfos.Width - 130, 65),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(230, 230, 240),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            tabInfos.Controls.Add(picFichePhoto);

            // ── Grille des informations ──────────────────────────────────
            int lx1 = 30, vx1 = 190;   // colonne gauche
            int lx2 = 510, vx2 = 670;   // colonne droite
            int startY = 75, rowH = 52;

            AddInfoRow(lx1, vx1, startY + rowH * 0, "Matricule :", lblMatricule, lblMatriculeVal);
            AddInfoRow(lx2, vx2, startY + rowH * 0, "Nom Complet :", lblNom, lblNomVal);

            AddInfoRow(lx1, vx1, startY + rowH * 1, "Date Naissance :", lblDateNaissance, lblDateNaissanceVal);
            AddInfoRow(lx2, vx2, startY + rowH * 1, "CNI :", lblCNI, lblCNIVal);

            AddInfoRow(lx1, vx1, startY + rowH * 2, "Adresse :", lblAdresse, lblAdresseVal);
            AddInfoRow(lx2, vx2, startY + rowH * 2, "Telephone :", lblTelephone, lblTelephoneVal);

            AddInfoRow(lx1, vx1, startY + rowH * 3, "Email :", lblEmail, lblEmailVal);
            AddInfoRow(lx2, vx2, startY + rowH * 3, "Situation :", lblSituation, lblSituationVal);

            AddInfoRow(lx1, vx1, startY + rowH * 4, "Nbr Enfants :", lblEnfants, lblEnfantsVal);

            // Séparateur
            var sep = new Panel
            {
                Location = new Point(20, startY + rowH * 5 + 5),
                Size = new Size(950, 2),
                BackColor = Color.FromArgb(0, 122, 204)
            };
            tabInfos.Controls.Add(sep);
        }

        private void AddInfoRow(int x1, int x2, int y,
            string labelText, Label lbl, Label val)
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

        // ================================================================
        //  INFOS PERSONNELLES + PHOTO
        // ================================================================
        private void ChargerInfosPersonnelles()
        {
            lblMatriculeVal.Text = _employe.Id.ToString();
            lblNomVal.Text = _employe.Nom + " " + _employe.Prenom;
            lblDateNaissanceVal.Text = _employe.DateNaissance.ToString("dd/MM/yyyy");
            lblCNIVal.Text = _employe.CNI ?? "-";
            lblAdresseVal.Text = _employe.Adresse ?? "-";
            lblTelephoneVal.Text = _employe.Telephone ?? "-";
            lblEmailVal.Text = _employe.Email ?? "-";
            lblSituationVal.Text = _employe.SituationMatrimoniale.ToString();
            lblEnfantsVal.Text = _employe.NombreEnfants.ToString();

            // ── Affichage photo ──────────────────────────────────────────
            AfficherPhotoFiche(_employe.Photo);
        }

        /// <summary>Affiche la photo dans le PictureBox de la fiche.</summary>
        private void AfficherPhotoFiche(byte[] photoData)
        {
            if (picFichePhoto == null) return;

            if (photoData != null && photoData.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(photoData))
                        picFichePhoto.Image = Image.FromStream(ms);

                    // Tooltip avec le nom complet
                    var tip = new ToolTip();
                    tip.SetToolTip(picFichePhoto,
                        _employe.Nom + " " + _employe.Prenom);
                }
                catch
                {
                    picFichePhoto.Image = null;
                    picFichePhoto.BackColor = Color.FromArgb(220, 220, 230);
                }
            }
            else
            {
                // Silhouette par défaut
                picFichePhoto.Image = null;
                picFichePhoto.BackColor = Color.FromArgb(220, 220, 230);

                // Dessiner "Pas de photo" centré
                picFichePhoto.Paint += (s, pe) =>
                {
                    if (picFichePhoto.Image != null) return;
                    using (var f = new Font("Segoe UI", 7.5F, FontStyle.Italic))
                    using (var b = new SolidBrush(Color.FromArgb(150, 150, 160)))
                    {
                        var sz = pe.Graphics.MeasureString("Pas de photo", f);
                        float px = (picFichePhoto.Width - sz.Width) / 2f;
                        float py = (picFichePhoto.Height - sz.Height) / 2f;
                        pe.Graphics.DrawString("Pas de photo", f, b, px, py);
                    }
                };
            }
        }

        // ================================================================
        //  CONTRATS
        // ================================================================
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
                MessageBox.Show("Erreur chargement contrats :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================================================================
        //  COMPÉTENCES
        // ================================================================
        private void ChargerListeCompetences()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var liste = db.Competences.ToList();
                    if (liste.Count == 0)
                    {
                        MessageBox.Show(
                            "Aucune competence dans la base.\nAjoutez d'abord des competences.",
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
                MessageBox.Show("Erreur chargement competences :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                MessageBox.Show("Erreur chargement competences employe :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Ajouter compétence ───────────────────────────────────────────
        private void BtnAjouterCompetence_Click(object sender, EventArgs e)
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
                    if (db.EmployeCompetences.Any(
                            ec => ec.EmployeId == _employe.Id && ec.CompetenceId == competenceId))
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
                MessageBox.Show("Competence ajoutee avec succes !", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ajout :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Supprimer compétence ─────────────────────────────────────────
        private void BtnSupprimerCompetence_Click(object sender, EventArgs e)
        {
            if (dgvCompetences.CurrentRow == null)
            { MessageBox.Show("Selectionnez une competence.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Supprimer cette competence ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int competenceId = Convert.ToInt32(
                    dgvCompetences.CurrentRow.Cells["CompetenceId"].Value);

                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var ec = db.EmployeCompetences.FirstOrDefault(
                        x => x.EmployeId == _employe.Id && x.CompetenceId == competenceId);
                    if (ec != null) { db.EmployeCompetences.Remove(ec); db.SaveChanges(); }
                }

                ChargerCompetences();
                MessageBox.Show("Competence supprimee.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur suppression :\n" + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Fermer ───────────────────────────────────────────────────────
        private void BtnFermer_Click(object sender, EventArgs e) => Close();

        private void TabInfos_Click(object sender, EventArgs e) { }
        private void PanelHeader_Paint(object sender, PaintEventArgs e) { }

        // ── Champ photo (déclaré ici car créé dynamiquement) ─────────────
        private PictureBox picFichePhoto;
    }
}