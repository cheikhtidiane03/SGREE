namespace EXAMEN_SGREE
{
    partial class ControlContrat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnContrat = new System.Windows.Forms.Button();
            this.panelAlerte = new System.Windows.Forms.Panel();
            this.lblAlerteIcone = new System.Windows.Forms.Label();
            this.lblAlerteTexte = new System.Windows.Forms.Label();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.btnMasquerAlerte = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.cboTypeContrat = new System.Windows.Forms.ComboBox();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.cboEmploye = new System.Windows.Forms.ComboBox();
            this.lblEmployeur = new System.Windows.Forms.Label();
            this.cboEmployeur = new System.Windows.Forms.ComboBox();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.cboDepartement = new System.Windows.Forms.ComboBox();
            this.lblPoste = new System.Windows.Forms.Label();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRenouveler = new System.Windows.Forms.Button();
            this.btnResilier = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFiltres = new System.Windows.Forms.Panel();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblFiltreType = new System.Windows.Forms.Label();
            this.cboFiltreType = new System.Windows.Forms.ComboBox();
            this.lblFiltreStatut = new System.Windows.Forms.Label();
            this.cboFiltreStatut = new System.Windows.Forms.ComboBox();
            this.btnReinitFiltres = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.npuPageSize = new System.Windows.Forms.NumericUpDown();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.panelAlerte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            this.panelBoutons.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFiltres.SuspendLayout();
            this.panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContrat
            // 
            this.btnContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnContrat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContrat.FlatAppearance.BorderSize = 0;
            this.btnContrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrat.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.Location = new System.Drawing.Point(0, 0);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(1200, 46);
            this.btnContrat.TabIndex = 0;
            this.btnContrat.Text = "Gestion des Contrats";
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.Click += new System.EventHandler(this.BtnContrat_Click);
            // 
            // panelAlerte
            // 
            this.panelAlerte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(205)))));
            this.panelAlerte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlerte.Controls.Add(this.lblAlerteIcone);
            this.panelAlerte.Controls.Add(this.lblAlerteTexte);
            this.panelAlerte.Controls.Add(this.dgvAlertes);
            this.panelAlerte.Controls.Add(this.btnMasquerAlerte);
            this.panelAlerte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlerte.Location = new System.Drawing.Point(0, 46);
            this.panelAlerte.Name = "panelAlerte";
            this.panelAlerte.Size = new System.Drawing.Size(1200, 158);
            this.panelAlerte.TabIndex = 1;
            this.panelAlerte.Visible = false;
            // 
            // lblAlerteIcone
            // 
            this.lblAlerteIcone.AutoSize = true;
            this.lblAlerteIcone.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblAlerteIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.lblAlerteIcone.Location = new System.Drawing.Point(10, 8);
            this.lblAlerteIcone.Name = "lblAlerteIcone";
            this.lblAlerteIcone.Size = new System.Drawing.Size(29, 43);
            this.lblAlerteIcone.TabIndex = 0;
            this.lblAlerteIcone.Text = "!";
            // 
            // lblAlerteTexte
            // 
            this.lblAlerteTexte.AutoSize = true;
            this.lblAlerteTexte.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlerteTexte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.lblAlerteTexte.Location = new System.Drawing.Point(35, 10);
            this.lblAlerteTexte.Name = "lblAlerteTexte";
            this.lblAlerteTexte.Size = new System.Drawing.Size(250, 23);
            this.lblAlerteTexte.TabIndex = 1;
            this.lblAlerteTexte.Text = "Contrats expirant bientot";
            // 
            // dgvAlertes
            // 
            this.dgvAlertes.AllowUserToAddRows = false;
            this.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlertes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertes.EnableHeadersVisualStyles = false;
            this.dgvAlertes.Location = new System.Drawing.Point(10, 36);
            this.dgvAlertes.MultiSelect = false;
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.ReadOnly = true;
            this.dgvAlertes.RowHeadersVisible = false;
            this.dgvAlertes.RowHeadersWidth = 62;
            this.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertes.Size = new System.Drawing.Size(1068, 110);
            this.dgvAlertes.TabIndex = 0;
            // 
            // btnMasquerAlerte
            // 
            this.btnMasquerAlerte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.btnMasquerAlerte.FlatAppearance.BorderSize = 0;
            this.btnMasquerAlerte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasquerAlerte.ForeColor = System.Drawing.Color.White;
            this.btnMasquerAlerte.Location = new System.Drawing.Point(1080, 8);
            this.btnMasquerAlerte.Name = "btnMasquerAlerte";
            this.btnMasquerAlerte.Size = new System.Drawing.Size(100, 26);
            this.btnMasquerAlerte.TabIndex = 2;
            this.btnMasquerAlerte.Text = "Masquer";
            this.btnMasquerAlerte.UseVisualStyleBackColor = false;
            this.btnMasquerAlerte.Click += new System.EventHandler(this.BtnMasquerAlerte_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblTypeContrat);
            this.panelMain.Controls.Add(this.cboTypeContrat);
            this.panelMain.Controls.Add(this.lblEmploye);
            this.panelMain.Controls.Add(this.cboEmploye);
            this.panelMain.Controls.Add(this.lblEmployeur);
            this.panelMain.Controls.Add(this.cboEmployeur);
            this.panelMain.Controls.Add(this.lblDepartement);
            this.panelMain.Controls.Add(this.cboDepartement);
            this.panelMain.Controls.Add(this.lblPoste);
            this.panelMain.Controls.Add(this.txtPoste);
            this.panelMain.Controls.Add(this.lblDateDebut);
            this.panelMain.Controls.Add(this.dtpDateDebut);
            this.panelMain.Controls.Add(this.lblDateFin);
            this.panelMain.Controls.Add(this.dtpDateFin);
            this.panelMain.Controls.Add(this.lblSalaire);
            this.panelMain.Controls.Add(this.nudSalaire);
            this.panelMain.Controls.Add(this.lblStatut);
            this.panelMain.Controls.Add(this.cboStatut);
            this.panelMain.Controls.Add(this.panelBoutons);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 204);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1200, 265);
            this.panelMain.TabIndex = 2;
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTypeContrat.Location = new System.Drawing.Point(450, 15);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(62, 22);
            this.lblTypeContrat.TabIndex = 2;
            this.lblTypeContrat.Text = "Type :";
            // 
            // cboTypeContrat
            // 
            this.cboTypeContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeContrat.Location = new System.Drawing.Point(600, 13);
            this.cboTypeContrat.Name = "cboTypeContrat";
            this.cboTypeContrat.Size = new System.Drawing.Size(180, 28);
            this.cboTypeContrat.TabIndex = 1;
            this.cboTypeContrat.SelectedIndexChanged += new System.EventHandler(this.CboTypeContrat_SelectedIndexChanged);
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmploye.Location = new System.Drawing.Point(15, 61);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(96, 22);
            this.lblEmploye.TabIndex = 3;
            this.lblEmploye.Text = "Employe :";
            // 
            // cboEmploye
            // 
            this.cboEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmploye.Location = new System.Drawing.Point(170, 59);
            this.cboEmploye.Name = "cboEmploye";
            this.cboEmploye.Size = new System.Drawing.Size(250, 28);
            this.cboEmploye.TabIndex = 2;
            // 
            // lblEmployeur
            // 
            this.lblEmployeur.AutoSize = true;
            this.lblEmployeur.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmployeur.Location = new System.Drawing.Point(450, 61);
            this.lblEmployeur.Name = "lblEmployeur";
            this.lblEmployeur.Size = new System.Drawing.Size(113, 22);
            this.lblEmployeur.TabIndex = 4;
            this.lblEmployeur.Text = "Employeur :";
            // 
            // cboEmployeur
            // 
            this.cboEmployeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeur.Location = new System.Drawing.Point(600, 59);
            this.cboEmployeur.Name = "cboEmployeur";
            this.cboEmployeur.Size = new System.Drawing.Size(250, 28);
            this.cboEmployeur.TabIndex = 3;
            this.cboEmployeur.SelectedIndexChanged += new System.EventHandler(this.CboEmployeur_SelectedIndexChanged);
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartement.Location = new System.Drawing.Point(15, 107);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(137, 22);
            this.lblDepartement.TabIndex = 5;
            this.lblDepartement.Text = "Departement :";
            // 
            // cboDepartement
            // 
            this.cboDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartement.Location = new System.Drawing.Point(170, 105);
            this.cboDepartement.Name = "cboDepartement";
            this.cboDepartement.Size = new System.Drawing.Size(250, 28);
            this.cboDepartement.TabIndex = 4;
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblPoste.Location = new System.Drawing.Point(450, 107);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(67, 22);
            this.lblPoste.TabIndex = 6;
            this.lblPoste.Text = "Poste :";
            // 
            // txtPoste
            // 
            this.txtPoste.Location = new System.Drawing.Point(600, 105);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(250, 26);
            this.txtPoste.TabIndex = 5;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateDebut.Location = new System.Drawing.Point(15, 153);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(120, 22);
            this.lblDateDebut.TabIndex = 7;
            this.lblDateDebut.Text = "Date Debut :";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(170, 151);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 26);
            this.dtpDateDebut.TabIndex = 6;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateFin.Location = new System.Drawing.Point(450, 153);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(91, 22);
            this.lblDateFin.TabIndex = 8;
            this.lblDateFin.Text = "Date Fin :";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFin.Location = new System.Drawing.Point(600, 151);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 26);
            this.dtpDateFin.TabIndex = 7;
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalaire.Location = new System.Drawing.Point(15, 199);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(126, 22);
            this.lblSalaire.TabIndex = 9;
            this.lblSalaire.Text = "Salaire Base :";
            // 
            // nudSalaire
            // 
            this.nudSalaire.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSalaire.Location = new System.Drawing.Point(170, 197);
            this.nudSalaire.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSalaire.Minimum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudSalaire.Name = "nudSalaire";
            this.nudSalaire.Size = new System.Drawing.Size(180, 26);
            this.nudSalaire.TabIndex = 8;
            this.nudSalaire.ThousandsSeparator = true;
            this.nudSalaire.Value = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatut.Location = new System.Drawing.Point(450, 199);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(67, 22);
            this.lblStatut.TabIndex = 11;
            this.lblStatut.Text = "Statut :";
            // 
            // cboStatut
            // 
            this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatut.Location = new System.Drawing.Point(600, 197);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(180, 28);
            this.cboStatut.TabIndex = 9;
            // 
            // panelBoutons
            // 
            this.panelBoutons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBoutons.Controls.Add(this.btnEnregistrer);
            this.panelBoutons.Controls.Add(this.btnAnnuler);
            this.panelBoutons.Controls.Add(this.btnModifier);
            this.panelBoutons.Controls.Add(this.btnSupprimer);
            this.panelBoutons.Controls.Add(this.btnRenouveler);
            this.panelBoutons.Controls.Add(this.btnResilier);
            this.panelBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoutons.Location = new System.Drawing.Point(0, 219);
            this.panelBoutons.Name = "panelBoutons";
            this.panelBoutons.Size = new System.Drawing.Size(1198, 44);
            this.panelBoutons.TabIndex = 20;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(5, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 32);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(135, 5);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(110, 32);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(255, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(110, 32);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(375, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(110, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnRenouveler
            // 
            this.btnRenouveler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnRenouveler.FlatAppearance.BorderSize = 0;
            this.btnRenouveler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenouveler.ForeColor = System.Drawing.Color.White;
            this.btnRenouveler.Location = new System.Drawing.Point(510, 5);
            this.btnRenouveler.Name = "btnRenouveler";
            this.btnRenouveler.Size = new System.Drawing.Size(130, 32);
            this.btnRenouveler.TabIndex = 4;
            this.btnRenouveler.Text = "Renouveler";
            this.btnRenouveler.UseVisualStyleBackColor = false;
            this.btnRenouveler.Click += new System.EventHandler(this.BtnRenouveler_Click);
            // 
            // btnResilier
            // 
            this.btnResilier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResilier.FlatAppearance.BorderSize = 0;
            this.btnResilier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResilier.ForeColor = System.Drawing.Color.White;
            this.btnResilier.Location = new System.Drawing.Point(650, 5);
            this.btnResilier.Name = "btnResilier";
            this.btnResilier.Size = new System.Drawing.Size(120, 32);
            this.btnResilier.TabIndex = 5;
            this.btnResilier.Text = "Resilier";
            this.btnResilier.UseVisualStyleBackColor = false;
            this.btnResilier.Click += new System.EventHandler(this.BtnResilier_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dataGridView1);
            this.panelBottom.Controls.Add(this.panelFiltres);
            this.panelBottom.Controls.Add(this.panelPagination);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 469);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1200, 431);
            this.panelBottom.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 339);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panelFiltres
            // 
            this.panelFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelFiltres.Controls.Add(this.lblRecherche);
            this.panelFiltres.Controls.Add(this.txtRecherche);
            this.panelFiltres.Controls.Add(this.lblFiltreType);
            this.panelFiltres.Controls.Add(this.cboFiltreType);
            this.panelFiltres.Controls.Add(this.lblFiltreStatut);
            this.panelFiltres.Controls.Add(this.cboFiltreStatut);
            this.panelFiltres.Controls.Add(this.btnReinitFiltres);
            this.panelFiltres.Controls.Add(this.btnExportCsv);
            this.panelFiltres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltres.Location = new System.Drawing.Point(0, 0);
            this.panelFiltres.Name = "panelFiltres";
            this.panelFiltres.Size = new System.Drawing.Size(1200, 46);
            this.panelFiltres.TabIndex = 0;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(10, 13);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(95, 20);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(95, 10);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(160, 26);
            this.txtRecherche.TabIndex = 0;
            this.txtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);
            // 
            // lblFiltreType
            // 
            this.lblFiltreType.AutoSize = true;
            this.lblFiltreType.Location = new System.Drawing.Point(270, 13);
            this.lblFiltreType.Name = "lblFiltreType";
            this.lblFiltreType.Size = new System.Drawing.Size(51, 20);
            this.lblFiltreType.TabIndex = 1;
            this.lblFiltreType.Text = "Type :";
            // 
            // cboFiltreType
            // 
            this.cboFiltreType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltreType.Location = new System.Drawing.Point(315, 10);
            this.cboFiltreType.Name = "cboFiltreType";
            this.cboFiltreType.Size = new System.Drawing.Size(140, 28);
            this.cboFiltreType.TabIndex = 1;
            this.cboFiltreType.SelectedIndexChanged += new System.EventHandler(this.CboFiltreType_SelectedIndexChanged);
            // 
            // lblFiltreStatut
            // 
            this.lblFiltreStatut.AutoSize = true;
            this.lblFiltreStatut.Location = new System.Drawing.Point(468, 13);
            this.lblFiltreStatut.Name = "lblFiltreStatut";
            this.lblFiltreStatut.Size = new System.Drawing.Size(61, 20);
            this.lblFiltreStatut.TabIndex = 2;
            this.lblFiltreStatut.Text = "Statut :";
            // 
            // cboFiltreStatut
            // 
            this.cboFiltreStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltreStatut.Location = new System.Drawing.Point(515, 10);
            this.cboFiltreStatut.Name = "cboFiltreStatut";
            this.cboFiltreStatut.Size = new System.Drawing.Size(140, 28);
            this.cboFiltreStatut.TabIndex = 2;
            this.cboFiltreStatut.SelectedIndexChanged += new System.EventHandler(this.CboFiltreStatut_SelectedIndexChanged);
            // 
            // btnReinitFiltres
            // 
            this.btnReinitFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReinitFiltres.FlatAppearance.BorderSize = 0;
            this.btnReinitFiltres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinitFiltres.ForeColor = System.Drawing.Color.White;
            this.btnReinitFiltres.Location = new System.Drawing.Point(668, 9);
            this.btnReinitFiltres.Name = "btnReinitFiltres";
            this.btnReinitFiltres.Size = new System.Drawing.Size(120, 28);
            this.btnReinitFiltres.TabIndex = 3;
            this.btnReinitFiltres.Text = "Reinitialiser";
            this.btnReinitFiltres.UseVisualStyleBackColor = false;
            this.btnReinitFiltres.Click += new System.EventHandler(this.BtnReinitFiltres_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(800, 9);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(120, 28);
            this.btnExportCsv.TabIndex = 4;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.BtnExportCsv_Click);
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelPagination.Controls.Add(this.lblPageSize);
            this.panelPagination.Controls.Add(this.npuPageSize);
            this.panelPagination.Controls.Add(this.btnPrecedent);
            this.panelPagination.Controls.Add(this.lblPage);
            this.panelPagination.Controls.Add(this.btnSuivant);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 385);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1200, 46);
            this.panelPagination.TabIndex = 2;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(10, 14);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(104, 20);
            this.lblPageSize.TabIndex = 0;
            this.lblPageSize.Text = "Lignes/page :";
            // 
            // npuPageSize
            // 
            this.npuPageSize.Location = new System.Drawing.Point(110, 10);
            this.npuPageSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npuPageSize.Name = "npuPageSize";
            this.npuPageSize.Size = new System.Drawing.Size(60, 26);
            this.npuPageSize.TabIndex = 0;
            this.npuPageSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.npuPageSize.ValueChanged += new System.EventHandler(this.NpuPageSize_ValueChanged);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(185, 9);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(90, 28);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "< Prec.";
            this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPage.Location = new System.Drawing.Point(285, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(100, 21);
            this.lblPage.TabIndex = 2;
            this.lblPage.Text = "Page 1 / 1";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(390, 9);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(90, 28);
            this.btnSuivant.TabIndex = 3;
            this.btnSuivant.Text = "Suiv. >";
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // ControlContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAlerte);
            this.Controls.Add(this.btnContrat);
            this.Name = "ControlContrat";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this.ControlContrat_Load);
            this.panelAlerte.ResumeLayout(false);
            this.panelAlerte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            this.panelBoutons.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFiltres.ResumeLayout(false);
            this.panelFiltres.PerformLayout();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).EndInit();
            this.ResumeLayout(false);

        }

        // ── Déclarations ──────────────────────────────────────────────────
        private System.Windows.Forms.Button btnContrat;
        private System.Windows.Forms.Panel panelAlerte;
        private System.Windows.Forms.Label lblAlerteIcone;
        private System.Windows.Forms.Label lblAlerteTexte;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.Button btnMasquerAlerte;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTypeContrat;
        private System.Windows.Forms.ComboBox cboTypeContrat;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.ComboBox cboEmploye;
        private System.Windows.Forms.Label lblEmployeur;
        private System.Windows.Forms.ComboBox cboEmployeur;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.ComboBox cboDepartement;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label lblSalaire;
        private System.Windows.Forms.NumericUpDown nudSalaire;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRenouveler;
        private System.Windows.Forms.Button btnResilier;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelFiltres;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblFiltreType;
        private System.Windows.Forms.ComboBox cboFiltreType;
        private System.Windows.Forms.Label lblFiltreStatut;
        private System.Windows.Forms.ComboBox cboFiltreStatut;
        private System.Windows.Forms.Button btnReinitFiltres;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.NumericUpDown npuPageSize;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Button btnSuivant;
    }
}