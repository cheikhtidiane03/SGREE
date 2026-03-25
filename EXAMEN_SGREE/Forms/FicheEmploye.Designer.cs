namespace EXAMEN_SGREE
{
    partial class FicheEmploye
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfos = new System.Windows.Forms.TabPage();
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.tabCompetences = new System.Windows.Forms.TabPage();

            // Labels infos (valeurs affectées dynamiquement dans InitInfosTab)
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

            // Onglet Contrats
            this.dgvContrats = new System.Windows.Forms.DataGridView();

            // Onglet Compétences
            this.dgvCompetences = new System.Windows.Forms.DataGridView();
            this.panelAjoutComp = new System.Windows.Forms.Panel();
            this.lblComp = new System.Windows.Forms.Label();
            this.cboCompetence = new System.Windows.Forms.ComboBox();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.cboNiveau = new System.Windows.Forms.ComboBox();
            this.lblDateObt = new System.Windows.Forms.Label();
            this.dtpDateObtention = new System.Windows.Forms.DateTimePicker();
            this.chkCertifie = new System.Windows.Forms.CheckBox();
            this.btnAjouterCompetence = new System.Windows.Forms.Button();
            this.btnSupprimerCompetence = new System.Windows.Forms.Button();

            // Bouton fermer
            this.btnFermer = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetences)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════
            //  FORM
            // ════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FicheEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Employe";
            this.Load += new System.EventHandler(this.FicheEmploye_Load);

            // ════════════════════════════════════════════════════════════
            //  TAB CONTROL
            // ════════════════════════════════════════════════════════════
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 30);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabPages.AddRange(new System.Windows.Forms.TabPage[] {
                this.tabInfos, this.tabContrats, this.tabCompetences });
            this.Controls.Add(this.tabControl1);

            // ── Onglet Infos ─────────────────────────────────────────────
            this.tabInfos.BackColor = System.Drawing.Color.White;
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Text = "Informations";
            this.tabInfos.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfos.Click += new System.EventHandler(this.TabInfos_Click);

            // ── Onglet Contrats ──────────────────────────────────────────
            this.tabContrats.BackColor = System.Drawing.Color.White;
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Text = "Contrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(3);

            this.dgvContrats.AllowUserToAddRows = false;
            this.dgvContrats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContrats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContrats.ReadOnly = true;
            this.dgvContrats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContrats.MultiSelect = false;
            this.dgvContrats.RowHeadersVisible = false;
            this.dgvContrats.BackgroundColor = System.Drawing.Color.White;
            this.dgvContrats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContrats.RowTemplate.Height = 28;
            this.dgvContrats.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.dgvContrats.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvContrats.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.dgvContrats.EnableHeadersVisualStyles = false;
            this.tabContrats.Controls.Add(this.dgvContrats);

            // ── Onglet Compétences ───────────────────────────────────────
            this.tabCompetences.BackColor = System.Drawing.Color.White;
            this.tabCompetences.Name = "tabCompetences";
            this.tabCompetences.Text = "Competences";
            this.tabCompetences.Padding = new System.Windows.Forms.Padding(3);

            // Panel ajout compétence (haut)
            this.panelAjoutComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAjoutComp.Height = 60;
            this.panelAjoutComp.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            this.panelAjoutComp.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);

            this.lblComp.Text = "Competence :";
            this.lblComp.Location = new System.Drawing.Point(8, 18);
            this.lblComp.AutoSize = true;
            this.panelAjoutComp.Controls.Add(this.lblComp);

            this.cboCompetence.Location = new System.Drawing.Point(100, 14);
            this.cboCompetence.Size = new System.Drawing.Size(200, 28);
            this.cboCompetence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelAjoutComp.Controls.Add(this.cboCompetence);

            this.lblNiveau.Text = "Niveau :";
            this.lblNiveau.Location = new System.Drawing.Point(315, 18);
            this.lblNiveau.AutoSize = true;
            this.panelAjoutComp.Controls.Add(this.lblNiveau);

            this.cboNiveau.Location = new System.Drawing.Point(380, 14);
            this.cboNiveau.Size = new System.Drawing.Size(150, 28);
            this.cboNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.panelAjoutComp.Controls.Add(this.cboNiveau);

            this.lblDateObt.Text = "Date obtention :";
            this.lblDateObt.Location = new System.Drawing.Point(545, 18);
            this.lblDateObt.AutoSize = true;
            this.panelAjoutComp.Controls.Add(this.lblDateObt);

            this.dtpDateObtention.Location = new System.Drawing.Point(660, 14);
            this.dtpDateObtention.Size = new System.Drawing.Size(140, 28);
            this.dtpDateObtention.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.panelAjoutComp.Controls.Add(this.dtpDateObtention);

            this.chkCertifie.Text = "Certifie";
            this.chkCertifie.Location = new System.Drawing.Point(820, 16);
            this.chkCertifie.AutoSize = true;
            this.panelAjoutComp.Controls.Add(this.chkCertifie);

            // Bouton Ajouter compétence — PascalCase
            this.btnAjouterCompetence.Text = "Ajouter";
            this.btnAjouterCompetence.Location = new System.Drawing.Point(890, 12);
            this.btnAjouterCompetence.Size = new System.Drawing.Size(90, 34);
            this.btnAjouterCompetence.BackColor = System.Drawing.Color.FromArgb(0, 130, 70);
            this.btnAjouterCompetence.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCompetence.FlatAppearance.BorderSize = 0;
            this.btnAjouterCompetence.Cursor = System.Windows.Forms.Cursors.Hand;
            // ── PascalCase corrigé ──
            this.btnAjouterCompetence.Click += new System.EventHandler(this.BtnAjouterCompetence_Click);
            this.panelAjoutComp.Controls.Add(this.btnAjouterCompetence);

            // Bouton Supprimer compétence — PascalCase
            this.btnSupprimerCompetence.Text = "Supprimer";
            this.btnSupprimerCompetence.Location = new System.Drawing.Point(990, 12);
            this.btnSupprimerCompetence.Size = new System.Drawing.Size(90, 34);
            this.btnSupprimerCompetence.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnSupprimerCompetence.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerCompetence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCompetence.FlatAppearance.BorderSize = 0;
            this.btnSupprimerCompetence.Cursor = System.Windows.Forms.Cursors.Hand;
            // ── PascalCase corrigé ──
            this.btnSupprimerCompetence.Click += new System.EventHandler(this.BtnSupprimerCompetence_Click);
            this.panelAjoutComp.Controls.Add(this.btnSupprimerCompetence);

            // DataGridView compétences
            this.dgvCompetences.AllowUserToAddRows = false;
            this.dgvCompetences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompetences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompetences.ReadOnly = true;
            this.dgvCompetences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetences.MultiSelect = false;
            this.dgvCompetences.RowHeadersVisible = false;
            this.dgvCompetences.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompetences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompetences.RowTemplate.Height = 28;
            this.dgvCompetences.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.dgvCompetences.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCompetences.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.dgvCompetences.EnableHeadersVisualStyles = false;

            this.tabCompetences.Controls.Add(this.dgvCompetences);
            this.tabCompetences.Controls.Add(this.panelAjoutComp);

            // ── Bouton Fermer (bas de la fenêtre) ───────────────────────
            this.btnFermer.Text = "Fermer";
            this.btnFermer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFermer.Height = 38;
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(80, 80, 90);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            // ── PascalCase corrigé ──
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            this.Controls.Add(this.btnFermer);

            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetences)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Déclarations ─────────────────────────────────────────────────
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfos;
        private System.Windows.Forms.TabPage tabContrats;
        private System.Windows.Forms.TabPage tabCompetences;

        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblMatriculeVal;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNomVal;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblDateNaissanceVal;
        private System.Windows.Forms.Label lblCNI;
        private System.Windows.Forms.Label lblCNIVal;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblAdresseVal;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblTelephoneVal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblSituationVal;
        private System.Windows.Forms.Label lblEnfants;
        private System.Windows.Forms.Label lblEnfantsVal;

        private System.Windows.Forms.DataGridView dgvContrats;

        private System.Windows.Forms.DataGridView dgvCompetences;
        private System.Windows.Forms.Panel panelAjoutComp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.ComboBox cboCompetence;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.ComboBox cboNiveau;
        private System.Windows.Forms.Label lblDateObt;
        private System.Windows.Forms.DateTimePicker dtpDateObtention;
        private System.Windows.Forms.CheckBox chkCertifie;
        private System.Windows.Forms.Button btnAjouterCompetence;
        private System.Windows.Forms.Button btnSupprimerCompetence;

        private System.Windows.Forms.Button btnFermer;
    }
}