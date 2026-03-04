using System;
using System.Windows.Forms;

namespace SGREE.Forms
{
    /// <summary>
    /// Formulaire de sélection de la période pour les graphiques du tableau de bord
    /// </summary>
    public partial class FrmPeriodeSelection : Form
    {
        public DateTime DateDebut { get; private set; }
        public DateTime DateFin { get; private set; }
        public int NbMois { get; private set; } = 12;

        public FrmPeriodeSelection()
        {
            InitializeComponent();
        }

        private void FrmPeriodeSelection_Load(object sender, EventArgs e)
        {
            dtpDateFin.Value = DateTime.Today;
            dtpDateDebut.Value = DateTime.Today.AddMonths(-12);

            cmbPeriodeRapide.Items.AddRange(new object[] {
                "3 derniers mois",
                "6 derniers mois",
                "12 derniers mois",
                "Cette année",
                "Année précédente",
                "Personnalisé"
            });
            cmbPeriodeRapide.SelectedIndex = 2;
        }

        private void cmbPeriodeRapide_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool custom = cmbPeriodeRapide.SelectedIndex == 5;
            dtpDateDebut.Enabled = custom;
            dtpDateFin.Enabled = custom;

            switch (cmbPeriodeRapide.SelectedIndex)
            {
                case 0: // 3 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-3);
                    dtpDateFin.Value = DateTime.Today;
                    NbMois = 3;
                    break;
                case 1: // 6 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-6);
                    dtpDateFin.Value = DateTime.Today;
                    NbMois = 6;
                    break;
                case 2: // 12 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-12);
                    dtpDateFin.Value = DateTime.Today;
                    NbMois = 12;
                    break;
                case 3: // Cette année
                    dtpDateDebut.Value = new DateTime(DateTime.Today.Year, 1, 1);
                    dtpDateFin.Value = DateTime.Today;
                    NbMois = DateTime.Today.Month;
                    break;
                case 4: // Année précédente
                    dtpDateDebut.Value = new DateTime(DateTime.Today.Year - 1, 1, 1);
                    dtpDateFin.Value = new DateTime(DateTime.Today.Year - 1, 12, 31);
                    NbMois = 12;
                    break;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (dtpDateDebut.Value >= dtpDateFin.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateDebut = dtpDateDebut.Value;
            DateFin = dtpDateFin.Value;
            NbMois = (int)Math.Ceiling((DateFin - DateDebut).TotalDays / 30.0);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ─── Designer ────────────────────────────────────────────────────

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPeriodeRapide;
        private System.Windows.Forms.ComboBox cmbPeriodeRapide;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPeriodeRapide = new System.Windows.Forms.Label();
            this.cmbPeriodeRapide = new System.Windows.Forms.ComboBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.Text = "Sélection de la période";
            this.Size = new System.Drawing.Size(380, 260);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Load += new System.EventHandler(this.FrmPeriodeSelection_Load);

            this.lblTitre.Text = "Définir la période d'analyse";
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTitre.Location = new System.Drawing.Point(15, 15);
            this.lblTitre.Size = new System.Drawing.Size(340, 25);

            this.lblPeriodeRapide.Text = "Période rapide :";
            this.lblPeriodeRapide.Location = new System.Drawing.Point(15, 55);
            this.lblPeriodeRapide.AutoSize = true;

            this.cmbPeriodeRapide.Location = new System.Drawing.Point(15, 75);
            this.cmbPeriodeRapide.Size = new System.Drawing.Size(340, 25);
            this.cmbPeriodeRapide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodeRapide.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodeRapide_SelectedIndexChanged);

            this.lblDateDebut.Text = "Date de début :";
            this.lblDateDebut.Location = new System.Drawing.Point(15, 115);
            this.lblDateDebut.AutoSize = true;

            this.dtpDateDebut.Location = new System.Drawing.Point(15, 135);
            this.dtpDateDebut.Size = new System.Drawing.Size(160, 25);
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Enabled = false;

            this.lblDateFin.Text = "Date de fin :";
            this.lblDateFin.Location = new System.Drawing.Point(195, 115);
            this.lblDateFin.AutoSize = true;

            this.dtpDateFin.Location = new System.Drawing.Point(195, 135);
            this.dtpDateFin.Size = new System.Drawing.Size(160, 25);
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Enabled = false;

            this.btnValider.Text = "✓  Valider";
            this.btnValider.Location = new System.Drawing.Point(195, 185);
            this.btnValider.Size = new System.Drawing.Size(120, 35);
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Location = new System.Drawing.Point(60, 185);
            this.btnAnnuler.Size = new System.Drawing.Size(100, 35);
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitre, this.lblPeriodeRapide, this.cmbPeriodeRapide,
                this.lblDateDebut, this.dtpDateDebut, this.lblDateFin, this.dtpDateFin,
                this.btnValider, this.btnAnnuler
            });

            this.ResumeLayout(false);
        }
    }
}