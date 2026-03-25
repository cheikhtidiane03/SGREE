using EXAMEN_SGREE.Enums;
using EXAMEN_SGREE.Services;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        // Variables pour la photo
        private byte[] _photoBytes = null;
        private string _photoPath = null;

        public ControlEmploye()
        {
            InitializeComponent();
        }

        private void ControlEmploye_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            GetSituationSelectionnee.Items.Clear();
            foreach (SituationMatrimoniale s in Enum.GetValues(typeof(SituationMatrimoniale)))
                GetSituationSelectionnee.Items.Add(s);
            GetSituationSelectionnee.SelectedIndex = 0;

            cboFiltreStatut.Items.Clear();
            cboFiltreStatut.Items.Add("Tous");
            foreach (SituationMatrimoniale s in Enum.GetValues(typeof(SituationMatrimoniale)))
                cboFiltreStatut.Items.Add(s);
            cboFiltreStatut.SelectedIndex = 0;

            npuPageSize.ValueChanged += new EventHandler(NpuPageSize_ValueChanged);

            // Configurer le DataGridView pour les images
            ConfigureDataGridView();

            AppliquerFiltres();
            Effacer();
        }

        // Configuration du DataGridView
        private void ConfigureDataGridView()
        {
            // Ajouter la colonne photo si elle n'existe pas
            if (!dataGridView1.Columns.Contains("PhotoColumn"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "PhotoColumn";
                imgCol.HeaderText = "Photo";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.Width = 100;
                dataGridView1.Columns.Add(imgCol);
            }
        }

        // ─── FILTRES ──────────────────────────────────────────────────────
        private void AppliquerFiltres()
        {
            var tous = _service.GetAll();

            string recherche = txtRecherche.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(recherche))
                tous = tous.Where(e =>
                    (e.Nom != null && e.Nom.ToLower().Contains(recherche)) ||
                    (e.Prenom != null && e.Prenom.ToLower().Contains(recherche))).ToList();

            if (cboFiltreStatut.SelectedIndex > 0)
            {
                var sit = (SituationMatrimoniale)cboFiltreStatut.SelectedItem;
                tous = tous.Where(e => e.SituationMatrimoniale == sit).ToList();
            }

            _listeFiltree = tous;
            _pageActuelle = 1;
            LoadData();
        }

        // ─── CHARGER DONNÉES ──────────────────────────────────────────────
        private void LoadData()
        {
            _totalPages = (int)Math.Ceiling((double)_listeFiltree.Count / PageSize);
            if (_totalPages == 0) _totalPages = 1;
            if (_pageActuelle > _totalPages) _pageActuelle = _totalPages;
            if (_pageActuelle < 1) _pageActuelle = 1;

            var pageData = _listeFiltree
                .Skip((_pageActuelle - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            // Désactiver temporairement les événements
            dataGridView1.DataSource = null;

            // Créer une liste d'objets avec les données et les images
            var displayList = pageData.Select(emp => new EmployeDisplay
            {
                Id = emp.Id,
                Nom = emp.Nom,
                Prenom = emp.Prenom,
                DateNaissance = emp.DateNaissance,
                CNI = emp.CNI,
                Adresse = emp.Adresse,
                Telephone = emp.Telephone,
                Email = emp.Email,
                SituationMatrimoniale = emp.SituationMatrimoniale.ToString(),
                NombreEnfants = emp.NombreEnfants,
                PhotoImage = ConvertByteArrayToImage(emp.Photo)
            }).ToList();

            dataGridView1.DataSource = displayList;

            // Masquer la colonne PhotoImage et utiliser PhotoColumn à la place
            if (dataGridView1.Columns.Contains("PhotoImage"))
            {
                dataGridView1.Columns["PhotoImage"].Visible = false;
            }

            // Remplir la colonne d'images
            if (dataGridView1.Columns.Contains("PhotoColumn"))
            {
                dataGridView1.Columns["PhotoColumn"].DisplayIndex = 0;
                for (int i = 0; i < displayList.Count; i++)
                {
                    if (displayList[i].PhotoImage != null)
                    {
                        dataGridView1.Rows[i].Cells["PhotoColumn"].Value = displayList[i].PhotoImage;
                    }
                    else
                    {
                        // Créer une image par défaut (icône ou placeholder)
                        dataGridView1.Rows[i].Cells["PhotoColumn"].Value = CreateDefaultImage();
                    }
                }
            }

            // Configurer l'affichage des colonnes
            if (dataGridView1.Columns.Contains("Id"))
            {
                dataGridView1.Columns["Id"].HeaderText = "Matricule";
                dataGridView1.Columns["Id"].DisplayIndex = 1;
            }
            if (dataGridView1.Columns.Contains("Nom"))
                dataGridView1.Columns["Nom"].DisplayIndex = 2;
            if (dataGridView1.Columns.Contains("Prenom"))
                dataGridView1.Columns["Prenom"].DisplayIndex = 3;
            if (dataGridView1.Columns.Contains("DateNaissance"))
                dataGridView1.Columns["DateNaissance"].DisplayIndex = 4;
            if (dataGridView1.Columns.Contains("CNI"))
                dataGridView1.Columns["CNI"].DisplayIndex = 5;
            if (dataGridView1.Columns.Contains("Adresse"))
                dataGridView1.Columns["Adresse"].DisplayIndex = 6;
            if (dataGridView1.Columns.Contains("Telephone"))
                dataGridView1.Columns["Telephone"].DisplayIndex = 7;
            if (dataGridView1.Columns.Contains("Email"))
                dataGridView1.Columns["Email"].DisplayIndex = 8;
            if (dataGridView1.Columns.Contains("SituationMatrimoniale"))
                dataGridView1.Columns["SituationMatrimoniale"].DisplayIndex = 9;
            if (dataGridView1.Columns.Contains("NombreEnfants"))
                dataGridView1.Columns["NombreEnfants"].DisplayIndex = 10;

            lblPage.Text = $"Page {_pageActuelle} / {_totalPages}";
            btnPrecedent.Enabled = _pageActuelle > 1;
            btnSuivant.Enabled = _pageActuelle < _totalPages;
        }

        // Convertir byte[] en Image
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            try
            {
                using (var ms = new MemoryStream(byteArray))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        // Créer une image par défaut
        private Image CreateDefaultImage()
        {
            Bitmap defaultImage = new Bitmap(80, 80);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 8))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    g.DrawString("Pas de\nphoto", font, brush, 20, 30);
                }
            }
            return defaultImage;
        }

        // ─── EFFACER ──────────────────────────────────────────────────────
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

            // Réinitialiser la photo
            _photoBytes = null;
            _photoPath = null;
            if (picPhoto != null)
            {
                picPhoto.Image = null;
                picPhoto.BackColor = System.Drawing.Color.LightGray;
            }
            if (lblPhotoStatus != null)
            {
                lblPhotoStatus.Text = "Aucune photo";
                lblPhotoStatus.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // ─── VALIDATION ───────────────────────────────────────────────────
        private bool Valider()
        {
            if (string.IsNullOrWhiteSpace(txtNom1.Text))
            { MessageBox.Show("Le champ Nom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtNom1.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtprenom1.Text))
            { MessageBox.Show("Le champ Prenom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtprenom1.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtCNI1.Text))
            { MessageBox.Show("Le champ CNI est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtCNI1.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtEmail1.Text) && !txtEmail1.Text.Contains("@"))
            { MessageBox.Show("L'adresse Email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtEmail1.Focus(); return false; }
            if (!string.IsNullOrWhiteSpace(txtTelephone1.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtTelephone1.Text, @"^\d+$"))
            { MessageBox.Show("Le Telephone doit contenir uniquement des chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); txtTelephone1.Focus(); return false; }
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
                SituationMatrimoniale = (SituationMatrimoniale)GetSituationSelectionnee.SelectedItem,
                Photo = _photoBytes
            };
        }

        // ─── SÉLECTION GRILLE ─────────────────────────────────────────────
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Récupérer l'ID depuis la source de données
            var idValue = dataGridView1.Rows[e.RowIndex].Cells["Id"]?.Value;
            if (idValue == null) return;

            var emp = _service.GetById(Convert.ToInt32(idValue));
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

            // Charger la photo si elle existe
            if (emp.Photo != null && emp.Photo.Length > 0)
            {
                _photoBytes = emp.Photo;
                try
                {
                    using (var ms = new MemoryStream(emp.Photo))
                    {
                        picPhoto.Image = Image.FromStream(ms);
                        picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    lblPhotoStatus.Text = "Photo existante";
                    lblPhotoStatus.ForeColor = System.Drawing.Color.Blue;
                }
                catch
                {
                    picPhoto.Image = null;
                    lblPhotoStatus.Text = "Photo corrompue";
                    lblPhotoStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                _photoBytes = null;
                picPhoto.Image = null;
                picPhoto.BackColor = System.Drawing.Color.LightGray;
                lblPhotoStatus.Text = "Aucune photo";
                lblPhotoStatus.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var idValue = dataGridView1.Rows[e.RowIndex].Cells["Id"]?.Value;
            if (idValue == null) return;

            var emp = _service.GetById(Convert.ToInt32(idValue));
            if (emp == null) return;
            using (var fiche = new FicheEmploye(emp))
                fiche.ShowDialog(this);
        }

        // ─── CRUD ─────────────────────────────────────────────────────────
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!Valider()) return;
            var emp = GetEmployeFromForm();
            if (_service.CNIExists(emp.CNI))
            { MessageBox.Show("Un employe avec ce CNI existe deja.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            _service.Add(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employe enregistre avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            { MessageBox.Show("Selectionnez un employe a modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!Valider()) return;
            var emp = GetEmployeFromForm();
            if (_service.CNIExists(emp.CNI, emp.Id))
            { MessageBox.Show("Un autre employe possede deja ce CNI.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            _service.Update(emp);
            AppliquerFiltres();
            Effacer();
            MessageBox.Show("Employe modifie avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            { MessageBox.Show("Selectionnez un employe a supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (MessageBox.Show("Supprimer cet employe ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(_selectedId);
                AppliquerFiltres();
                Effacer();
                MessageBox.Show("Employe supprime avec succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e) => Effacer();

        // ─── PAGINATION ───────────────────────────────────────────────────
        private void BtnPrecedent_Click(object sender, EventArgs e)
        { if (_pageActuelle > 1) { _pageActuelle--; LoadData(); } }

        private void BtnSuivant_Click(object sender, EventArgs e)
        { if (_pageActuelle < _totalPages) { _pageActuelle++; LoadData(); } }

        private void NpuPageSize_ValueChanged(object sender, EventArgs e)
        { _pageActuelle = 1; LoadData(); }

        // ─── FILTRES EVENTS ───────────────────────────────────────────────
        private void TxtRecherche_TextChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void CboFiltreStatut_SelectedIndexChanged(object sender, EventArgs e) => AppliquerFiltres();
        private void BtnReinitFiltres_Click(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
            cboFiltreStatut.SelectedIndex = 0;
            AppliquerFiltres();
        }

        // ─── AUTRES ───────────────────────────────────────────────────────
        private void BtnEmploye_Click(object sender, EventArgs e) { }

        private void PanelMain_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // ─── GESTION PHOTO ─────────────────────────────────────────────────
        private void BtnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Sélectionner une photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _photoPath = openFileDialog.FileName;
                        _photoBytes = File.ReadAllBytes(_photoPath);

                        using (var ms = new MemoryStream(_photoBytes))
                        {
                            picPhoto.Image = Image.FromStream(ms);
                            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        lblPhotoStatus.Text = "Photo sélectionnée";
                        lblPhotoStatus.ForeColor = System.Drawing.Color.Green;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors du chargement de l'image : {ex.Message}",
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // ─── EXPORT EXCEL ─────────────────────────────────────────────────
        private void BtnExportExcel_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Export reussi !\n{saveDialog.FileName}", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Employes");
                    string[] headers = { "Matricule", "Nom", "Prenom", "Date Naissance",
                                         "CNI", "Adresse", "Telephone", "Email",
                                         "Situation Matri.", "Nbr Enfants", "Photo" };
                    for (int i = 0; i < headers.Length; i++)
                    {
                        ws.Cell(1, i + 1).Value = headers[i];
                        ws.Cell(1, i + 1).Style.Font.Bold = true;
                        ws.Cell(1, i + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.FromHtml("#0078CC");
                        ws.Cell(1, i + 1).Style.Font.FontColor = ClosedXML.Excel.XLColor.White;
                        ws.Cell(1, i + 1).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                    }
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

                        if (emp.Photo != null && emp.Photo.Length > 0)
                        {
                            ws.Cell(row, 11).Value = Convert.ToBase64String(emp.Photo);
                        }
                        else
                        {
                            ws.Cell(row, 11).Value = "";
                        }

                        if (i % 2 == 0)
                            ws.Row(row).Style.Fill.BackgroundColor =
                                ClosedXML.Excel.XLColor.FromHtml("#F5F5F5");
                    }
                    ws.Columns().AdjustToContents();
                    var range = ws.Range(1, 1, employes.Count + 1, headers.Length);
                    range.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    range.Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    workbook.SaveAs(filePath);
                }
            }
            catch
            {
                ExportToCsvFallback(employes, filePath);
            }
        }

        private void ExportToCsvFallback(List<Employe> employes, string filePath)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("Matricule;Nom;Prenom;Date Naissance;CNI;Adresse;Telephone;Email;Situation;Nbr Enfants;Photo");
            foreach (var emp in employes)
            {
                string photoBase64 = "";
                if (emp.Photo != null && emp.Photo.Length > 0)
                {
                    photoBase64 = Convert.ToBase64String(emp.Photo);
                }
                sb.AppendLine(
                    $"{emp.Id};{emp.Nom};{emp.Prenom};{emp.DateNaissance:dd/MM/yyyy};" +
                    $"{emp.CNI};{emp.Adresse};{emp.Telephone};{emp.Email};" +
                    $"{emp.SituationMatrimoniale};{emp.NombreEnfants};{photoBase64}");
            }
            System.IO.File.WriteAllText(
                filePath.Replace(".xlsx", ".csv"), sb.ToString(),
                System.Text.Encoding.UTF8);
        }
    }

    // Classe helper pour l'affichage dans le DataGridView
    public class EmployeDisplay
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string CNI { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string SituationMatrimoniale { get; set; }
        public int NombreEnfants { get; set; }
        public Image PhotoImage { get; set; }
    }
}