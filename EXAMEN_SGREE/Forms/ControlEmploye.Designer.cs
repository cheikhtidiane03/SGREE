namespace EXAMEN_SGREE
{
    partial class ControlEmploye
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEmploye = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNom1 = new System.Windows.Forms.TextBox();
            this.txtprenom1 = new System.Windows.Forms.TextBox();
            this.txtAdresse1 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtTelephone1 = new System.Windows.Forms.TextBox();
            this.txtCNI1 = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance1 = new System.Windows.Forms.DateTimePicker();
            this.npuEnfant = new System.Windows.Forms.NumericUpDown();
            this.GetSituationSelectionnee = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panelFiltres = new System.Windows.Forms.Panel();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblFiltreStatut = new System.Windows.Forms.Label();
            this.cboFiltreStatut = new System.Windows.Forms.ComboBox();
            this.btnReinitFiltres = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.npuPageSize = new System.Windows.Forms.NumericUpDown();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.npuEnfant)).BeginInit();
            this.panelFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.Location = new System.Drawing.Point(0, 0);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(1148, 46);
            this.btnEmploye.TabIndex = 0;
            this.btnEmploye.Text = "Gestion des Employés";
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.Click += new System.EventHandler(this.BtnEmploye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date Naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Situation matri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(440, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "nbr Enf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(440, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "CNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(440, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(440, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prenom";
            // 
            // txtNom1
            // 
            this.txtNom1.Location = new System.Drawing.Point(200, 18);
            this.txtNom1.Name = "txtNom1";
            this.txtNom1.Size = new System.Drawing.Size(200, 26);
            this.txtNom1.TabIndex = 1;
            // 
            // txtprenom1
            // 
            this.txtprenom1.Location = new System.Drawing.Point(600, 18);
            this.txtprenom1.Name = "txtprenom1";
            this.txtprenom1.Size = new System.Drawing.Size(200, 26);
            this.txtprenom1.TabIndex = 3;
            // 
            // txtAdresse1
            // 
            this.txtAdresse1.Location = new System.Drawing.Point(200, 68);
            this.txtAdresse1.Name = "txtAdresse1";
            this.txtAdresse1.Size = new System.Drawing.Size(200, 26);
            this.txtAdresse1.TabIndex = 5;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(600, 68);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(200, 26);
            this.txtEmail1.TabIndex = 7;
            // 
            // txtTelephone1
            // 
            this.txtTelephone1.Location = new System.Drawing.Point(200, 118);
            this.txtTelephone1.Name = "txtTelephone1";
            this.txtTelephone1.Size = new System.Drawing.Size(200, 26);
            this.txtTelephone1.TabIndex = 9;
            // 
            // txtCNI1
            // 
            this.txtCNI1.Location = new System.Drawing.Point(600, 118);
            this.txtCNI1.Name = "txtCNI1";
            this.txtCNI1.Size = new System.Drawing.Size(200, 26);
            this.txtCNI1.TabIndex = 11;
            // 
            // dtpDateNaissance1
            // 
            this.dtpDateNaissance1.Location = new System.Drawing.Point(200, 168);
            this.dtpDateNaissance1.Name = "dtpDateNaissance1";
            this.dtpDateNaissance1.Size = new System.Drawing.Size(200, 26);
            this.dtpDateNaissance1.TabIndex = 13;
            // 
            // npuEnfant
            // 
            this.npuEnfant.Location = new System.Drawing.Point(600, 168);
            this.npuEnfant.Name = "npuEnfant";
            this.npuEnfant.Size = new System.Drawing.Size(200, 26);
            this.npuEnfant.TabIndex = 15;
            // 
            // GetSituationSelectionnee
            // 
            this.GetSituationSelectionnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GetSituationSelectionnee.Location = new System.Drawing.Point(200, 218);
            this.GetSituationSelectionnee.Name = "GetSituationSelectionnee";
            this.GetSituationSelectionnee.Size = new System.Drawing.Size(200, 28);
            this.GetSituationSelectionnee.TabIndex = 17;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Blue;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(20, 290);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(130, 35);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAnnuler.Location = new System.Drawing.Point(170, 290);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 35);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Yellow;
            this.btnModifier.Location = new System.Drawing.Point(320, 290);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 35);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(470, 290);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 35);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // panelFiltres
            // 
            this.panelFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelFiltres.Controls.Add(this.lblRecherche);
            this.panelFiltres.Controls.Add(this.txtRecherche);
            this.panelFiltres.Controls.Add(this.lblFiltreStatut);
            this.panelFiltres.Controls.Add(this.cboFiltreStatut);
            this.panelFiltres.Controls.Add(this.btnReinitFiltres);
            this.panelFiltres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltres.Location = new System.Drawing.Point(0, 0);
            this.panelFiltres.Name = "panelFiltres";
            this.panelFiltres.Size = new System.Drawing.Size(1148, 48);
            this.panelFiltres.TabIndex = 1;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(10, 14);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(95, 20);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche :";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(100, 10);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(180, 26);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);
            // 
            // lblFiltreStatut
            // 
            this.lblFiltreStatut.AutoSize = true;
            this.lblFiltreStatut.Location = new System.Drawing.Point(300, 14);
            this.lblFiltreStatut.Name = "lblFiltreStatut";
            this.lblFiltreStatut.Size = new System.Drawing.Size(80, 20);
            this.lblFiltreStatut.TabIndex = 2;
            this.lblFiltreStatut.Text = "Situation :";
            // 
            // cboFiltreStatut
            // 
            this.cboFiltreStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltreStatut.Location = new System.Drawing.Point(380, 10);
            this.cboFiltreStatut.Name = "cboFiltreStatut";
            this.cboFiltreStatut.Size = new System.Drawing.Size(160, 28);
            this.cboFiltreStatut.TabIndex = 3;
            this.cboFiltreStatut.SelectedIndexChanged += new System.EventHandler(this.CboFiltreStatut_SelectedIndexChanged);
            // 
            // btnReinitFiltres
            // 
            this.btnReinitFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReinitFiltres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinitFiltres.ForeColor = System.Drawing.Color.White;
            this.btnReinitFiltres.Location = new System.Drawing.Point(555, 9);
            this.btnReinitFiltres.Name = "btnReinitFiltres";
            this.btnReinitFiltres.Size = new System.Drawing.Size(130, 30);
            this.btnReinitFiltres.TabIndex = 4;
            this.btnReinitFiltres.Text = "↺ Réinitialiser";
            this.btnReinitFiltres.UseVisualStyleBackColor = false;
            this.btnReinitFiltres.Click += new System.EventHandler(this.BtnReinitFiltres_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelPagination.Controls.Add(this.lblPageSize);
            this.panelPagination.Controls.Add(this.npuPageSize);
            this.panelPagination.Controls.Add(this.btnPrecedent);
            this.panelPagination.Controls.Add(this.lblPage);
            this.panelPagination.Controls.Add(this.btnSuivant);
            this.panelPagination.Controls.Add(this.btnExportExcel);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 396);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1148, 50);
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
            this.npuPageSize.TabIndex = 1;
            this.npuPageSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(200, 9);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(90, 30);
            this.btnPrecedent.TabIndex = 2;
            this.btnPrecedent.Text = "◄ Préc.";
            this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPage.Location = new System.Drawing.Point(305, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(111, 23);
            this.lblPage.TabIndex = 3;
            this.lblPage.Text = "Page 1 / 1";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(420, 9);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(90, 30);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suiv. ►";
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(550, 9);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 30);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "📥 Export CSV";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Linen;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtNom1);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.txtprenom1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtAdresse1);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.txtEmail1);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtTelephone1);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.txtCNI1);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.dtpDateNaissance1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.npuEnfant);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.GetSituationSelectionnee);
            this.panelMain.Controls.Add(this.btnEnregistrer);
            this.panelMain.Controls.Add(this.btnAnnuler);
            this.panelMain.Controls.Add(this.btnModifier);
            this.panelMain.Controls.Add(this.btnSupprimer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 46);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1148, 390);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMain_Paint);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.dataGridView1);
            this.panelBottom.Controls.Add(this.panelFiltres);
            this.panelBottom.Controls.Add(this.panelPagination);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 436);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1148, 446);
            this.panelBottom.TabIndex = 0;
            // 
            // ControlEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnEmploye);
            this.Name = "ControlEmploye";
            this.Size = new System.Drawing.Size(1148, 882);
            this.Load += new System.EventHandler(this.ControlEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.npuEnfant)).EndInit();
            this.panelFiltres.ResumeLayout(false);
            this.panelFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
        private System.Windows.Forms.Label label6, label7, label8, label9;
        private System.Windows.Forms.TextBox txtNom1, txtprenom1, txtAdresse1;
        private System.Windows.Forms.TextBox txtEmail1, txtTelephone1, txtCNI1;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance1;
        private System.Windows.Forms.NumericUpDown npuEnfant;
        private System.Windows.Forms.ComboBox GetSituationSelectionnee;
        private System.Windows.Forms.Button btnEnregistrer, btnAnnuler, btnModifier, btnSupprimer;
        private System.Windows.Forms.Panel panelMain, panelBottom, panelFiltres, panelPagination;
        private System.Windows.Forms.Label lblRecherche, lblFiltreStatut;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ComboBox cboFiltreStatut;
        private System.Windows.Forms.Button btnReinitFiltres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPageSize, lblPage;
        private System.Windows.Forms.NumericUpDown npuPageSize;
        private System.Windows.Forms.Button btnPrecedent, btnSuivant, btnExportExcel;
    }
}