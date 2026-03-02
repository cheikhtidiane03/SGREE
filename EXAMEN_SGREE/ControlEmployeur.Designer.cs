namespace EXAMEN_SGREE
{
    partial class ControlEmployeur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEmployeur = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaisonSociale = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNINEA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateCreation = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboStatut = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
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

            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).BeginInit();
            this.SuspendLayout();

            // btnEmployeur
            this.btnEmployeur.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnEmployeur.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeur.FlatAppearance.BorderSize = 0;
            this.btnEmployeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeur.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmployeur.ForeColor = System.Drawing.Color.White;
            this.btnEmployeur.Location = new System.Drawing.Point(0, 0);
            this.btnEmployeur.Name = "btnEmployeur";
            this.btnEmployeur.Size = new System.Drawing.Size(1148, 46);
            this.btnEmployeur.TabIndex = 0;
            this.btnEmployeur.Text = "Gestion des Employeurs";
            this.btnEmployeur.UseVisualStyleBackColor = false;
            this.btnEmployeur.Click += new System.EventHandler(this.BtnEmployeur_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Text = "Raison Sociale";

            // txtRaisonSociale
            this.txtRaisonSociale.Location = new System.Drawing.Point(200, 18);
            this.txtRaisonSociale.Name = "txtRaisonSociale";
            this.txtRaisonSociale.Size = new System.Drawing.Size(200, 26);
            this.txtRaisonSociale.TabIndex = 1;

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(440, 20);
            this.label2.Name = "label2";
            this.label2.Text = "NINEA";

            // txtNINEA
            this.txtNINEA.Location = new System.Drawing.Point(600, 18);
            this.txtNINEA.Name = "txtNINEA";
            this.txtNINEA.Size = new System.Drawing.Size(200, 26);
            this.txtNINEA.TabIndex = 2;

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Text = "Secteur";

            // txtSecteur
            this.txtSecteur.Location = new System.Drawing.Point(200, 68);
            this.txtSecteur.Name = "txtSecteur";
            this.txtSecteur.Size = new System.Drawing.Size(200, 26);
            this.txtSecteur.TabIndex = 3;

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(440, 70);
            this.label4.Name = "label4";
            this.label4.Text = "Adresse";

            // txtAdresse
            this.txtAdresse.Location = new System.Drawing.Point(600, 68);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(200, 26);
            this.txtAdresse.TabIndex = 4;

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Text = "Telephone";

            // txtTelephone
            this.txtTelephone.Location = new System.Drawing.Point(200, 118);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(200, 26);
            this.txtTelephone.TabIndex = 5;

            // label6
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(440, 120);
            this.label6.Name = "label6";
            this.label6.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(600, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 6;

            // label7
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(20, 170);
            this.label7.Name = "label7";
            this.label7.Text = "Date Creation";

            // dtpDateCreation
            this.dtpDateCreation.Location = new System.Drawing.Point(200, 168);
            this.dtpDateCreation.Name = "dtpDateCreation";
            this.dtpDateCreation.Size = new System.Drawing.Size(200, 26);
            this.dtpDateCreation.TabIndex = 7;

            // label8
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(440, 170);
            this.label8.Name = "label8";
            this.label8.Text = "Statut";

            // cboStatut
            this.cboStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatut.Location = new System.Drawing.Point(600, 168);
            this.cboStatut.Name = "cboStatut";
            this.cboStatut.Size = new System.Drawing.Size(200, 28);
            this.cboStatut.TabIndex = 8;

            // btnEnregistrer
            this.btnEnregistrer.BackColor = System.Drawing.Color.Blue;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(20, 240);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(130, 35);
            this.btnEnregistrer.TabIndex = 9;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);

            // btnAnnuler
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnAnnuler.Location = new System.Drawing.Point(170, 240);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 35);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);

            // btnModifier
            this.btnModifier.BackColor = System.Drawing.Color.Yellow;
            this.btnModifier.Location = new System.Drawing.Point(320, 240);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 35);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);

            // btnSupprimer
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(470, 240);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 35);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.Linen;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.txtRaisonSociale);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.txtNINEA);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtSecteur);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.txtAdresse);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.txtTelephone);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.dtpDateCreation);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.cboStatut);
            this.panelMain.Controls.Add(this.btnEnregistrer);
            this.panelMain.Controls.Add(this.btnAnnuler);
            this.panelMain.Controls.Add(this.btnModifier);
            this.panelMain.Controls.Add(this.btnSupprimer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 46);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1148, 310);
            this.panelMain.TabIndex = 1;

            // lblRecherche
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(10, 14);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Text = "Recherche :";

            // txtRecherche
            this.txtRecherche.Location = new System.Drawing.Point(100, 10);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(180, 26);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.TxtRecherche_TextChanged);

            // lblFiltreStatut
            this.lblFiltreStatut.AutoSize = true;
            this.lblFiltreStatut.Location = new System.Drawing.Point(300, 14);
            this.lblFiltreStatut.Name = "lblFiltreStatut";
            this.lblFiltreStatut.Text = "Statut :";

            // cboFiltreStatut
            this.cboFiltreStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltreStatut.Location = new System.Drawing.Point(355, 10);
            this.cboFiltreStatut.Name = "cboFiltreStatut";
            this.cboFiltreStatut.Size = new System.Drawing.Size(160, 28);
            this.cboFiltreStatut.TabIndex = 2;
            this.cboFiltreStatut.SelectedIndexChanged += new System.EventHandler(this.CboFiltreStatut_SelectedIndexChanged);

            // btnReinitFiltres
            this.btnReinitFiltres.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnReinitFiltres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinitFiltres.ForeColor = System.Drawing.Color.White;
            this.btnReinitFiltres.Location = new System.Drawing.Point(530, 9);
            this.btnReinitFiltres.Name = "btnReinitFiltres";
            this.btnReinitFiltres.Size = new System.Drawing.Size(130, 30);
            this.btnReinitFiltres.TabIndex = 3;
            this.btnReinitFiltres.Text = "Reinitialiser";
            this.btnReinitFiltres.UseVisualStyleBackColor = false;
            this.btnReinitFiltres.Click += new System.EventHandler(this.BtnReinitFiltres_Click);

            // panelFiltres
            this.panelFiltres.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.panelFiltres.Controls.Add(this.lblRecherche);
            this.panelFiltres.Controls.Add(this.txtRecherche);
            this.panelFiltres.Controls.Add(this.lblFiltreStatut);
            this.panelFiltres.Controls.Add(this.cboFiltreStatut);
            this.panelFiltres.Controls.Add(this.btnReinitFiltres);
            this.panelFiltres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltres.Location = new System.Drawing.Point(0, 0);
            this.panelFiltres.Name = "panelFiltres";
            this.panelFiltres.Size = new System.Drawing.Size(1148, 48);
            this.panelFiltres.TabIndex = 0;

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);

            // lblPageSize
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(10, 14);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Text = "Lignes/page :";

            // npuPageSize
            this.npuPageSize.Location = new System.Drawing.Point(115, 10);
            this.npuPageSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.npuPageSize.Name = "npuPageSize";
            this.npuPageSize.Size = new System.Drawing.Size(60, 26);
            this.npuPageSize.TabIndex = 1;
            this.npuPageSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            this.npuPageSize.ValueChanged += new System.EventHandler(this.NpuPageSize_ValueChanged);

            // btnPrecedent
            this.btnPrecedent.Location = new System.Drawing.Point(200, 9);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(90, 30);
            this.btnPrecedent.TabIndex = 2;
            this.btnPrecedent.Text = "< Prec.";
            this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);

            // lblPage
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPage.Location = new System.Drawing.Point(305, 14);
            this.lblPage.Name = "lblPage";
            this.lblPage.Text = "Page 1 / 1";

            // btnSuivant
            this.btnSuivant.Location = new System.Drawing.Point(420, 9);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(90, 30);
            this.btnSuivant.TabIndex = 3;
            this.btnSuivant.Text = "Suiv. >";
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);

            // btnExportExcel
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(530, 9);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 30);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "Export CSV";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcel_Click);

            // panelPagination
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelPagination.Controls.Add(this.lblPageSize);
            this.panelPagination.Controls.Add(this.npuPageSize);
            this.panelPagination.Controls.Add(this.btnPrecedent);
            this.panelPagination.Controls.Add(this.lblPage);
            this.panelPagination.Controls.Add(this.btnSuivant);
            this.panelPagination.Controls.Add(this.btnExportExcel);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 0);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1148, 50);
            this.panelPagination.TabIndex = 2;

            // panelBottom
            this.panelBottom.Controls.Add(this.dataGridView1);
            this.panelBottom.Controls.Add(this.panelFiltres);
            this.panelBottom.Controls.Add(this.panelPagination);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.TabIndex = 0;

            // ControlEmployeur
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnEmployeur);
            this.Name = "ControlEmployeur";
            this.Size = new System.Drawing.Size(1148, 882);
            this.Load += new System.EventHandler(this.ControlEmployeur_Load);

            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelFiltres.ResumeLayout(false);
            this.panelFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npuPageSize)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEmployeur;
        private System.Windows.Forms.Panel panelMain, panelBottom, panelFiltres, panelPagination;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8;
        private System.Windows.Forms.TextBox txtRaisonSociale, txtNINEA, txtSecteur, txtAdresse, txtTelephone, txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDateCreation;
        private System.Windows.Forms.ComboBox cboStatut;
        private System.Windows.Forms.Button btnEnregistrer, btnAnnuler, btnModifier, btnSupprimer;
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