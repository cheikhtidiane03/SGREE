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
            this.panelBtnChart = new System.Windows.Forms.Panel();
            this.btnShowType = new System.Windows.Forms.Button();
            this.btnShowDept = new System.Windows.Forms.Button();
            this.panelCrvType = new System.Windows.Forms.Panel();
            this.panelCrvDept = new System.Windows.Forms.Panel();

            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDepts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartements)).BeginInit();
            this.tabEmps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.tabStats.SuspendLayout();
            this.panelKpi.SuspendLayout();
            this.panelKpi1.SuspendLayout();
            this.panelKpi2.SuspendLayout();
            this.panelKpi3.SuspendLayout();
            this.panelBtnChart.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Controls.Add(this.btnFermer);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1250, 55);

            // lblTitre
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Text = "Fiche Employeur";

            // btnFermer
            this.btnFermer.BackColor = System.Drawing.Color.Red;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(1130, 10);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(100, 35);
            this.btnFermer.Text = "X Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);

            // tabInfos
            this.tabInfos.BackColor = System.Drawing.Color.Linen;
            this.tabInfos.Name = "tabInfos";
            this.tabInfos.Size = new System.Drawing.Size(1242, 657);
            this.tabInfos.Text = "  Informations  ";

            // dgvDepartements
            this.dgvDepartements.AllowUserToAddRows = false;
            this.dgvDepartements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartements.ColumnHeadersHeight = 32;
            this.dgvDepartements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartements.EnableHeadersVisualStyles = false;
            this.dgvDepartements.MultiSelect = false;
            this.dgvDepartements.Name = "dgvDepartements";
            this.dgvDepartements.ReadOnly = true;
            this.dgvDepartements.RowHeadersWidth = 40;
            this.dgvDepartements.RowTemplate.Height = 28;
            this.dgvDepartements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // tabDepts
            this.tabDepts.BackColor = System.Drawing.Color.White;
            this.tabDepts.Controls.Add(this.dgvDepartements);
            this.tabDepts.Name = "tabDepts";
            this.tabDepts.Text = "  Departements  ";

            // dgvEmployes
            this.dgvEmployes.AllowUserToAddRows = false;
            this.dgvEmployes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployes.ColumnHeadersHeight = 32;
            this.dgvEmployes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployes.EnableHeadersVisualStyles = false;
            this.dgvEmployes.MultiSelect = false;
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.ReadOnly = true;
            this.dgvEmployes.RowHeadersWidth = 40;
            this.dgvEmployes.RowTemplate.Height = 28;
            this.dgvEmployes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // tabEmps
            this.tabEmps.BackColor = System.Drawing.Color.White;
            this.tabEmps.Controls.Add(this.dgvEmployes);
            this.tabEmps.Name = "tabEmps";
            this.tabEmps.Text = "  Employes  ";

            // KPI 1
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblKpi1Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi1Title.Text = "Total Employes";

            this.lblStatTotalEmployes.AutoSize = true;
            this.lblStatTotalEmployes.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalEmployes.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblStatTotalEmployes.Location = new System.Drawing.Point(5, 30);
            this.lblStatTotalEmployes.Name = "lblStatTotalEmployes";
            this.lblStatTotalEmployes.Text = "-";

            this.panelKpi1.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi1.Controls.Add(this.lblKpi1Title);
            this.panelKpi1.Controls.Add(this.lblStatTotalEmployes);
            this.panelKpi1.Location = new System.Drawing.Point(40, 10);
            this.panelKpi1.Size = new System.Drawing.Size(215, 85);

            // sep1
            this.sep1.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.sep1.Location = new System.Drawing.Point(265, 10);
            this.sep1.Size = new System.Drawing.Size(1, 85);

            // KPI 2
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblKpi2Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi2Title.Text = "Total Contrats";

            this.lblStatTotalContrats.AutoSize = true;
            this.lblStatTotalContrats.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblStatTotalContrats.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblStatTotalContrats.Location = new System.Drawing.Point(5, 30);
            this.lblStatTotalContrats.Name = "lblStatTotalContrats";
            this.lblStatTotalContrats.Text = "-";

            this.panelKpi2.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi2.Controls.Add(this.lblKpi2Title);
            this.panelKpi2.Controls.Add(this.lblStatTotalContrats);
            this.panelKpi2.Location = new System.Drawing.Point(280, 10);
            this.panelKpi2.Size = new System.Drawing.Size(215, 85);

            // sep2
            this.sep2.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.sep2.Location = new System.Drawing.Point(505, 10);
            this.sep2.Size = new System.Drawing.Size(1, 85);

            // KPI 3
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.lblKpi3Title.Location = new System.Drawing.Point(5, 5);
            this.lblKpi3Title.Text = "Masse Salariale Active";

            this.lblStatMasseSalariale.AutoSize = true;
            this.lblStatMasseSalariale.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblStatMasseSalariale.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.lblStatMasseSalariale.Location = new System.Drawing.Point(5, 30);
            this.lblStatMasseSalariale.Name = "lblStatMasseSalariale";
            this.lblStatMasseSalariale.Text = "- FCFA";

            this.panelKpi3.BackColor = System.Drawing.Color.Transparent;
            this.panelKpi3.Controls.Add(this.lblKpi3Title);
            this.panelKpi3.Controls.Add(this.lblStatMasseSalariale);
            this.panelKpi3.Location = new System.Drawing.Point(520, 10);
            this.panelKpi3.Size = new System.Drawing.Size(300, 85);

            // panelKpi
            this.panelKpi.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.panelKpi.Controls.Add(this.panelKpi1);
            this.panelKpi.Controls.Add(this.sep1);
            this.panelKpi.Controls.Add(this.panelKpi2);
            this.panelKpi.Controls.Add(this.sep2);
            this.panelKpi.Controls.Add(this.panelKpi3);
            this.panelKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKpi.Name = "panelKpi";
            this.panelKpi.Size = new System.Drawing.Size(1242, 110);

            // btnShowType
            this.btnShowType.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnShowType.FlatAppearance.BorderSize = 0;
            this.btnShowType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowType.ForeColor = System.Drawing.Color.White;
            this.btnShowType.Location = new System.Drawing.Point(15, 8);
            this.btnShowType.Name = "btnShowType";
            this.btnShowType.Size = new System.Drawing.Size(220, 32);
            this.btnShowType.Text = "Par Type de Contrat";
            this.btnShowType.UseVisualStyleBackColor = false;
            this.btnShowType.Click += new System.EventHandler(this.BtnShowType_Click);

            // btnShowDept
            this.btnShowDept.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnShowDept.FlatAppearance.BorderSize = 0;
            this.btnShowDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDept.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowDept.ForeColor = System.Drawing.Color.White;
            this.btnShowDept.Location = new System.Drawing.Point(250, 8);
            this.btnShowDept.Name = "btnShowDept";
            this.btnShowDept.Size = new System.Drawing.Size(210, 32);
            this.btnShowDept.Text = "Par Departement";
            this.btnShowDept.UseVisualStyleBackColor = false;
            this.btnShowDept.Click += new System.EventHandler(this.BtnShowDept_Click);

            // panelBtnChart
            this.panelBtnChart.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelBtnChart.Controls.Add(this.btnShowType);
            this.panelBtnChart.Controls.Add(this.btnShowDept);
            this.panelBtnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnChart.Name = "panelBtnChart";
            this.panelBtnChart.Size = new System.Drawing.Size(1242, 48);

            // panelCrvType
            this.panelCrvType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrvType.Name = "panelCrvType";
            this.panelCrvType.Visible = true;

            // panelCrvDept
            this.panelCrvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrvDept.Name = "panelCrvDept";
            this.panelCrvDept.Visible = false;

            // tabStats
            this.tabStats.BackColor = System.Drawing.Color.White;
            this.tabStats.Controls.Add(this.panelCrvType);
            this.tabStats.Controls.Add(this.panelCrvDept);
            this.tabStats.Controls.Add(this.panelBtnChart);
            this.tabStats.Controls.Add(this.panelKpi);
            this.tabStats.Name = "tabStats";
            this.tabStats.Text = "  Statistiques  ";

            // tabControl
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

            // FicheEmployeur
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
            this.panelKpi.ResumeLayout(false);
            this.panelKpi1.ResumeLayout(false);
            this.panelKpi1.PerformLayout();
            this.panelKpi2.ResumeLayout(false);
            this.panelKpi2.PerformLayout();
            this.panelKpi3.ResumeLayout(false);
            this.panelKpi3.PerformLayout();
            this.panelBtnChart.ResumeLayout(false);
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