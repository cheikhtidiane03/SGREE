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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnContrat = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnEmployeur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.controlContrat1 = new EXAMEN_SGREE.ControlContrat();
            this.controlEmploye1 = new EXAMEN_SGREE.ControlEmploye();
            this.controlEmployeur1 = new EXAMEN_SGREE.ControlEmployeur();
            this.controlDashboard1 = new EXAMEN_SGREE.ControlDashboard();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnDashboard);
            this.MenuVertical.Controls.Add(this.btnContrat);
            this.MenuVertical.Controls.Add(this.btnEmploye);
            this.MenuVertical.Controls.Add(this.btnEmployeur);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(222, 800);
            this.MenuVertical.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 300);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnContrat
            // 
            this.btnContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnContrat.FlatAppearance.BorderSize = 0;
            this.btnContrat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnContrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrat.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnContrat.ForeColor = System.Drawing.Color.White;
            this.btnContrat.Location = new System.Drawing.Point(0, 245);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(220, 50);
            this.btnContrat.TabIndex = 1;
            this.btnContrat.Text = "Gestion Contrats";
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
            this.btnEmploye.Location = new System.Drawing.Point(0, 190);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(220, 50);
            this.btnEmploye.TabIndex = 2;
            this.btnEmploye.Text = "Gestion Employés";
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
            this.btnEmployeur.Location = new System.Drawing.Point(0, 135);
            this.btnEmployeur.Name = "btnEmployeur";
            this.btnEmployeur.Size = new System.Drawing.Size(228, 50);
            this.btnEmployeur.TabIndex = 3;
            this.btnEmployeur.Text = "Gestion Employeur";
            this.btnEmployeur.UseVisualStyleBackColor = false;
            this.btnEmployeur.Click += new System.EventHandler(this.BtnEmployeur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EXAMEN_SGREE.Properties.Resources._959fea7c_d0f4_439b_afa7_2d84d0c0d14f;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 120);
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
            this.panelcontenedor.Location = new System.Drawing.Point(222, 0);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1058, 800);
            this.panelcontenedor.TabIndex = 0;
            // 
            // controlContrat1
            // 
            this.controlContrat1.BackColor = System.Drawing.Color.Linen;
            this.controlContrat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContrat1.Location = new System.Drawing.Point(0, 0);
            this.controlContrat1.Name = "controlContrat1";
            this.controlContrat1.Size = new System.Drawing.Size(1058, 800);
            this.controlContrat1.TabIndex = 3;
            this.controlContrat1.Visible = false;
            // 
            // controlEmploye1
            // 
            this.controlEmploye1.BackColor = System.Drawing.Color.Linen;
            this.controlEmploye1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmploye1.Location = new System.Drawing.Point(0, 0);
            this.controlEmploye1.Name = "controlEmploye1";
            this.controlEmploye1.Size = new System.Drawing.Size(1058, 800);
            this.controlEmploye1.TabIndex = 2;
            this.controlEmploye1.Visible = false;
            // 
            // controlEmployeur1
            // 
            this.controlEmployeur1.BackColor = System.Drawing.Color.Linen;
            this.controlEmployeur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeur1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeur1.Name = "controlEmployeur1";
            this.controlEmployeur1.Size = new System.Drawing.Size(1058, 800);
            this.controlEmployeur1.TabIndex = 1;
            this.controlEmployeur1.Visible = false;
            // 
            // controlDashboard1
            // 
            this.controlDashboard1.BackColor = System.Drawing.Color.Linen;
            this.controlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.controlDashboard1.Name = "controlDashboard1";
            this.controlDashboard1.Size = new System.Drawing.Size(1058, 800);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontenedor.ResumeLayout(false);
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