using EXAMEN_SGREE.Enums;
using EXAMEN_SGREE.Services;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class ControlEmployeur : UserControl
    {
        private readonly EmployeurService service = new EmployeurService();
        private int selectedId = 0;
        private int pageActuelle = 1;
        private int totalPages = 1;
        private List<Employeur> listeFiltree = new List<Employeur>();
        private int PageSize => (int)npuPageSize.Value;

        public ControlEmployeur()
        {
            InitializeComponent();
        }

        private void ControlEmployeur_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            cboStatut.Items.Clear();
            foreach (StatutEmployeur s in Enum.GetValues(typeof(StatutEmployeur)))
                cboStatut.Items.Add(s);
            cboStatut.SelectedIndex = 0;
            cboFiltreStatut.Items.Clear();
            cboFiltreStatut.Items.Add("Tous");
            foreach (StatutEmployeur s in Enum.GetValues(typeof(StatutEmployeur)))
                cboFiltreStatut.Items.Add(s);
            cboFiltreStatut.SelectedIndex = 0;
            AppliquerFiltres();
            Effacer();
        }

        private void AppliquerFiltres()
        {
            var tous = service.GetAll();

            string rech = txtRecherche.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(rech))
                tous = tous.FindAll(e =>
                    (e.RaisonSociale != null && e.RaisonSociale.ToLower().Contains(rech)) ||
                    (e.NINEA != null && e.NINEA.ToLower().Contains(rech)) ||
                    (e.SecteurActivite != null && e.SecteurActivite.ToLower().Contains(rech)));

            if (cboFiltreStatut.SelectedIndex > 0 && cboFiltreStatut.SelectedItem is StatutEmployeur sit)
                tous = tous.FindAll(e => e.Statut == sit);

            listeFiltree = tous;
            pageActuelle = 1;
            LoadData();
        }

        private void LoadData()
        {
            totalPages = (int)Math.Ceiling((double)listeFiltree.Count / PageSize);
            if (totalPages == 0) totalPages = 1;
            if (pageActuelle > totalPages) pageActuelle = totalPages;
            if (pageActuelle < 1) pageActuelle = 1;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listeFiltree
                .Skip((pageActuelle - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            lblPage.Text = "Page " + pageActuelle + " / " + totalPages;
            btnPrecedent.Enabled = pageActuelle > 1;
            btnSuivant.Enabled = pageActuelle < totalPages;

            var cols = dataGridView1.Columns;
            if (cols.Count == 0) return;
            if (cols.Contains("Id")) cols["Id"].HeaderText = "ID";
            if (cols.Contains("RaisonSociale")) cols["RaisonSociale"].HeaderText = "Raison Sociale";
            if (cols.Contains("NINEA")) cols["NINEA"].HeaderText = "NINEA";
            if (cols.Contains("SecteurActivite")) cols["SecteurActivite"].HeaderText = "Secteur";
            if (cols.Contains("Adresse")) cols["Adresse"].HeaderText = "Adresse";
            if (cols.Contains("Telephone")) cols["Telephone"].HeaderText = "Telephone";
            if (cols.Contains("Email")) cols["Email"].HeaderText = "Email";
            if (cols.Contains("DateCreation"))
            {
                cols["DateCreation"].HeaderText = "Date Creation";
                cols["DateCreation"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (cols.Contains("Statut")) cols["Statut"].HeaderText = "Statut";
            if (cols.Contains("Departements")) cols["Departements"].Visible = false;
            if (cols.Contains("Contrats")) cols["Contrats"].Visible = false;
        }

        private void Effacer()
        {
            selectedId = 0;
            txtRaisonSociale.Text = string.Empty;
            txtNINEA.Text = string.Empty;
            txtSecteur.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpDateCreation.Value = DateTime.Today;
            if (cboStatut.Items.Count > 0) cboStatut.SelectedIndex = 0;
        }

        private bool Valider()
        {
            if (string.IsNullOrWhiteSpace(txtRaisonSociale.Text))
            {
                MessageBox.Show("La Raison Sociale est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRaisonSociale.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNINEA.Text))
            {
                MessageBox.Show("Le NINEA est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNINEA.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelephone.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtTelephone.Text, @"^\d+$"))
            {
                MessageBox.Show("Telephone : chiffres uniquement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelephone.Focus();
                return false;
            }

            return true;
        }

        private Employeur GetFromForm()
        {
            return new Employeur
            {
                Id = selectedId,
                RaisonSociale = txtRaisonSociale.Text.Trim(),
                NINEA = txtNINEA.Text.Trim(),
                SecteurActivite = txtSecteur.Text.Trim(),
                Adresse = txtAdresse.Text.Trim(),
                Telephone = txtTelephone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DateCreation = dtpDateCreation.Value,
                Statut = (StatutEmployeur)cboStatut.SelectedItem
            };
        }

        private void BtnEmployeur_Click(object sender, EventArgs e) { }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var emp = service.GetById(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value));
            if (emp == null) return;
            selectedId = emp.Id;
            txtRaisonSociale.Text = emp.RaisonSociale;
            txtNINEA.Text = emp.NINEA;
            txtSecteur.Text = emp.SecteurActivite;
            txtAdresse.Text = emp.Adresse;
            txtTelephone.Text = emp.Telephone;
            txtEmail.Text = emp.Email;
            dtpDateCreation.Value = emp.DateCreation;
            cboStatut.SelectedItem = emp.Statut;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var emp = service.GetById(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value));
            if (emp == null) return;
            using (var fiche = new FicheEmployeur(emp))
                fiche.ShowDialog(this);
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!Valider()) return;
            var emp = GetFromForm();
            if (service.NIEAExists(emp.NINEA))
            {
                MessageBox.Show("Un employeur avec ce NINEA existe deja.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            service.Add(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employeur enregistre avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Selectionnez un employeur.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Valider()) return;
            var emp = GetFromForm();
            if (service.NIEAExists(emp.NINEA, emp.Id))
            {
                MessageBox.Show("Ce NINEA est deja utilise.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            service.Update(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employeur modifie avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Selectionnez un employeur.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Supprimer cet employeur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                service.Delete(selectedId);
                AppliquerFiltres();
                Effacer();
                MessageBox.Show("Employeur supprime avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e) => Effacer();

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            if (pageActuelle > 1) { pageActuelle--; LoadData(); }
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            if (pageActuelle < totalPages) { pageActuelle++; LoadData(); }
        }

        private void NpuPageSize_ValueChanged(object sender, EventArgs e)
        {
            pageActuelle = 1;
            LoadData();
        }

        private void TxtRecherche_TextChanged(object sender, EventArgs e) => AppliquerFiltres();

        private void CboFiltreStatut_SelectedIndexChanged(object sender, EventArgs e) => AppliquerFiltres();

        private void BtnReinitFiltres_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = string.Empty;
            cboFiltreStatut.SelectedIndex = 0;
        }

        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new SaveFileDialog
                {
                    Filter = "CSV|*.csv",
                    FileName = "Employeurs_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
                };
                if (dlg.ShowDialog() != DialogResult.OK) return;
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("ID;Raison Sociale;NINEA;Secteur;Adresse;Telephone;Email;Date Creation;Statut");
                foreach (var emp in listeFiltree)
                    sb.AppendLine(emp.Id + ";" + emp.RaisonSociale + ";" + emp.NINEA + ";" +
                                  emp.SecteurActivite + ";" + emp.Adresse + ";" + emp.Telephone + ";" +
                                  emp.Email + ";" + emp.DateCreation.ToString("dd/MM/yyyy") + ";" + emp.Statut);
                System.IO.File.WriteAllText(dlg.FileName, sb.ToString(), System.Text.Encoding.UTF8);
                MessageBox.Show("Export reussi !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}