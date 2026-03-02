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
            // ── Déclarations ──────────────────────────────────────────
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitreDashboard = new System.Windows.Forms.Label();
            this.lblDerniereMAJ = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();

            // KPI panels (5 cartes)
            this.panelKpis = new System.Windows.Forms.Panel();
            this.panelKpi1 = new System.Windows.Forms.Panel();
            this.lblKpi1Icon = new System.Windows.Forms.Label();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.lblKpi1Val = new System.Windows.Forms.Label();
            this.lblKpi1Sub = new System.Windows.Forms.Label();

            this.panelKpi2 = new System.Windows.Forms.Panel();
            this.lblKpi2Icon = new System.Windows.Forms.Label();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.lblKpi2Val = new System.Windows.Forms.Label();
            this.lblKpi2Sub = new System.Windows.Forms.Label();

            this.panelKpi3 = new System.Windows.Forms.Panel();
            this.lblKpi3Icon = new System.Windows.Forms.Label();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.lblKpi3Val = new System.Windows.Forms.Label();
            this.lblKpi3Sub = new System.Windows.Forms.Label();

            this.panelKpi4 = new System.Windows.Forms.Panel();
            this.lblKpi4Icon = new System.Windows.Forms.Label();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.lblKpi4Val = new System.Windows.Forms.Label();
            this.lblKpi4Sub = new System.Windows.Forms.Label();

            this.panelKpi5 = new System.Windows.Forms.Panel();
            this.lblKpi5Icon = new System.Windows.Forms.Label();
            this.lblKpi5Title = new System.Windows.Forms.Label();
            this.lblKpi5Val = new System.Windows.Forms.Label();
            this.lblKpi5Sub = new System.Windows.Forms.Label();

            // Graphiques
            this.panelGraphiques = new System.Windows.Forms.Panel();
            this.panelPieSecteur = new System.Windows.Forms.Panel();
            this.panelBarEvolution = new System.Windows.Forms.Panel();
            this.panelPieType = new System.Windows.Forms.Panel();

            // Bas : Alertes + Top Employeurs
            this.panelBas = new System.Windows.Forms.Panel();
            this.panelAlertes = new System.Windows.Forms.Panel();
            this.lblTitreAlertes = new System.Windows.Forms.Label();
            this.lblNbAlertes = new System.Windows.Forms.Label();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitreTop = new System.Windows.Forms.Label();
            this.dgvTopEmployeurs = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployeurs)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════
            //  HEADER
            // ════════════════════════════════════════════════════════
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(15, 15, 25);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 56;
            this.panelHeader.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.lblTitreDashboard, this.lblDerniereMAJ, this.btnActualiser });

            this.lblTitreDashboard.Text = "Tableau de Bord SGREE";
            this.lblTitreDashboard.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitreDashboard.ForeColor = System.Drawing.Color.FromArgb(0, 180, 255);
            this.lblTitreDashboard.AutoSize = true;
            this.lblTitreDashboard.Location = new System.Drawing.Point(15, 14);

            this.lblDerniereMAJ.Text = "Chargement...";
            this.lblDerniereMAJ.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblDerniereMAJ.ForeColor = System.Drawing.Color.FromArgb(120, 120, 140);
            this.lblDerniereMAJ.AutoSize = true;
            this.lblDerniereMAJ.Location = new System.Drawing.Point(340, 20);
            this.lblDerniereMAJ.Name = "lblDerniereMAJ";

            this.btnActualiser.Text = "↻  Actualiser";
            this.btnActualiser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(0, 120, 200);
            this.btnActualiser.ForeColor = System.Drawing.Color.White;
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.FlatAppearance.BorderSize = 0;
            this.btnActualiser.Size = new System.Drawing.Size(130, 34);
            this.btnActualiser.Location = new System.Drawing.Point(1060, 11);
            this.btnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);

            // ════════════════════════════════════════════════════════
            //  BANDE KPIs (5 cartes)
            // ════════════════════════════════════════════════════════
            this.panelKpis.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKpis.Height = 115;
            this.panelKpis.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);

            int kpiW = 210, kpiH = 90, kpiGap = 12, kpiTop = 12;
            BuildKpiCard(this.panelKpi1, this.lblKpi1Icon, this.lblKpi1Title, this.lblKpi1Val, this.lblKpi1Sub,
                10, kpiTop, kpiW, kpiH, "👥", "Employés",
                System.Drawing.Color.FromArgb(0, 140, 230), System.Drawing.Color.FromArgb(30, 30, 45));

            BuildKpiCard(this.panelKpi2, this.lblKpi2Icon, this.lblKpi2Title, this.lblKpi2Val, this.lblKpi2Sub,
                10 + (kpiW + kpiGap), kpiTop, kpiW, kpiH, "🏢", "Employeurs",
                System.Drawing.Color.FromArgb(0, 190, 140), System.Drawing.Color.FromArgb(30, 30, 45));

            BuildKpiCard(this.panelKpi3, this.lblKpi3Icon, this.lblKpi3Title, this.lblKpi3Val, this.lblKpi3Sub,
                10 + (kpiW + kpiGap) * 2, kpiTop, kpiW, kpiH, "📋", "Contrats",
                System.Drawing.Color.FromArgb(180, 130, 0), System.Drawing.Color.FromArgb(30, 30, 45));

            BuildKpiCard(this.panelKpi4, this.lblKpi4Icon, this.lblKpi4Title, this.lblKpi4Val, this.lblKpi4Sub,
                10 + (kpiW + kpiGap) * 3, kpiTop, kpiW, kpiH, "💰", "Masse Salariale",
                System.Drawing.Color.FromArgb(0, 190, 100), System.Drawing.Color.FromArgb(30, 30, 45));

            BuildKpiCard(this.panelKpi5, this.lblKpi5Icon, this.lblKpi5Title, this.lblKpi5Val, this.lblKpi5Sub,
                10 + (kpiW + kpiGap) * 4, kpiTop, kpiW, kpiH, "⚠", "Alertes Expiration",
                System.Drawing.Color.FromArgb(220, 80, 80), System.Drawing.Color.FromArgb(45, 25, 25));

            this.panelKpis.Controls.AddRange(new System.Windows.Forms.Control[]
                { panelKpi1, panelKpi2, panelKpi3, panelKpi4, panelKpi5 });

            // ════════════════════════════════════════════════════════
            //  GRAPHIQUES (3 panels côte à côte)
            // ════════════════════════════════════════════════════════
            this.panelGraphiques.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelGraphiques.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraphiques.Height = 250;

            BuildGraphPanel(this.panelPieSecteur, 10, 8, 380, 232);
            BuildGraphPanel(this.panelBarEvolution, 400, 8, 400, 232);
            BuildGraphPanel(this.panelPieType, 810, 8, 360, 232);

            this.panelPieSecteur.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPieSecteur_Paint);
            this.panelBarEvolution.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarEvolution_Paint);
            this.panelPieType.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPieType_Paint);

            this.panelGraphiques.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.panelPieSecteur, this.panelBarEvolution, this.panelPieType });

            // ════════════════════════════════════════════════════════
            //  BAS : ALERTES + TOP EMPLOYEURS
            // ════════════════════════════════════════════════════════
            this.panelBas.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelBas.Dock = System.Windows.Forms.DockStyle.Fill;

            // Panel Alertes (gauche)
            this.panelAlertes.BackColor = System.Drawing.Color.FromArgb(25, 25, 38);
            this.panelAlertes.Location = new System.Drawing.Point(10, 8);
            this.panelAlertes.Size = new System.Drawing.Size(700, 240);

            this.lblTitreAlertes.Text = "🔔  Alertes";
            this.lblTitreAlertes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitreAlertes.ForeColor = System.Drawing.Color.FromArgb(220, 180, 60);
            this.lblTitreAlertes.AutoSize = true;
            this.lblTitreAlertes.Location = new System.Drawing.Point(10, 8);

            this.lblNbAlertes.Text = "";
            this.lblNbAlertes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNbAlertes.ForeColor = System.Drawing.Color.FromArgb(255, 100, 100);
            this.lblNbAlertes.AutoSize = true;
            this.lblNbAlertes.Location = new System.Drawing.Point(110, 10);
            this.lblNbAlertes.Name = "lblNbAlertes";

            this.dgvAlertes.Location = new System.Drawing.Point(5, 32);
            this.dgvAlertes.Size = new System.Drawing.Size(688, 200);
            this.dgvAlertes.AllowUserToAddRows = false;
            this.dgvAlertes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlertes.ColumnHeadersHeight = 28;
            this.dgvAlertes.EnableHeadersVisualStyles = false;
            this.dgvAlertes.MultiSelect = false;
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.ReadOnly = true;
            this.dgvAlertes.RowHeadersVisible = false;
            this.dgvAlertes.RowTemplate.Height = 26;
            this.dgvAlertes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertes.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 38);
            this.dgvAlertes.GridColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.dgvAlertes.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.dgvAlertes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 215);
            this.dgvAlertes.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.dgvAlertes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 100, 180);
            this.dgvAlertes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            this.panelAlertes.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.lblTitreAlertes, this.lblNbAlertes, this.dgvAlertes });

            // Panel Top Employeurs (droite)
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(25, 25, 38);
            this.panelTop.Location = new System.Drawing.Point(720, 8);
            this.panelTop.Size = new System.Drawing.Size(450, 240);

            this.lblTitreTop.Text = "🏆  Top 5 Employeurs";
            this.lblTitreTop.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitreTop.ForeColor = System.Drawing.Color.FromArgb(0, 200, 160);
            this.lblTitreTop.AutoSize = true;
            this.lblTitreTop.Location = new System.Drawing.Point(10, 8);

            this.dgvTopEmployeurs.Location = new System.Drawing.Point(5, 32);
            this.dgvTopEmployeurs.Size = new System.Drawing.Size(438, 200);
            this.dgvTopEmployeurs.AllowUserToAddRows = false;
            this.dgvTopEmployeurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopEmployeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTopEmployeurs.ColumnHeadersHeight = 28;
            this.dgvTopEmployeurs.EnableHeadersVisualStyles = false;
            this.dgvTopEmployeurs.MultiSelect = false;
            this.dgvTopEmployeurs.Name = "dgvTopEmployeurs";
            this.dgvTopEmployeurs.ReadOnly = true;
            this.dgvTopEmployeurs.RowHeadersVisible = false;
            this.dgvTopEmployeurs.RowTemplate.Height = 30;
            this.dgvTopEmployeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopEmployeurs.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 38);
            this.dgvTopEmployeurs.GridColor = System.Drawing.Color.FromArgb(45, 45, 60);
            this.dgvTopEmployeurs.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 45);
            this.dgvTopEmployeurs.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 215);
            this.dgvTopEmployeurs.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.dgvTopEmployeurs.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 140, 100);
            this.dgvTopEmployeurs.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            this.panelTop.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.lblTitreTop, this.dgvTopEmployeurs });

            this.panelBas.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.panelAlertes, this.panelTop });

            // ════════════════════════════════════════════════════════
            //  USERCONTROL
            // ════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.Controls.Add(this.panelBas);
            this.Controls.Add(this.panelGraphiques);
            this.Controls.Add(this.panelKpis);
            this.Controls.Add(this.panelHeader);
            this.Name = "ControlDashboard";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.ControlDashboard_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopEmployeurs)).EndInit();
            this.ResumeLayout(false);
        }

        // ─── Helper carte KPI ─────────────────────────────────────────
        private void BuildKpiCard(
            System.Windows.Forms.Panel panel,
            System.Windows.Forms.Label lblIcon,
            System.Windows.Forms.Label lblTitle,
            System.Windows.Forms.Label lblVal,
            System.Windows.Forms.Label lblSub,
            int x, int y, int w, int h,
            string icone, string titre,
            System.Drawing.Color couleurVal,
            System.Drawing.Color bgColor)
        {
            panel.BackColor = bgColor;
            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(w, h);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblIcon.Text = icone;
            lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            lblIcon.AutoSize = true;
            lblIcon.Location = new System.Drawing.Point(8, 8);
            lblIcon.BackColor = System.Drawing.Color.Transparent;

            lblTitle.Text = titre;
            lblTitle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(140, 150, 170);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(44, 12);
            lblTitle.BackColor = System.Drawing.Color.Transparent;

            lblVal.Text = "—";
            lblVal.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            lblVal.ForeColor = couleurVal;
            lblVal.AutoSize = true;
            lblVal.Location = new System.Drawing.Point(10, 34);
            lblVal.Name = lblVal.Name; // conservé
            lblVal.BackColor = System.Drawing.Color.Transparent;

            lblSub.Text = "";
            lblSub.Font = new System.Drawing.Font("Century Gothic", 8F);
            lblSub.ForeColor = System.Drawing.Color.FromArgb(130, 140, 160);
            lblSub.AutoSize = true;
            lblSub.Location = new System.Drawing.Point(10, 66);
            lblSub.BackColor = System.Drawing.Color.Transparent;

            panel.Controls.AddRange(new System.Windows.Forms.Control[]
                { lblIcon, lblTitle, lblVal, lblSub });
        }

        // ─── Helper panel graphique ───────────────────────────────────
        private void BuildGraphPanel(System.Windows.Forms.Panel panel, int x, int y, int w, int h)
        {
            panel.BackColor = System.Drawing.Color.FromArgb(25, 25, 38);
            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(w, h);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        // ─── Déclarations ─────────────────────────────────────────────
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitreDashboard;
        private System.Windows.Forms.Label lblDerniereMAJ;
        private System.Windows.Forms.Button btnActualiser;

        private System.Windows.Forms.Panel panelKpis;
        private System.Windows.Forms.Panel panelKpi1, panelKpi2, panelKpi3, panelKpi4, panelKpi5;
        private System.Windows.Forms.Label lblKpi1Icon, lblKpi1Title, lblKpi1Val, lblKpi1Sub;
        private System.Windows.Forms.Label lblKpi2Icon, lblKpi2Title, lblKpi2Val, lblKpi2Sub;
        private System.Windows.Forms.Label lblKpi3Icon, lblKpi3Title, lblKpi3Val, lblKpi3Sub;
        private System.Windows.Forms.Label lblKpi4Icon, lblKpi4Title, lblKpi4Val, lblKpi4Sub;
        private System.Windows.Forms.Label lblKpi5Icon, lblKpi5Title, lblKpi5Val, lblKpi5Sub;

        private System.Windows.Forms.Panel panelGraphiques;
        private System.Windows.Forms.Panel panelPieSecteur;
        private System.Windows.Forms.Panel panelBarEvolution;
        private System.Windows.Forms.Panel panelPieType;

        private System.Windows.Forms.Panel panelBas;
        private System.Windows.Forms.Panel panelAlertes;
        private System.Windows.Forms.Label lblTitreAlertes;
        private System.Windows.Forms.Label lblNbAlertes;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitreTop;
        private System.Windows.Forms.DataGridView dgvTopEmployeurs;
    }
}