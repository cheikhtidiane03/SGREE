namespace EXAMEN_SGREE
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmployeur = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnContrat = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.controlDashboard1 = new EXAMEN_SGREE.ControlDashboard();
            this.controlEmployeur1 = new EXAMEN_SGREE.ControlEmployeur();
            this.controlEmploye1 = new EXAMEN_SGREE.ControlEmploye();
            this.controlContrat1 = new EXAMEN_SGREE.ControlContrat();

            this.MenuVertical.SuspendLayout();
            this.panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // ── MenuVertical ──────────────────────────────────────────────
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Width = 220;
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Controls.Add(this.btnDashboard);
            this.MenuVertical.Controls.Add(this.btnContrat);
            this.MenuVertical.Controls.Add(this.btnEmploye);
            this.MenuVertical.Controls.Add(this.btnEmployeur);
            this.MenuVertical.Controls.Add(this.pictureBox1);

            // ── pictureBox1 ───────────────────────────────────────────────
            this.pictureBox1.Image = global::EXAMEN_SGREE.Properties.Resources._959fea7c_d0f4_439b_afa7_2d84d0c0d14f;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(220, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;

            // ── btnEmployeur ──────────────────────────────────────────────
            this.btnEmployeur.FlatAppearance.BorderSize = 0;
            this.btnEmployeur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnEmployeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeur.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmployeur.ForeColor = System.Drawing.Color.White;
            this.btnEmployeur.Location = new System.Drawing.Point(0, 135);
            this.btnEmployeur.Size = new System.Drawing.Size(220, 50);
            this.btnEmployeur.Name = "btnEmployeur";
            this.btnEmployeur.Text = "Gestion Employeur";
            this.btnEmployeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmployeur.UseVisualStyleBackColor = false;
            this.btnEmployeur.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnEmployeur.Click += new System.EventHandler(this.btnEmployeur_Click);

            // ── btnEmploye ────────────────────────────────────────────────
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.Location = new System.Drawing.Point(0, 190);
            this.btnEmploye.Size = new System.Drawing.Size(220, 50);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Text = "Gestion Employés";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);

            // ── btnContrat ────────────────────────────────────────────────
            this.btnContrat.FlatAppearance.BorderSize = 0;
            this.btnContrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnContrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrat.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.Location = new System.Drawing.Point(0, 245);
            this.btnContrat.Size = new System.Drawing.Size(220, 50);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Text = "Gestion Contrats";
            this.btnContrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);

            // ── btnDashboard ───────────────────────────────────────────────
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 90, 160);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 300);
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(0, 90, 160); // actif par défaut
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // ── panelcontenedor ───────────────────────────────────────────
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Name = "panelcontenedor";
            // ordre d'ajout : le premier ajouté est en bas ; on veut Dashboard au sommet => l'ajouter en dernier
            this.panelcontenedor.Controls.Add(this.controlContrat1);
            this.panelcontenedor.Controls.Add(this.controlEmploye1);
            this.panelcontenedor.Controls.Add(this.controlEmployeur1);
            this.panelcontenedor.Controls.Add(this.controlDashboard1);

            // ── controlDashboard1 ─────────────────────────────────────────
            this.controlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlDashboard1.Name = "controlDashboard1";
            this.controlDashboard1.BackColor = System.Drawing.Color.Linen;
            this.controlDashboard1.Visible = true; // visible par défaut (dashboard actif)
            this.controlDashboard1.TabIndex = 0;

            // ── controlEmployeur1 ─────────────────────────────────────────
            this.controlEmployeur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeur1.Name = "controlEmployeur1";
            this.controlEmployeur1.BackColor = System.Drawing.Color.Linen;
            this.controlEmployeur1.Visible = false;
            this.controlEmployeur1.TabIndex = 1;

            // ── controlEmploye1 ───────────────────────────────────────────
            this.controlEmploye1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmploye1.Name = "controlEmploye1";
            this.controlEmploye1.BackColor = System.Drawing.Color.Linen;
            this.controlEmploye1.Visible = false;
            this.controlEmploye1.TabIndex = 2;

            // ── controlContrat1 ───────────────────────────────────────────
            this.controlContrat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContrat1.Name = "controlContrat1";
            this.controlContrat1.BackColor = System.Drawing.Color.Linen;
            this.controlContrat1.Visible = false;
            this.controlContrat1.TabIndex = 3;

            // ── Form1 ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "SGREE";
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.MenuVertical);
            this.Load += new System.EventHandler(this.Form1_Load);

            this.MenuVertical.ResumeLayout(false);
            this.panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnEmployeur;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnContrat;
        private System.Windows.Forms.Button btnDashboard;
        private ControlDashboard controlDashboard1;
        private ControlEmployeur controlEmployeur1;
        private ControlEmploye controlEmploye1;
        private ControlContrat controlContrat1;
    }
}