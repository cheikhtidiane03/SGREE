namespace EXAMEN_SGREE
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelUtilisateur = new System.Windows.Forms.Panel();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnContrat = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnEmployeur = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.controlContrat1 = new EXAMEN_SGREE.ControlContrat();
            this.controlEmploye1 = new EXAMEN_SGREE.ControlEmploye();
            this.controlEmployeur1 = new EXAMEN_SGREE.ControlEmployeur();
            this.controlDashboard1 = new EXAMEN_SGREE.ControlDashboard();
            this.MenuVertical.SuspendLayout();
            this.panelUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.panelUtilisateur);
            this.MenuVertical.Controls.Add(this.btnContrat);
            this.MenuVertical.Controls.Add(this.btnEmploye);
            this.MenuVertical.Controls.Add(this.btnEmployeur);
            this.MenuVertical.Controls.Add(this.btnDashboard);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(244, 800);
            this.MenuVertical.TabIndex = 1;
            // 
            // panelUtilisateur
            // 
            this.panelUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.panelUtilisateur.Controls.Add(this.lblUtilisateur);
            this.panelUtilisateur.Controls.Add(this.btnDeconnexion);
            this.panelUtilisateur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUtilisateur.Location = new System.Drawing.Point(0, 710);
            this.panelUtilisateur.Name = "panelUtilisateur";
            this.panelUtilisateur.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panelUtilisateur.Size = new System.Drawing.Size(244, 90);
            this.panelUtilisateur.TabIndex = 0;
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoEllipsis = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUtilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.lblUtilisateur.Location = new System.Drawing.Point(8, 8);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(205, 30);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "👤  Utilisateur";
            this.lblUtilisateur.Click += new System.EventHandler(this.lblUtilisateur_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.FlatAppearance.BorderSize = 0;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btnDeconnexion.Location = new System.Drawing.Point(8, 42);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(205, 36);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // btnContrat
            // 
            this.btnContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnContrat.FlatAppearance.BorderSize = 0;
            this.btnContrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnContrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrat.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.Location = new System.Drawing.Point(0, 295);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(244, 55);
            this.btnContrat.TabIndex = 3;
            this.btnContrat.Text = "  Gestion Contrats";
            this.btnContrat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContrat.UseVisualStyleBackColor = false;
            this.btnContrat.Click += new System.EventHandler(this.BtnContrat_Click);
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEmploye.Location = new System.Drawing.Point(0, 240);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(244, 55);
            this.btnEmploye.TabIndex = 2;
            this.btnEmploye.Text = "  Gestion Employes";
            this.btnEmploye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploye.UseVisualStyleBackColor = false;
            this.btnEmploye.Click += new System.EventHandler(this.BtnEmploye_Click);
            // 
            // btnEmployeur
            // 
            this.btnEmployeur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployeur.FlatAppearance.BorderSize = 0;
            this.btnEmployeur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnEmployeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeur.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnEmployeur.ForeColor = System.Drawing.Color.White;
            this.btnEmployeur.Location = new System.Drawing.Point(0, 185);
            this.btnEmployeur.Name = "btnEmployeur";
            this.btnEmployeur.Size = new System.Drawing.Size(244, 55);
            this.btnEmployeur.TabIndex = 1;
            this.btnEmployeur.Text = "  Gestion Employeur";
            this.btnEmployeur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeur.UseVisualStyleBackColor = false;
            this.btnEmployeur.Click += new System.EventHandler(this.BtnEmployeur_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(130)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 130);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(244, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXAMEN_SGREE.Properties.Resources._959fea7c_d0f4_439b_afa7_2d84d0c0d14f;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Controls.Add(this.controlContrat1);
            this.panelcontenedor.Controls.Add(this.controlEmploye1);
            this.panelcontenedor.Controls.Add(this.controlEmployeur1);
            this.panelcontenedor.Controls.Add(this.controlDashboard1);
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(244, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1036, 800);
            this.panelcontenedor.TabIndex = 0;
            // 
            // controlContrat1
            // 
            this.controlContrat1.BackColor = System.Drawing.Color.Linen;
            this.controlContrat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContrat1.Location = new System.Drawing.Point(0, 0);
            this.controlContrat1.Name = "controlContrat1";
            this.controlContrat1.Size = new System.Drawing.Size(1036, 800);
            this.controlContrat1.TabIndex = 3;
            this.controlContrat1.Visible = false;
            this.controlContrat1.Load += new System.EventHandler(this.ControlContrat1_Load);
            // 
            // controlEmploye1
            // 
            this.controlEmploye1.BackColor = System.Drawing.Color.Linen;
            this.controlEmploye1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmploye1.Location = new System.Drawing.Point(0, 0);
            this.controlEmploye1.Name = "controlEmploye1";
            this.controlEmploye1.Size = new System.Drawing.Size(1036, 800);
            this.controlEmploye1.TabIndex = 2;
            this.controlEmploye1.Visible = false;
            // 
            // controlEmployeur1
            // 
            this.controlEmployeur1.BackColor = System.Drawing.Color.Linen;
            this.controlEmployeur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeur1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeur1.Name = "controlEmployeur1";
            this.controlEmployeur1.Size = new System.Drawing.Size(1036, 800);
            this.controlEmployeur1.TabIndex = 1;
            this.controlEmployeur1.Visible = false;
            // 
            // controlDashboard1
            // 
            this.controlDashboard1.BackColor = System.Drawing.Color.Linen;
            this.controlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.controlDashboard1.Name = "controlDashboard1";
            this.controlDashboard1.Size = new System.Drawing.Size(1036, 800);
            this.controlDashboard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.MenuVertical);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "SGREE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.panelUtilisateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEmployeur;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnContrat;
        private System.Windows.Forms.Panel panelUtilisateur;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Button btnDeconnexion;
        private ControlDashboard controlDashboard1;
        private ControlEmployeur controlEmployeur1;
        private ControlEmploye controlEmploye1;
        private ControlContrat controlContrat1;
    }
}