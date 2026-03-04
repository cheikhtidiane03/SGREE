namespace EXAMEN_SGREE
{
    partial class FicheEmployeur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInfos = new System.Windows.Forms.TabPage();
            this.tabDepts = new System.Windows.Forms.TabPage();
            this.dgvDepartements = new System.Windows.Forms.DataGridView();
            this.tabEmps = new System.Windows.Forms.TabPage();
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.panelCrvType = new System.Windows.Forms.Panel();
            this.panelCrvDept = new System.Windows.Forms.Panel();
            this.panelBtnChart = new System.Windows.Forms.Panel();
            this.btnShowType = new System.Windows.Forms.Button();
            this.btnShowDept = new System.Windows.Forms.Button();
            this.panelKpi = new System.Windows.Forms.Panel();
            this.panelKpi1 = new System.Windows.Forms.Panel();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.lblStatTotalEmployes = new System.Windows.Forms.Label();
            this.sep1 = new System.Windows.Forms.Panel();
            this.panelKpi2 = new System.Windows.Forms.Panel();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.lblStatTotalContrats = new System.Windows.Forms.Label();
            this.sep2 = new System.Windows.Forms.Panel();
            this.panelKpi3 = new System.Windows.Forms.Panel();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.lblStatMasseSalariale = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDepts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartements)).BeginInit();
            this.tabEmps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.tabStats.SuspendLayout();
            this.panelBtnChart.SuspendLayout();
            this.panelKpi.SuspendLayout();
            this.panelKpi1.SuspendLayout();
            this.panelKpi2.SuspendLayout();
            this.panelKpi3.SuspendLayout();
            this.SuspendLayout();
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
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(240, 34);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Fiche Employeur";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Red;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(1130, 10);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "X Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInfos);
            this.tabControl.Controls.Add(this.tabDepts);
            this.tabControl.Controls.Add(this.tabEmps);
            this.tabControl.Controls.Add(this.tabStats);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1250, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tabInfos
            // 
            this.tabInfos.BackColor = System.Drawing.Color.Linen;
            this.tabInfos.Location = new System.Drawing.Point(4, 32);
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Size = new System.Drawing.Size(1242, 654);
            this.tabInfos.TabIndex = 0;
            this.tabInfos.Text = "  Informations  ";
            // 
            // tabDepts
            // 
            this.tabDepts.BackColor = System.Drawing.Color.White;
            this.tabDepts.Controls.Add(this.dgvDepartements);
            this.tabDepts.Location = new System.Drawing.Point(4, 32);
            this.tabDepts.Name = "tabDepts";
            this.tabDepts.Size = new System.Drawing.Size(1242, 654);
            this.tabDepts.TabIndex = 1;
            this.tabDepts.Text = "  Departements  ";
            // 
            // dgvDepartements
            // 
            this.dgvDepartements.AllowUserToAddRows = false;
            this.dgvDepartements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartements.ColumnHeadersHeight = 32;
            this.dgvDepartements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartements.EnableHeadersVisualStyles = false;
            this.dgvDepartements.Location = new System.Drawing.Point(0, 0);
            this.dgvDepartements.MultiSelect = false;
            this.dgvDepartements.Name = "dgvDepartements";
            this.dgvDepartements.ReadOnly = true;
            this.dgvDepartements.RowHeadersWidth = 40;
            this.dgvDepartements.RowTemplate.Height = 28;
            this.dgvDepartements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartements.Size = new System.Drawing.Size(1242, 654);
            this.dgvDepartements.TabIndex = 0;
            // 
            // tabEmps
            // 
            this.tabEmps.BackColor = System.Drawing.Color.White;
            this.tabEmps.Controls.Add(this.dgvEmployes);
            this.tabEmps.Location = new System.Drawing.Point(4, 32);
            this.tabEmps.Name = "tabEmps";
            this.tabEmps.Size = new System.Drawing.Size(1242, 654);
            this.tabEmps.TabIndex = 2;
            this.tabEmps.Text = "  Employes  ";
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.AllowUserToAddRows = false;
            this.dgvEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployes.ColumnHeadersHeight = 32;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployes.EnableHeadersVisualStyles = false;
            this.dgvEmployes.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployes.MultiSelect = false;
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.ReadOnly = true;
            this.dgvEmployes.RowHeadersWidth = 40;
            this.dgvEmployes.RowTemplate.Height = 28;
            this.dgvEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployes.Size = new System.Drawing.Size(1242, 654);
            this.dgvEmployes.TabIndex = 0;
            // 
            // tabStats
            // 
            this.tabStats.BackColor = System.Drawing.Color.White;
            this.tabStats.Controls.Add(this.panelCrvType);
            this.tabStats.Controls.Add(this.panelCrvDept);
            this.tabStats.Controls.Add(this.panelBtnChart);
            this.tabStats.Controls.Add(this.panelKpi);
            this.tabStats.Location = new System.Drawing.Point(4, 32);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(1242, 654);
            this.tabStats.TabIndex = 3;
            this.tabStats.Text = "  Statistiques  ";
            // 
            // panelCrvType
            // 
            this.panelCrvType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrvType.Location = new System.Drawing.Point(0, 158);
            this.panelCrvType.Name = "panelCrvType";
            this.panelCrvType.Size = new System.Drawing.Size(1242, 496);
            this.panelCrvType.TabIndex = 0;
            // 
            // panelCrvDept
            // 
            this.panelCrvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrvDept.Location = new System.Drawing.Point(0, 158);
            this.panelCrvDept.Name = "panelCrvDept";
            this.panelCrvDept.Size = new System.Drawing.Size(1242, 496);
            this.panelCrvDept.TabIndex = 1;
            this.panelCrvDept.Visible = false;
            // 
            // panelBtnChart
            // 
            this.panelBtnChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelBtnChart.Controls.Add(this.btnShowType);
            this.panelBtnChart.Controls.Add(this.btnShowDept);
            this.panelBtnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnChart.Location = new System.Drawing.Point(0, 110);
            this.panelBtnChart.Name = "panelBtnChart";
            this.panelBtnChart.Size = new System.Drawing.Size(1242, 48);
            this.panelBtnChart.TabIndex = 2;
            // 
            // btnShowType
            // 
            this.btnShowType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnShowType.FlatAppearance.BorderSize = 0;
            this.btnShowType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowType.ForeColor = System.Drawing.Color.White;
            this.btnShowType.Location = new System.Drawing.Point(15, 8);
            this.btnShowType.Name = "btnShowType";
            this.btnShowType.Size = new System.Drawing.Size(220, 32);
            this.btnShowType.TabIndex = 0;
            this.btnShowType.Text = "Par Type de Contrat";
            this.btnShowType.UseVisualStyleBackColor = false;
            this.btnShowType.Click += new System.EventHandler(this.BtnShowType_Click);
            // 
            // btnShowDept
            // 
            this.btnShowDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnShowDept.FlatAppearance.BorderSize = 0;
            this.btnShowDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDept.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowDept.ForeColor = System.Drawing.Color.White;
            this.btnShowDept.Location = new System.Drawing.Point(250, 8);
            this.btnShowDept.Name = "btnShowDept";
            this.btnShowDept.Size = new System.Drawing.Size(210, 32);
            this.btnShowDept.TabIndex = 1;
            this.btnShowDept.Text = "Par Departement";
            this.btnShowDept.UseVisualStyleBackColor = false;
            this.btnShowDept.Click += new System.EventHandler(this.BtnShowDept_Click);
            // 
            // panelKpi
            // 
            this.panelKpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelKpi.Controls.Add(this.panelKpi1);
            this.panelKpi.Controls.Add(this.sep1);
            this.panelKpi.Controls.Add(this.panelKpi2);
            this.panelKpi.Controls.Add(this.sep2);
            this.panelKpi.Controls.Add(this.panelKpi3);
            this.panelKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKpi.Location = new System.Drawing.Point(0, 0);
            this.panelKpi.Name = "panelKpi";
            this.panelKpi.Size = new System.Drawing.Size(1242, 110);
            this.panelKpi.TabIndex = 3;
            // 
            // panelKpi1
            // 
            this.panelKpi1.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi1.Controls.Add(this.lblKpi1Title);
            this.panelKpi1.Controls.Add(this.lblStatTotalEmployes);
            this.panelKpi1.Location = new System.Drawing.Point(40, 10);
            this.panelKpi1.Name = "panelKpi1";
            this.panelKpi1.Size = new System.Drawing.Size(215, 85);
            this.panelKpi1.TabIndex = 0;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblKpi1Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(140, 22);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "Total Employes";
            // 
            // lblStatTotalEmployes
            // 
            this.lblStatTotalEmployes.AutoSize = true;
            this.lblStatTotalEmployes.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalEmployes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStatTotalEmployes.Location = new System.Drawing.Point(5, 30);
            this.lblStatTotalEmployes.Name = "lblStatTotalEmployes";
            this.lblStatTotalEmployes.Size = new System.Drawing.Size(40, 51);
            this.lblStatTotalEmployes.TabIndex = 1;
            this.lblStatTotalEmployes.Text = "-";
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sep1.Location = new System.Drawing.Point(265, 10);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(1, 85);
            this.sep1.TabIndex = 1;
            // 
            // panelKpi2
            // 
            this.panelKpi2.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi2.Controls.Add(this.lblKpi2Title);
            this.panelKpi2.Controls.Add(this.lblStatTotalContrats);
            this.panelKpi2.Location = new System.Drawing.Point(280, 10);
            this.panelKpi2.Name = "panelKpi2";
            this.panelKpi2.Size = new System.Drawing.Size(215, 85);
            this.panelKpi2.TabIndex = 2;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblKpi2Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(129, 22);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "Total Contrats";
            // 
            // lblStatTotalContrats
            // 
            this.lblStatTotalContrats.AutoSize = true;
            this.lblStatTotalContrats.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalContrats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStatTotalContrats.Location = new System.Drawing.Point(5, 30);
            this.lblStatTotalContrats.Name = "lblStatTotalContrats";
            this.lblStatTotalContrats.Size = new System.Drawing.Size(40, 51);
            this.lblStatTotalContrats.TabIndex = 1;
            this.lblStatTotalContrats.Text = "-";
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sep2.Location = new System.Drawing.Point(505, 10);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(1, 85);
            this.sep2.TabIndex = 3;
            // 
            // panelKpi3
            // 
            this.panelKpi3.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi3.Controls.Add(this.lblKpi3Title);
            this.panelKpi3.Controls.Add(this.lblStatMasseSalariale);
            this.panelKpi3.Location = new System.Drawing.Point(520, 10);
            this.panelKpi3.Name = "panelKpi3";
            this.panelKpi3.Size = new System.Drawing.Size(300, 85);
            this.panelKpi3.TabIndex = 4;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblKpi3Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(207, 22);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "Masse Salariale Active";
            // 
            // lblStatMasseSalariale
            // 
            this.lblStatMasseSalariale.AutoSize = true;
            this.lblStatMasseSalariale.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblStatMasseSalariale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblStatMasseSalariale.Location = new System.Drawing.Point(5, 30);
            this.lblStatMasseSalariale.Name = "lblStatMasseSalariale";
            this.lblStatMasseSalariale.Size = new System.Drawing.Size(133, 43);
            this.lblStatMasseSalariale.TabIndex = 1;
            this.lblStatMasseSalariale.Text = "- FCFA";
            // 
            // FicheEmployeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 745);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicheEmployeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche Employeur";
            this.Load += new System.EventHandler(this.FicheEmployeur_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDepts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartements)).EndInit();
            this.tabEmps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            this.tabStats.ResumeLayout(false);
            this.panelBtnChart.ResumeLayout(false);
            this.panelKpi.ResumeLayout(false);
            this.panelKpi1.ResumeLayout(false);
            this.panelKpi1.PerformLayout();
            this.panelKpi2.ResumeLayout(false);
            this.panelKpi2.PerformLayout();
            this.panelKpi3.ResumeLayout(false);
            this.panelKpi3.PerformLayout();
            this.ResumeLayout(false);

        }

        // Contrôles
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInfos;
        private System.Windows.Forms.TabPage tabDepts;
        private System.Windows.Forms.DataGridView dgvDepartements;
        private System.Windows.Forms.TabPage tabEmps;
        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Panel panelKpi;
        private System.Windows.Forms.Panel panelKpi1;
        private System.Windows.Forms.Label lblKpi1Title;
        private System.Windows.Forms.Label lblStatTotalEmployes;
        private System.Windows.Forms.Panel sep1;
        private System.Windows.Forms.Panel panelKpi2;
        private System.Windows.Forms.Label lblKpi2Title;
        private System.Windows.Forms.Label lblStatTotalContrats;
        private System.Windows.Forms.Panel sep2;
        private System.Windows.Forms.Panel panelKpi3;
        private System.Windows.Forms.Label lblKpi3Title;
        private System.Windows.Forms.Label lblStatMasseSalariale;
        private System.Windows.Forms.Panel panelBtnChart;
        private System.Windows.Forms.Button btnShowType;
        private System.Windows.Forms.Button btnShowDept;
        private System.Windows.Forms.Panel panelCrvType;
        private System.Windows.Forms.Panel panelCrvDept;

        // Labels valeurs onglet Infos (initialisés dans InitTabInfos)
        private System.Windows.Forms.Label lblIdVal;
        private System.Windows.Forms.Label lblRaisonVal;
        private System.Windows.Forms.Label lblNINEAVal;
        private System.Windows.Forms.Label lblSecteurVal;
        private System.Windows.Forms.Label lblAdresseVal;
        private System.Windows.Forms.Label lblTelephoneVal;
        private System.Windows.Forms.Label lblEmailVal;
        private System.Windows.Forms.Label lblDateCreationVal;
        private System.Windows.Forms.Label lblStatutVal;
    }
}