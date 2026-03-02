using EXAMEN_SGREE.Enums;
using EXAMEN_SGREE.Services;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class ControlEmploye : UserControl
    {
        private readonly EmployeService _service = new EmployeService();
        private int _selectedId = 0;
        private int _pageActuelle = 1;
        private int _totalPages = 1;
        private List<Employe> _listeFiltree = new List<Employe>();
        private int PageSize => (int)npuPageSize.Value;

        public ControlEmploye()
        {
            InitializeComponent();
        }

        private void ControlEmploye_Load(object sender, EventArgs e)
        {
            GetSituationSelectionnee.Items.Clear();
            foreach (SituationMatrimoniale s in Enum.GetValues(typeof(SituationMatrimoniale)))
                GetSituationSelectionnee.Items.Add(s);
            GetSituationSelectionnee.SelectedIndex = 0;

            cboFiltreStatut.Items.Clear();
            cboFiltreStatut.Items.Add("Tous");
            foreach (SituationMatrimoniale s in Enum.GetValues(typeof(SituationMatrimoniale)))
                cboFiltreStatut.Items.Add(s);
            cboFiltreStatut.SelectedIndex = 0;

            npuPageSize.ValueChanged += new EventHandler(npuPageSize_ValueChanged);

            AppliquerFiltres();
            Effacer();
        }



        // ─── FILTRES ─────────────────────────────────────────────────────
        private void AppliquerFiltres()
        {
            var tous = _service.GetAll();

            // Filtre nom/prénom
            string recherche = txtRecherche.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(recherche))
                tous = tous.Where(e =>
                    (e.Nom != null && e.Nom.ToLower().Contains(recherche)) ||
                    (e.Prenom != null && e.Prenom.ToLower().Contains(recherche))).ToList();

            // Filtre situation matrimoniale
            if (cboFiltreStatut.SelectedIndex > 0)
            {
                var sit = (SituationMatrimoniale)cboFiltreStatut.SelectedItem;
                tous = tous.Where(e => e.SituationMatrimoniale == sit).ToList();
            }

            _listeFiltree = tous;
            _pageActuelle = 1;
            LoadData();
        }

        // ─── CHARGER DONNEES ─────────────────────────────────────────────
        private void LoadData()
        {
            _totalPages = (int)Math.Ceiling((double)_listeFiltree.Count / PageSize);
            if (_totalPages == 0) _totalPages = 1;
            if (_pageActuelle > _totalPages) _pageActuelle = _totalPages;
            if (_pageActuelle < 1) _pageActuelle = 1;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _listeFiltree
                .Skip((_pageActuelle - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            lblPage.Text = $"Page {_pageActuelle} / {_totalPages}";
            btnPrecedent.Enabled = _pageActuelle > 1;
            btnSuivant.Enabled = _pageActuelle < _totalPages;

            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].HeaderText = "Matricule";
                dataGridView1.Columns["Id"].DisplayIndex = 0;
                dataGridView1.Columns["Id"].Visible = true;
            }
        }

        // ─── EFFACER ─────────────────────────────────────────────────────
        private void Effacer()
        {
            _selectedId = 0;
            txtNom1.Text = "";
            txtprenom1.Text = "";
            txtAdresse1.Text = "";
            txtEmail1.Text = "";
            txtTelephone1.Text = "";
            txtCNI1.Text = "";
            dtpDateNaissance1.Value = DateTime.Today;
            npuEnfant.Value = 0;
            GetSituationSelectionnee.SelectedIndex = 0;
        }

        // ─── VALIDATION ──────────────────────────────────────────────────
        private bool Valider()
        {
            if (string.IsNullOrWhiteSpace(txtNom1.Text))
            { MessageBox.Show("Le champ Nom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtNom1.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtprenom1.Text))
            { MessageBox.Show("Le champ Prénom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtprenom1.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtCNI1.Text))
            { MessageBox.Show("Le champ CNI est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtCNI1.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtEmail1.Text) && !txtEmail1.Text.Contains("@"))
            { MessageBox.Show("L'adresse Email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtEmail1.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtTelephone1.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtTelephone1.Text, @"^\d+$"))
            { MessageBox.Show("Le Téléphone doit contenir uniquement des chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTelephone1.Focus(); return false; }
            return true;
        }

        private Employe GetEmployeFromForm()
        {
            return new Employe
            {
                Id = _selectedId,
                Nom = txtNom1.Text.Trim(),
                Prenom = txtprenom1.Text.Trim(),
                Adresse = txtAdresse1.Text.Trim(),
                Email = txtEmail1.Text.Trim(),
                Telephone = txtTelephone1.Text.Trim(),
                CNI = txtCNI1.Text.Trim(),
                DateNaissance = dtpDateNaissance1.Value,
                NombreEnfants = (int)npuEnfant.Value,
                SituationMatrimoniale = (SituationMatrimoniale)GetSituationSelectionnee.SelectedItem
            };
        }

        // ─── SELECTION GRILLE ────────────────────────────────────────────
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var emp = _service.GetById(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value));
            if (emp == null) return;

            _selectedId = emp.Id;
            txtNom1.Text = emp.Nom;
            txtprenom1.Text = emp.Prenom;
            txtAdresse1.Text = emp.Adresse;
            txtEmail1.Text = emp.Email;
            txtTelephone1.Text = emp.Telephone;
            txtCNI1.Text = emp.CNI;
            dtpDateNaissance1.Value = emp.DateNaissance;
            npuEnfant.Value = emp.NombreEnfants;
            GetSituationSelectionnee.SelectedItem = emp.SituationMatrimoniale;
        }

        // ─── ENREGISTRER ─────────────────────────────────────────────────
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            if (!Valider()) return;
            var emp = GetEmployeFromForm();
            if (_service.CNIExists(emp.CNI))
            { MessageBox.Show("Un employé avec ce CNI existe déjà.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            _service.Add(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employé enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── MODIFIER ────────────────────────────────────────────────────
        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            { MessageBox.Show("Veuillez sélectionner un employé à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!Valider()) return;
            var emp = GetEmployeFromForm();
            if (_service.CNIExists(emp.CNI, emp.Id))
            { MessageBox.Show("Un autre employé possède déjà ce CNI.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            _service.Update(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employé modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ─── SUPPRIMER ───────────────────────────────────────────────────
        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            { MessageBox.Show("Veuillez sélectionner un employé à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet employé ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(_selectedId);
                AppliquerFiltres();
                Effacer();
                MessageBox.Show("Employé supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e) => Effacer();

        // ─── PAGINATION ──────────────────────────────────────────────────
        private void btnPrecedent_Click(object sender, EventArgs e)
        { if (_pageActuelle > 1) { _pageActuelle--; LoadData(); } }

        private void btnSuivant_Click(object sender, EventArgs e)
        { if (_pageActuelle < _totalPages) { _pageActuelle++; LoadData(); } }

        private void npuPageSize_ValueChanged(object sender, EventArgs e)
        { _pageActuelle = 1; LoadData(); }

        // ─── FILTRES EVENTS ───────────────────────────────────────────────
        private void txtRecherche_TextChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void cboFiltreStatut_SelectedIndexChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void btnReinitFiltres_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            cboFiltreStatut.SelectedIndex = 0;
            AppliquerFiltres();
        }

        // ─── EXPORT EXCEL ────────────────────────────────────────────────
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = $"Employes_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                    Title = "Exporter vers Excel"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                ExportToExcel(_listeFiltree, saveDialog.FileName);
                MessageBox.Show($"Export réussi !\n{saveDialog.FileName}", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ouvrir le fichier
                System.Diagnostics.Process.Start(saveDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'export : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(List<Employe> employes, string filePath)
        {
            // Utilise ClosedXML si disponible, sinon CSV renommé en xlsx basique
            // Pour utiliser cette fonction, installer : Install-Package ClosedXML
            try
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Employés");

                    // En-têtes
                    string[] headers = { "Matricule", "Nom", "Prénom", "Date Naissance",
                                         "CNI", "Adresse", "Téléphone", "Email",
                                         "Situation Matri.", "Nbr Enfants" };

                    for (int i = 0; i < headers.Length; i++)
                    {
                        ws.Cell(1, i + 1).Value = headers[i];
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                        ws.Cell(1, i + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#0078CC");
                        ws.Cell(1, i + 1).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                        ws.Cell(1, i + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                    }

                    // Données
                    for (int i = 0; i < employes.Count; i++)
                    {
                        var emp = employes[i];
                        int row = i + 2;
                        ws.Cell(row, 1).Value = emp.Id;
                        ws.Cell(row, 2).Value = emp.Nom;
                        ws.Cell(row, 3).Value = emp.Prenom;
                        ws.Cell(row, 4).Value = emp.DateNaissance.ToString("dd/MM/yyyy");
                        ws.Cell(row, 5).Value = emp.CNI;
                        ws.Cell(row, 6).Value = emp.Adresse;
                        ws.Cell(row, 7).Value = emp.Telephone;
                        ws.Cell(row, 8).Value = emp.Email;
                        ws.Cell(row, 9).Value = emp.SituationMatrimoniale.ToString();
                        ws.Cell(row, 10).Value = emp.NombreEnfants;

                        // Alternance couleurs lignes
                        if (i % 2 == 0)
                            ws.Row(row).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#F5F5F5");
                    }

                    // Ajuster largeurs
                    ws.Columns().AdjustToContents();

                    // Bordures
                    var range = ws.Range(1, 1, employes.Count + 1, headers.Length);
                    range.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    range.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;

                    workbook.SaveAs(filePath);
                }
            }
            catch
            {
                // Fallback CSV si ClosedXML non installé
                ExportToCsvFallback(employes, filePath);
            }
        }

        private void ExportToCsvFallback(List<Employe> employes, string filePath)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("Matricule;Nom;Prénom;Date Naissance;CNI;Adresse;Téléphone;Email;Situation;Nbr Enfants");
            foreach (var emp in employes)
                sb.AppendLine($"{emp.Id};{emp.Nom};{emp.Prenom};{emp.DateNaissance:dd/MM/yyyy};" +
                              $"{emp.CNI};{emp.Adresse};{emp.Telephone};{emp.Email};" +
                              $"{emp.SituationMatrimoniale};{emp.NombreEnfants}");
            System.IO.File.WriteAllText(filePath.Replace(".xlsx", ".csv"), sb.ToString(),
                System.Text.Encoding.UTF8);
        }

        private void btnEmploye_Click(object sender, EventArgs e) { }

        // Remplacez dataGridView1_CellClick_1 par CellDoubleClick
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var emp = _service.GetById(
                Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value));
            if (emp == null) return;

            using (var fiche = new FicheEmploye(emp))
                fiche.ShowDialog(this);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
