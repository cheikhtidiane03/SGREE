namespace EXAMEN_SGREE
{
    partial class ControlDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelAlertesBandeau = new System.Windows.Forms.Panel();
            this.lblBandeauIcone = new System.Windows.Forms.Label();
            this.lblBandeauTexte = new System.Windows.Forms.Label();
            this.btnMasquerBandeau = new System.Windows.Forms.Button();
            this.panelFiltres = new System.Windows.Forms.Panel();
            this.lblDerniereMAJ = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.panelKpis = new System.Windows.Forms.Panel();
            this.panelKpi1 = new System.Windows.Forms.Panel();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.lblKpi1Val = new System.Windows.Forms.Label();
            this.lblKpi1Sub = new System.Windows.Forms.Label();
            this.panelKpi2 = new System.Windows.Forms.Panel();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.lblKpi2Val = new System.Windows.Forms.Label();
            this.lblKpi2Sub = new System.Windows.Forms.Label();
            this.panelKpi3 = new System.Windows.Forms.Panel();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.lblKpi3Val = new System.Windows.Forms.Label();
            this.lblKpi3Sub = new System.Windows.Forms.Label();
            this.panelKpi4 = new System.Windows.Forms.Panel();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.lblKpi4Val = new System.Windows.Forms.Label();
            this.lblKpi4Sub = new System.Windows.Forms.Label();
            this.panelKpi5 = new System.Windows.Forms.Panel();
            this.lblKpi5Title = new System.Windows.Forms.Label();
            this.lblKpi5Val = new System.Windows.Forms.Label();
            this.lblKpi5Sub = new System.Windows.Forms.Label();
            this.panelGraphiques = new System.Windows.Forms.Panel();
            this.panelPieSecteur = new System.Windows.Forms.Panel();
            this.panelBarEvolution = new System.Windows.Forms.Panel();
            this.panelPieType = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelAlertes = new System.Windows.Forms.Panel();
            this.lblTitreAlertes = new System.Windows.Forms.Label();
            this.lblNbAlertes = new System.Windows.Forms.Label();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.panelTopEmployeurs = new System.Windows.Forms.Panel();
            this.lblTitreTop = new System.Windows.Forms.Label();
            this.dgvTopEmployeurs = new System.Windows.Forms.DataGridView();
            this.panelAlertesBandeau.SuspendLayout();
            this.panelFiltres.SuspendLayout();
            this.panelKpis.SuspendLayout();
            this.panelKpi1.SuspendLayout();
            this.panelKpi2.SuspendLayout();
            this.panelKpi3.SuspendLayout();
            this.panelKpi4.SuspendLayout();
            this.panelKpi5.SuspendLayout();
            this.panelGraphiques.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelAlertes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.panelTopEmployeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(1200, 46);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Tableau de Bord";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelAlertesBandeau
            // ─── FIX : btnMasquerBandeau appartient ici, pas dans panelFiltres ───
            this.panelAlertesBandeau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelAlertesBandeau.Controls.Add(this.btnMasquerBandeau);
            this.panelAlertesBandeau.Controls.Add(this.lblBandeauIcone);
            this.panelAlertesBandeau.Controls.Add(this.lblBandeauTexte);
            this.panelAlertesBandeau.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAlertesBandeau.Location = new System.Drawing.Point(0, 46);
            this.panelAlertesBandeau.Name = "panelAlertesBandeau";
            this.panelAlertesBandeau.Size = new System.Drawing.Size(1200, 36);
            this.panelAlertesBandeau.TabIndex = 4;
            this.panelAlertesBandeau.Visible = false;
            // 
            // lblBandeauIcone
            // 
            this.lblBandeauIcone.AutoSize = true;
            this.lblBandeauIcone.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblBandeauIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBandeauIcone.Location = new System.Drawing.Point(8, 8);
            this.lblBandeauIcone.Name = "lblBandeauIcone";
            this.lblBandeauIcone.Size = new System.Drawing.Size(20, 30);
            this.lblBandeauIcone.TabIndex = 0;
            this.lblBandeauIcone.Text = "!";
            // 
            // lblBandeauTexte
            // 
            this.lblBandeauTexte.AutoSize = true;
            this.lblBandeauTexte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblBandeauTexte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBandeauTexte.Location = new System.Drawing.Point(36, 10);
            this.lblBandeauTexte.Name = "lblBandeauTexte";
            this.lblBandeauTexte.Size = new System.Drawing.Size(0, 22);
            this.lblBandeauTexte.TabIndex = 1;
            // 
            // btnMasquerBandeau
            // 
            this.btnMasquerBandeau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMasquerBandeau.FlatAppearance.BorderSize = 0;
            this.btnMasquerBandeau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasquerBandeau.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.btnMasquerBandeau.ForeColor = System.Drawing.Color.White;
            this.btnMasquerBandeau.Location = new System.Drawing.Point(1107, 6);
            this.btnMasquerBandeau.Name = "btnMasquerBandeau";
            this.btnMasquerBandeau.Size = new System.Drawing.Size(90, 24);
            this.btnMasquerBandeau.TabIndex = 2;
            this.btnMasquerBandeau.Text = "Masquer";
            this.btnMasquerBandeau.UseVisualStyleBackColor = false;
            this.btnMasquerBandeau.Click += new System.EventHandler(this.BtnMasquerBandeau_Click);
            // 
            // panelFiltres  (btnMasquerBandeau retiré d'ici)
            // 
            this.panelFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.panelFiltres.Controls.Add(this.lblDerniereMAJ);
            this.panelFiltres.Controls.Add(this.btnActualiser);
            this.panelFiltres.Controls.Add(this.btnRapport);
            this.panelFiltres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltres.Location = new System.Drawing.Point(0, 82);
            this.panelFiltres.Name = "panelFiltres";
            this.panelFiltres.Size = new System.Drawing.Size(1200, 46);
            this.panelFiltres.TabIndex = 3;
            // 
            // lblDerniereMAJ
            // 
            this.lblDerniereMAJ.AutoSize = true;
            this.lblDerniereMAJ.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.lblDerniereMAJ.ForeColor = System.Drawing.Color.Gray;
            this.lblDerniereMAJ.Location = new System.Drawing.Point(10, 14);
            this.lblDerniereMAJ.Name = "lblDerniereMAJ";
            this.lblDerniereMAJ.Size = new System.Drawing.Size(128, 19);
            this.lblDerniereMAJ.TabIndex = 0;
            this.lblDerniereMAJ.Text = "Chargement...";
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.Location = new System.Drawing.Point(856, 9);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(110, 28);
            this.btnActualiser.TabIndex = 1;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnRapport.FlatAppearance.BorderSize = 0;
            this.btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnRapport.ForeColor = System.Drawing.Color.White;
            this.btnRapport.Location = new System.Drawing.Point(976, 9);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(130, 28);
            this.btnRapport.TabIndex = 2;
            this.btnRapport.Text = "Rapport Crystal";
            this.btnRapport.UseVisualStyleBackColor = false;
            this.btnRapport.Click += new System.EventHandler(this.BtnRapport_Click);
            // 
            // panelKpis
            // 
            this.panelKpis.BackColor = System.Drawing.Color.White;
            this.panelKpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpis.Controls.Add(this.panelKpi1);
            this.panelKpis.Controls.Add(this.panelKpi2);
            this.panelKpis.Controls.Add(this.panelKpi3);
            this.panelKpis.Controls.Add(this.panelKpi4);
            this.panelKpis.Controls.Add(this.panelKpi5);
            this.panelKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKpis.Location = new System.Drawing.Point(0, 128);
            this.panelKpis.Name = "panelKpis";
            this.panelKpis.Size = new System.Drawing.Size(1200, 102);
            this.panelKpis.TabIndex = 2;
            // 
            // panelKpi1
            // 
            this.panelKpi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelKpi1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpi1.Controls.Add(this.lblKpi1Title);
            this.panelKpi1.Controls.Add(this.lblKpi1Val);
            this.panelKpi1.Controls.Add(this.lblKpi1Sub);
            this.panelKpi1.Location = new System.Drawing.Point(8, 9);
            this.panelKpi1.Name = "panelKpi1";
            this.panelKpi1.Size = new System.Drawing.Size(224, 80);
            this.panelKpi1.TabIndex = 0;
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblKpi1Title.Location = new System.Drawing.Point(8, 8);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(86, 19);
            this.lblKpi1Title.TabIndex = 0;
            this.lblKpi1Title.Text = "EMPLOYES";
            // 
            // lblKpi1Val
            // 
            this.lblKpi1Val.AutoSize = true;
            this.lblKpi1Val.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblKpi1Val.Location = new System.Drawing.Point(6, 22);
            this.lblKpi1Val.Name = "lblKpi1Val";
            this.lblKpi1Val.Size = new System.Drawing.Size(49, 62);
            this.lblKpi1Val.TabIndex = 1;
            this.lblKpi1Val.Text = "-";
            // 
            // lblKpi1Sub
            // 
            this.lblKpi1Sub.AutoSize = true;
            this.lblKpi1Sub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblKpi1Sub.ForeColor = System.Drawing.Color.Gray;
            this.lblKpi1Sub.Location = new System.Drawing.Point(8, 64);
            this.lblKpi1Sub.Name = "lblKpi1Sub";
            this.lblKpi1Sub.Size = new System.Drawing.Size(0, 19);
            this.lblKpi1Sub.TabIndex = 2;
            // 
            // panelKpi2
            // 
            this.panelKpi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.panelKpi2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpi2.Controls.Add(this.lblKpi2Title);
            this.panelKpi2.Controls.Add(this.lblKpi2Val);
            this.panelKpi2.Controls.Add(this.lblKpi2Sub);
            this.panelKpi2.Location = new System.Drawing.Point(242, 9);
            this.panelKpi2.Name = "panelKpi2";
            this.panelKpi2.Size = new System.Drawing.Size(224, 80);
            this.panelKpi2.TabIndex = 1;
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblKpi2Title.Location = new System.Drawing.Point(8, 8);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(105, 19);
            this.lblKpi2Title.TabIndex = 0;
            this.lblKpi2Title.Text = "EMPLOYEURS";
            // 
            // lblKpi2Val
            // 
            this.lblKpi2Val.AutoSize = true;
            this.lblKpi2Val.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.lblKpi2Val.Location = new System.Drawing.Point(6, 22);
            this.lblKpi2Val.Name = "lblKpi2Val";
            this.lblKpi2Val.Size = new System.Drawing.Size(49, 62);
            this.lblKpi2Val.TabIndex = 1;
            this.lblKpi2Val.Text = "-";
            // 
            // lblKpi2Sub
            // 
            this.lblKpi2Sub.AutoSize = true;
            this.lblKpi2Sub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblKpi2Sub.ForeColor = System.Drawing.Color.Gray;
            this.lblKpi2Sub.Location = new System.Drawing.Point(8, 64);
            this.lblKpi2Sub.Name = "lblKpi2Sub";
            this.lblKpi2Sub.Size = new System.Drawing.Size(0, 19);
            this.lblKpi2Sub.TabIndex = 2;
            // 
            // panelKpi3
            // 
            this.panelKpi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(230)))));
            this.panelKpi3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpi3.Controls.Add(this.lblKpi3Title);
            this.panelKpi3.Controls.Add(this.lblKpi3Val);
            this.panelKpi3.Controls.Add(this.lblKpi3Sub);
            this.panelKpi3.Location = new System.Drawing.Point(476, 9);
            this.panelKpi3.Name = "panelKpi3";
            this.panelKpi3.Size = new System.Drawing.Size(224, 80);
            this.panelKpi3.TabIndex = 2;
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblKpi3Title.Location = new System.Drawing.Point(8, 8);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(144, 19);
            this.lblKpi3Title.TabIndex = 0;
            this.lblKpi3Title.Text = "CONTRATS ACTIFS";
            // 
            // lblKpi3Val
            // 
            this.lblKpi3Val.AutoSize = true;
            this.lblKpi3Val.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.lblKpi3Val.Location = new System.Drawing.Point(6, 22);
            this.lblKpi3Val.Name = "lblKpi3Val";
            this.lblKpi3Val.Size = new System.Drawing.Size(49, 62);
            this.lblKpi3Val.TabIndex = 1;
            this.lblKpi3Val.Text = "-";
            // 
            // lblKpi3Sub
            // 
            this.lblKpi3Sub.AutoSize = true;
            this.lblKpi3Sub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblKpi3Sub.ForeColor = System.Drawing.Color.Gray;
            this.lblKpi3Sub.Location = new System.Drawing.Point(8, 64);
            this.lblKpi3Sub.Name = "lblKpi3Sub";
            this.lblKpi3Sub.Size = new System.Drawing.Size(0, 19);
            this.lblKpi3Sub.TabIndex = 2;
            // 
            // panelKpi4
            // 
            this.panelKpi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelKpi4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpi4.Controls.Add(this.lblKpi4Title);
            this.panelKpi4.Controls.Add(this.lblKpi4Val);
            this.panelKpi4.Controls.Add(this.lblKpi4Sub);
            this.panelKpi4.Location = new System.Drawing.Point(710, 9);
            this.panelKpi4.Name = "panelKpi4";
            this.panelKpi4.Size = new System.Drawing.Size(224, 80);
            this.panelKpi4.TabIndex = 3;
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.AutoSize = true;
            this.lblKpi4Title.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblKpi4Title.Location = new System.Drawing.Point(8, 8);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(142, 19);
            this.lblKpi4Title.TabIndex = 0;
            this.lblKpi4Title.Text = "MASSE SALARIALE";
            // 
            // lblKpi4Val
            // 
            this.lblKpi4Val.AutoSize = true;
            this.lblKpi4Val.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.lblKpi4Val.Location = new System.Drawing.Point(6, 24);
            this.lblKpi4Val.Name = "lblKpi4Val";
            this.lblKpi4Val.Size = new System.Drawing.Size(40, 51);
            this.lblKpi4Val.TabIndex = 1;
            this.lblKpi4Val.Text = "-";
            // 
            // lblKpi4Sub
            // 
            this.lblKpi4Sub.AutoSize = true;
            this.lblKpi4Sub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblKpi4Sub.ForeColor = System.Drawing.Color.Gray;
            this.lblKpi4Sub.Location = new System.Drawing.Point(8, 64);
            this.lblKpi4Sub.Name = "lblKpi4Sub";
            this.lblKpi4Sub.Size = new System.Drawing.Size(0, 19);
            this.lblKpi4Sub.TabIndex = 2;
            // 
            // panelKpi5
            // 
            this.panelKpi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelKpi5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKpi5.Controls.Add(this.lblKpi5Title);
            this.panelKpi5.Controls.Add(this.lblKpi5Val);
            this.panelKpi5.Controls.Add(this.lblKpi5Sub);
            this.panelKpi5.Location = new System.Drawing.Point(944, 9);
            this.panelKpi5.Name = "panelKpi5";
            this.panelKpi5.Size = new System.Drawing.Size(224, 80);
            this.panelKpi5.TabIndex = 4;
            // 
            // lblKpi5Title
            // 
            this.lblKpi5Title.AutoSize = true;
            this.lblKpi5Title.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.lblKpi5Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblKpi5Title.Location = new System.Drawing.Point(8, 8);
            this.lblKpi5Title.Name = "lblKpi5Title";
            this.lblKpi5Title.Size = new System.Drawing.Size(68, 19);
            this.lblKpi5Title.TabIndex = 0;
            this.lblKpi5Title.Text = "ALERTES";
            // 
            // lblKpi5Val
            // 
            this.lblKpi5Val.AutoSize = true;
            this.lblKpi5Val.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblKpi5Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblKpi5Val.Location = new System.Drawing.Point(6, 22);
            this.lblKpi5Val.Name = "lblKpi5Val";
            this.lblKpi5Val.Size = new System.Drawing.Size(49, 62);
            this.lblKpi5Val.TabIndex = 1;
            this.lblKpi5Val.Text = "-";
            // 
            // lblKpi5Sub
            // 
            this.lblKpi5Sub.AutoSize = true;
            this.lblKpi5Sub.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblKpi5Sub.ForeColor = System.Drawing.Color.Gray;
            this.lblKpi5Sub.Location = new System.Drawing.Point(8, 64);
            this.lblKpi5Sub.Name = "lblKpi5Sub";
            this.lblKpi5Sub.Size = new System.Drawing.Size(0, 19);
            this.lblKpi5Sub.TabIndex = 2;
            // 
            // panelGraphiques
            // 
            this.panelGraphiques.BackColor = System.Drawing.Color.White;
            this.panelGraphiques.Controls.Add(this.panelPieSecteur);
            this.panelGraphiques.Controls.Add(this.panelBarEvolution);
            this.panelGraphiques.Controls.Add(this.panelPieType);
            this.panelGraphiques.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraphiques.Location = new System.Drawing.Point(0, 230);
            this.panelGraphiques.Name = "panelGraphiques";
            this.panelGraphiques.Size = new System.Drawing.Size(1200, 256);
            this.panelGraphiques.TabIndex = 1;
            // 
            // panelPieSecteur
            // 
            this.panelPieSecteur.BackColor = System.Drawing.Color.White;
            this.panelPieSecteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPieSecteur.Location = new System.Drawing.Point(8, 8);
            this.panelPieSecteur.Name = "panelPieSecteur";
            this.panelPieSecteur.Size = new System.Drawing.Size(370, 240);
            this.panelPieSecteur.TabIndex = 0;
            this.panelPieSecteur.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPieSecteur_Paint);
            // 
            // panelBarEvolution
            // 
            this.panelBarEvolution.BackColor = System.Drawing.Color.White;
            this.panelBarEvolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarEvolution.Location = new System.Drawing.Point(388, 8);
            this.panelBarEvolution.Name = "panelBarEvolution";
            this.panelBarEvolution.Size = new System.Drawing.Size(402, 240);
            this.panelBarEvolution.TabIndex = 1;
            this.panelBarEvolution.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarEvolution_Paint);
            // 
            // panelPieType
            // 
            this.panelPieType.BackColor = System.Drawing.Color.White;
            this.panelPieType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPieType.Location = new System.Drawing.Point(800, 8);
            this.panelPieType.Name = "panelPieType";
            this.panelPieType.Size = new System.Drawing.Size(370, 240);
            this.panelPieType.TabIndex = 2;
            this.panelPieType.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPieType_Paint);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.panelAlertes);
            this.panelBottom.Controls.Add(this.panelTopEmployeurs);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 486);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1200, 414);
            this.panelBottom.TabIndex = 0;
            // 
            // panelAlertes
            // 
            this.panelAlertes.BackColor = System.Drawing.Color.White;
            this.panelAlertes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlertes.Controls.Add(this.lblTitreAlertes);
            this.panelAlertes.Controls.Add(this.lblNbAlertes);
            this.panelAlertes.Controls.Add(this.dgvAlertes);
            this.panelAlertes.Location = new System.Drawing.Point(8, 8);
            this.panelAlertes.Name = "panelAlertes";
            this.panelAlertes.Size = new System.Drawing.Size(696, 240);
            this.panelAlertes.TabIndex = 0;
            // 
            // lblTitreAlertes
            // 
            this.lblTitreAlertes.AutoSize = true;
            this.lblTitreAlertes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitreAlertes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.lblTitreAlertes.Location = new System.Drawing.Point(8, 8);
            this.lblTitreAlertes.Name = "lblTitreAlertes";
            this.lblTitreAlertes.Size = new System.Drawing.Size(374, 22);
            this.lblTitreAlertes.TabIndex = 0;
            this.lblTitreAlertes.Text = "Contrats expirant / Employes sans contrat";
            // 
            // lblNbAlertes
            // 
            this.lblNbAlertes.AutoSize = true;
            this.lblNbAlertes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNbAlertes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNbAlertes.Location = new System.Drawing.Point(360, 8);
            this.lblNbAlertes.Name = "lblNbAlertes";
            this.lblNbAlertes.Size = new System.Drawing.Size(0, 22);
            this.lblNbAlertes.TabIndex = 1;
            // 
            // dgvAlertes
            // 
            this.dgvAlertes.AllowUserToAddRows = false;
            this.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlertes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlertes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlertes.ColumnHeadersHeight = 28;
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlertes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlertes.EnableHeadersVisualStyles = false;
            this.dgvAlertes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvAlertes.Location = new System.Drawing.Point(5, 30);
            this.dgvAlertes.MultiSelect = false;
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.ReadOnly = true;
            this.dgvAlertes.RowHeadersVisible = false;
            this.dgvAlertes.RowHeadersWidth = 62;
            this.dgvAlertes.RowTemplate.Height = 26;
            this.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertes.Size = new System.Drawing.Size(684, 202);
            this.dgvAlertes.TabIndex = 2;
            // 
            // panelTopEmployeurs
            // 
            this.panelTopEmployeurs.BackColor = System.Drawing.Color.White;
            this.panelTopEmployeurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopEmployeurs.Controls.Add(this.lblTitreTop);
            this.panelTopEmployeurs.Controls.Add(this.dgvTopEmployeurs);
            this.panelTopEmployeurs.Location = new System.Drawing.Point(714, 8);
            this.panelTopEmployeurs.Name = "panelTopEmployeurs";
            this.panelTopEmployeurs.Size = new System.Drawing.Size(474, 240);
            this.panelTopEmployeurs.TabIndex = 1;
            // 
            // lblTitreTop
            // 
            this.lblTitreTop.AutoSize = true;
            this.lblTitreTop.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitreTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.lblTitreTop.Location = new System.Drawing.Point(8, 8);
            this.lblTitreTop.Name = "lblTitreTop";
            this.lblTitreTop.Size = new System.Drawing.Size(163, 22);
            this.lblTitreTop.TabIndex = 0;
            this.lblTitreTop.Text = "Top 5 Employeurs";
            // 
            // dgvTopEmployeurs
            // 
            this.dgvTopEmployeurs.AllowUserToAddRows = false;
            this.dgvTopEmployeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopEmployeurs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopEmployeurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTopEmployeurs.ColumnHeadersHeight = 28;
            this.dgvTopEmployeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopEmployeurs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTopEmployeurs.EnableHeadersVisualStyles = false;
            this.dgvTopEmployeurs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvTopEmployeurs.Location = new System.Drawing.Point(5, 30);
            this.dgvTopEmployeurs.MultiSelect = false;
            this.dgvTopEmployeurs.Name = "dgvTopEmployeurs";
            this.dgvTopEmployeurs.ReadOnly = true;
            this.dgvTopEmployeurs.RowHeadersVisible = false;
            this.dgvTopEmployeurs.RowHeadersWidth = 62;
            this.dgvTopEmployeurs.RowTemplate.Height = 28;
            this.dgvTopEmployeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopEmployeurs.Size = new System.Drawing.Size(462, 202);
            this.dgvTopEmployeurs.TabIndex = 1;
            // 
            // ControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelGraphiques);
            this.Controls.Add(this.panelKpis);
            this.Controls.Add(this.panelFiltres);
            this.Controls.Add(this.panelAlertesBandeau);
            this.Controls.Add(this.btnDashboard);
            this.Name = "ControlDashboard";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this.ControlDashboard_Load);
            this.panelAlertesBandeau.ResumeLayout(false);
            this.panelAlertesBandeau.PerformLayout();
            this.panelFiltres.ResumeLayout(false);
            this.panelFiltres.PerformLayout();
            this.panelKpis.ResumeLayout(false);
            this.panelKpi1.ResumeLayout(false);
            this.panelKpi1.PerformLayout();
            this.panelKpi2.ResumeLayout(false);
            this.panelKpi2.PerformLayout();
            this.panelKpi3.ResumeLayout(false);
            this.panelKpi3.PerformLayout();
            this.panelKpi4.ResumeLayout(false);
            this.panelKpi4.PerformLayout();
            this.panelKpi5.ResumeLayout(false);
            this.panelKpi5.PerformLayout();
            this.panelGraphiques.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelAlertes.ResumeLayout(false);
            this.panelAlertes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.panelTopEmployeurs.ResumeLayout(false);
            this.panelTopEmployeurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployeurs)).EndInit();
            this.ResumeLayout(false);
        }

        // ─── Déclarations ─────────────────────────────────────────────
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelAlertesBandeau;
        private System.Windows.Forms.Label lblBandeauIcone;
        private System.Windows.Forms.Label lblBandeauTexte;
        private System.Windows.Forms.Button btnMasquerBandeau;
        private System.Windows.Forms.Panel panelFiltres;
        private System.Windows.Forms.Label lblDerniereMAJ;
        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Panel panelKpis;
        private System.Windows.Forms.Panel panelKpi1, panelKpi2, panelKpi3, panelKpi4, panelKpi5;
        private System.Windows.Forms.Label lblKpi1Title, lblKpi1Val, lblKpi1Sub;
        private System.Windows.Forms.Label lblKpi2Title, lblKpi2Val, lblKpi2Sub;
        private System.Windows.Forms.Label lblKpi3Title, lblKpi3Val, lblKpi3Sub;
        private System.Windows.Forms.Label lblKpi4Title, lblKpi4Val, lblKpi4Sub;
        private System.Windows.Forms.Label lblKpi5Title, lblKpi5Val, lblKpi5Sub;
        private System.Windows.Forms.Panel panelGraphiques;
        private System.Windows.Forms.Panel panelPieSecteur;
        private System.Windows.Forms.Panel panelBarEvolution;
        private System.Windows.Forms.Panel panelPieType;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelAlertes;
        private System.Windows.Forms.Label lblTitreAlertes;
        private System.Windows.Forms.Label lblNbAlertes;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.Panel panelTopEmployeurs;
        private System.Windows.Forms.Label lblTitreTop;
        private System.Windows.Forms.DataGridView dgvTopEmployeurs;
    }
}