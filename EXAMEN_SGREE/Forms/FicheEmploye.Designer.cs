namespace EXAMEN_SGREE
{
    partial class FicheEmploye
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfos = new System.Windows.Forms.TabPage();
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.dgvContrats = new System.Windows.Forms.DataGridView();
            this.tabCompetences = new System.Windows.Forms.TabPage();
            this.dgvCompetences = new System.Windows.Forms.DataGridView();
            this.panelAjoutCompetence = new System.Windows.Forms.Panel();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.cboCompetence = new System.Windows.Forms.ComboBox();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.cboNiveau = new System.Windows.Forms.ComboBox();
            this.btnAjouterCompetence = new System.Windows.Forms.Button();
            this.lblDateObtention = new System.Windows.Forms.Label();
            this.dtpDateObtention = new System.Windows.Forms.DateTimePicker();
            this.lblCertification = new System.Windows.Forms.Label();
            this.chkCertifie = new System.Windows.Forms.CheckBox();
            this.btnSupprimerCompetence = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblMatriculeVal = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNomVal = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblDateNaissanceVal = new System.Windows.Forms.Label();
            this.lblCNI = new System.Windows.Forms.Label();
            this.lblCNIVal = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblAdresseVal = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblTelephoneVal = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailVal = new System.Windows.Forms.Label();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblSituationVal = new System.Windows.Forms.Label();
            this.lblEnfants = new System.Windows.Forms.Label();
            this.lblEnfantsVal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabContrats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).BeginInit();
            this.tabCompetences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetences)).BeginInit();
            this.panelAjoutCompetence.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfos);
            this.tabControl1.Controls.Add(this.tabContrats);
            this.tabControl1.Controls.Add(this.tabCompetences);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInfos
            // 
            this.tabInfos.BackColor = System.Drawing.Color.Linen;
            this.tabInfos.Location = new System.Drawing.Point(4, 32);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Size = new System.Drawing.Size(1242, 634);
            this.tabInfos.TabIndex = 0;
            this.tabInfos.Text = "Informations";
            this.tabInfos.Click += new System.EventHandler(this.tabInfos_Click);
            // 
            // tabContrats
            // 
            this.tabContrats.BackColor = System.Drawing.Color.White;
            this.tabContrats.Controls.Add(this.dgvContrats);
            this.tabContrats.Location = new System.Drawing.Point(4, 32);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Size = new System.Drawing.Size(192, 64);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Contrats";
            // 
            // dgvContrats
            // 
            this.dgvContrats.AllowUserToAddRows = false;
            this.dgvContrats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContrats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContrats.ColumnHeadersHeight = 34;
            this.dgvContrats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContrats.EnableHeadersVisualStyles = false;
            this.dgvContrats.Location = new System.Drawing.Point(0, 0);
            this.dgvContrats.Name = "dgvContrats";
            this.dgvContrats.ReadOnly = true;
            this.dgvContrats.RowHeadersWidth = 62;
            this.dgvContrats.RowTemplate.Height = 30;
            this.dgvContrats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContrats.Size = new System.Drawing.Size(192, 64);
            this.dgvContrats.TabIndex = 0;
            // 
            // tabCompetences
            // 
            this.tabCompetences.BackColor = System.Drawing.Color.White;
            this.tabCompetences.Controls.Add(this.dgvCompetences);
            this.tabCompetences.Controls.Add(this.panelAjoutCompetence);
            this.tabCompetences.Controls.Add(this.btnSupprimerCompetence);
            this.tabCompetences.Location = new System.Drawing.Point(4, 32);
            this.tabCompetences.Name = "tabCompetences";
            this.tabCompetences.Size = new System.Drawing.Size(192, 64);
            this.tabCompetences.TabIndex = 2;
            this.tabCompetences.Text = "Competences";
            // 
            // dgvCompetences
            // 
            this.dgvCompetences.AllowUserToAddRows = false;
            this.dgvCompetences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompetences.ColumnHeadersHeight = 34;
            this.dgvCompetences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompetences.EnableHeadersVisualStyles = false;
            this.dgvCompetences.Location = new System.Drawing.Point(0, 95);
            this.dgvCompetences.Name = "dgvCompetences";
            this.dgvCompetences.ReadOnly = true;
            this.dgvCompetences.RowHeadersWidth = 62;
            this.dgvCompetences.RowTemplate.Height = 30;
            this.dgvCompetences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetences.Size = new System.Drawing.Size(192, 0);
            this.dgvCompetences.TabIndex = 0;
            // 
            // panelAjoutCompetence
            // 
            this.panelAjoutCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelAjoutCompetence.Controls.Add(this.lblCompetence);
            this.panelAjoutCompetence.Controls.Add(this.cboCompetence);
            this.panelAjoutCompetence.Controls.Add(this.lblNiveau);
            this.panelAjoutCompetence.Controls.Add(this.cboNiveau);
            this.panelAjoutCompetence.Controls.Add(this.btnAjouterCompetence);
            this.panelAjoutCompetence.Controls.Add(this.lblDateObtention);
            this.panelAjoutCompetence.Controls.Add(this.dtpDateObtention);
            this.panelAjoutCompetence.Controls.Add(this.lblCertification);
            this.panelAjoutCompetence.Controls.Add(this.chkCertifie);
            this.panelAjoutCompetence.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAjoutCompetence.Location = new System.Drawing.Point(0, 0);
            this.panelAjoutCompetence.Name = "panelAjoutCompetence";
            this.panelAjoutCompetence.Size = new System.Drawing.Size(192, 95);
            this.panelAjoutCompetence.TabIndex = 1;
            // 
            // lblCompetence
            // 
            this.lblCompetence.AutoSize = true;
            this.lblCompetence.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblCompetence.Location = new System.Drawing.Point(8, 14);
            this.lblCompetence.Name = "lblCompetence";
            this.lblCompetence.Size = new System.Drawing.Size(142, 21);
            this.lblCompetence.TabIndex = 0;
            this.lblCompetence.Text = "Competence :";
            // 
            // cboCompetence
            // 
            this.cboCompetence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompetence.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cboCompetence.Location = new System.Drawing.Point(105, 10);
            this.cboCompetence.Name = "cboCompetence";
            this.cboCompetence.Size = new System.Drawing.Size(200, 29);
            this.cboCompetence.TabIndex = 1;
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblNiveau.Location = new System.Drawing.Point(320, 14);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(82, 21);
            this.lblNiveau.TabIndex = 2;
            this.lblNiveau.Text = "Niveau :";
            // 
            // cboNiveau
            // 
            this.cboNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNiveau.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cboNiveau.Location = new System.Drawing.Point(385, 10);
            this.cboNiveau.Name = "cboNiveau";
            this.cboNiveau.Size = new System.Drawing.Size(160, 29);
            this.cboNiveau.TabIndex = 3;
            // 
            // btnAjouterCompetence
            // 
            this.btnAjouterCompetence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAjouterCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCompetence.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouterCompetence.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCompetence.Location = new System.Drawing.Point(760, 10);
            this.btnAjouterCompetence.Name = "btnAjouterCompetence";
            this.btnAjouterCompetence.Size = new System.Drawing.Size(110, 70);
            this.btnAjouterCompetence.TabIndex = 4;
            this.btnAjouterCompetence.Text = "+ Ajouter";
            this.btnAjouterCompetence.UseVisualStyleBackColor = false;
            this.btnAjouterCompetence.Click += new System.EventHandler(this.btnAjouterCompetence_Click);
            // 
            // lblDateObtention
            // 
            this.lblDateObtention.AutoSize = true;
            this.lblDateObtention.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblDateObtention.Location = new System.Drawing.Point(8, 55);
            this.lblDateObtention.Name = "lblDateObtention";
            this.lblDateObtention.Size = new System.Drawing.Size(162, 21);
            this.lblDateObtention.TabIndex = 5;
            this.lblDateObtention.Text = "Date acquisition :";
            // 
            // dtpDateObtention
            // 
            this.dtpDateObtention.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateObtention.Location = new System.Drawing.Point(150, 51);
            this.dtpDateObtention.Name = "dtpDateObtention";
            this.dtpDateObtention.Size = new System.Drawing.Size(155, 32);
            this.dtpDateObtention.TabIndex = 6;
            this.dtpDateObtention.Value = new System.DateTime(2026, 2, 28, 0, 0, 0, 0);
            // 
            // lblCertification
            // 
            this.lblCertification.AutoSize = true;
            this.lblCertification.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblCertification.Location = new System.Drawing.Point(320, 55);
            this.lblCertification.Name = "lblCertification";
            this.lblCertification.Size = new System.Drawing.Size(83, 21);
            this.lblCertification.TabIndex = 7;
            this.lblCertification.Text = "Certifie :";
            // 
            // chkCertifie
            // 
            this.chkCertifie.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.chkCertifie.Location = new System.Drawing.Point(390, 53);
            this.chkCertifie.Name = "chkCertifie";
            this.chkCertifie.Size = new System.Drawing.Size(60, 28);
            this.chkCertifie.TabIndex = 8;
            this.chkCertifie.Text = "Oui";
            // 
            // btnSupprimerCompetence
            // 
            this.btnSupprimerCompetence.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerCompetence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSupprimerCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCompetence.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerCompetence.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerCompetence.Location = new System.Drawing.Point(0, 29);
            this.btnSupprimerCompetence.Name = "btnSupprimerCompetence";
            this.btnSupprimerCompetence.Size = new System.Drawing.Size(192, 35);
            this.btnSupprimerCompetence.TabIndex = 2;
            this.btnSupprimerCompetence.Text = "Supprimer la competence selectionnee";
            this.btnSupprimerCompetence.UseVisualStyleBackColor = false;
            this.btnSupprimerCompetence.Click += new System.EventHandler(this.btnSupprimerCompetence_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Controls.Add(this.btnFermer);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1250, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(214, 34);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Fiche Employe";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.Color.Red;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(1930, 10);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "X Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblMatricule
            // 
            this.lblMatricule.Location = new System.Drawing.Point(0, 0);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(100, 23);
            this.lblMatricule.TabIndex = 0;
            // 
            // lblMatriculeVal
            // 
            this.lblMatriculeVal.Location = new System.Drawing.Point(0, 0);
            this.lblMatriculeVal.Name = "lblMatriculeVal";
            this.lblMatriculeVal.Size = new System.Drawing.Size(100, 23);
            this.lblMatriculeVal.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.Location = new System.Drawing.Point(0, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.TabIndex = 0;
            // 
            // lblNomVal
            // 
            this.lblNomVal.Location = new System.Drawing.Point(0, 0);
            this.lblNomVal.Name = "lblNomVal";
            this.lblNomVal.Size = new System.Drawing.Size(100, 23);
            this.lblNomVal.TabIndex = 0;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.Location = new System.Drawing.Point(0, 0);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(100, 23);
            this.lblDateNaissance.TabIndex = 0;
            // 
            // lblDateNaissanceVal
            // 
            this.lblDateNaissanceVal.Location = new System.Drawing.Point(0, 0);
            this.lblDateNaissanceVal.Name = "lblDateNaissanceVal";
            this.lblDateNaissanceVal.Size = new System.Drawing.Size(100, 23);
            this.lblDateNaissanceVal.TabIndex = 0;
            // 
            // lblCNI
            // 
            this.lblCNI.Location = new System.Drawing.Point(0, 0);
            this.lblCNI.Name = "lblCNI";
            this.lblCNI.Size = new System.Drawing.Size(100, 23);
            this.lblCNI.TabIndex = 0;
            // 
            // lblCNIVal
            // 
            this.lblCNIVal.Location = new System.Drawing.Point(0, 0);
            this.lblCNIVal.Name = "lblCNIVal";
            this.lblCNIVal.Size = new System.Drawing.Size(100, 23);
            this.lblCNIVal.TabIndex = 0;
            // 
            // lblAdresse
            // 
            this.lblAdresse.Location = new System.Drawing.Point(0, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(100, 23);
            this.lblAdresse.TabIndex = 0;
            // 
            // lblAdresseVal
            // 
            this.lblAdresseVal.Location = new System.Drawing.Point(0, 0);
            this.lblAdresseVal.Name = "lblAdresseVal";
            this.lblAdresseVal.Size = new System.Drawing.Size(100, 23);
            this.lblAdresseVal.TabIndex = 0;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(0, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(100, 23);
            this.lblTelephone.TabIndex = 0;
            // 
            // lblTelephoneVal
            // 
            this.lblTelephoneVal.Location = new System.Drawing.Point(0, 0);
            this.lblTelephoneVal.Name = "lblTelephoneVal";
            this.lblTelephoneVal.Size = new System.Drawing.Size(100, 23);
            this.lblTelephoneVal.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 0;
            // 
            // lblEmailVal
            // 
            this.lblEmailVal.Location = new System.Drawing.Point(0, 0);
            this.lblEmailVal.Name = "lblEmailVal";
            this.lblEmailVal.Size = new System.Drawing.Size(100, 23);
            this.lblEmailVal.TabIndex = 0;
            // 
            // lblSituation
            // 
            this.lblSituation.Location = new System.Drawing.Point(0, 0);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(100, 23);
            this.lblSituation.TabIndex = 0;
            // 
            // lblSituationVal
            // 
            this.lblSituationVal.Location = new System.Drawing.Point(0, 0);
            this.lblSituationVal.Name = "lblSituationVal";
            this.lblSituationVal.Size = new System.Drawing.Size(100, 23);
            this.lblSituationVal.TabIndex = 0;
            // 
            // lblEnfants
            // 
            this.lblEnfants.Location = new System.Drawing.Point(0, 0);
            this.lblEnfants.Name = "lblEnfants";
            this.lblEnfants.Size = new System.Drawing.Size(100, 23);
            this.lblEnfants.TabIndex = 0;
            // 
            // lblEnfantsVal
            // 
            this.lblEnfantsVal.Location = new System.Drawing.Point(0, 0);
            this.lblEnfantsVal.Name = "lblEnfantsVal";
            this.lblEnfantsVal.Size = new System.Drawing.Size(100, 23);
            this.lblEnfantsVal.TabIndex = 0;
            // 
            // FicheEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 725);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1250, 725);
            this.Name = "FicheEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Employe";
            this.Load += new System.EventHandler(this.FicheEmploye_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabContrats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).EndInit();
            this.tabCompetences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetences)).EndInit();
            this.panelAjoutCompetence.ResumeLayout(false);
            this.panelAjoutCompetence.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfos, tabContrats, tabCompetences;
        private System.Windows.Forms.Panel panelHeader, panelAjoutCompetence;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblMatricule, lblMatriculeVal;
        private System.Windows.Forms.Label lblNom, lblNomVal;
        private System.Windows.Forms.Label lblDateNaissance, lblDateNaissanceVal;
        private System.Windows.Forms.Label lblCNI, lblCNIVal;
        private System.Windows.Forms.Label lblAdresse, lblAdresseVal;
        private System.Windows.Forms.Label lblTelephone, lblTelephoneVal;
        private System.Windows.Forms.Label lblEmail, lblEmailVal;
        private System.Windows.Forms.Label lblSituation, lblSituationVal;
        private System.Windows.Forms.Label lblEnfants, lblEnfantsVal;
        private System.Windows.Forms.DataGridView dgvContrats;
        private System.Windows.Forms.DataGridView dgvCompetences;
        private System.Windows.Forms.Label lblCompetence, lblNiveau, lblCertification, lblDateObtention;
        private System.Windows.Forms.ComboBox cboCompetence, cboNiveau;
        private System.Windows.Forms.DateTimePicker dtpDateObtention;
        private System.Windows.Forms.CheckBox chkCertifie;
        private System.Windows.Forms.Button btnAjouterCompetence, btnSupprimerCompetence;
    }
}