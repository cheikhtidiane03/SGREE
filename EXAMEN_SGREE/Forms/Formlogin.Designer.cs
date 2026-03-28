namespace EXAMEN_SGREE
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFond = new System.Windows.Forms.Panel();
            this.panelCarte = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelControleFenetre = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnMaximiser = new System.Windows.Forms.Button();
            this.btnMinimiser = new System.Windows.Forms.Button();
            this.panelCorps = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.panelMdp = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnToggleMdp = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.panelSeparateur = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelFond.SuspendLayout();
            this.panelCarte.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelControleFenetre.SuspendLayout();
            this.panelCorps.SuspendLayout();
            this.panelMdp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFond
            // 
            this.panelFond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelFond.Controls.Add(this.panelCarte);
            this.panelFond.Controls.Add(this.lblVersion);
            this.panelFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFond.Location = new System.Drawing.Point(0, 0);
            this.panelFond.Margin = new System.Windows.Forms.Padding(4);
            this.panelFond.Name = "panelFond";
            this.panelFond.Size = new System.Drawing.Size(1301, 1000);
            this.panelFond.TabIndex = 0;
            // 
            // panelCarte
            // 
            this.panelCarte.BackColor = System.Drawing.Color.White;
            this.panelCarte.Controls.Add(this.panelHeader);
            this.panelCarte.Controls.Add(this.panelCorps);
            this.panelCarte.Location = new System.Drawing.Point(347, 59);
            this.panelCarte.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarte.Name = "panelCarte";
            this.panelCarte.Size = new System.Drawing.Size(607, 883);
            this.panelCarte.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelHeader.Controls.Add(this.panelControleFenetre);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(607, 10);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseUp);
            // 
            // panelControleFenetre
            // 
            this.panelControleFenetre.BackColor = System.Drawing.Color.Transparent;
            this.panelControleFenetre.Controls.Add(this.btnFermer);
            this.panelControleFenetre.Controls.Add(this.btnMaximiser);
            this.panelControleFenetre.Controls.Add(this.btnMinimiser);
            this.panelControleFenetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControleFenetre.Location = new System.Drawing.Point(0, 0);
            this.panelControleFenetre.Margin = new System.Windows.Forms.Padding(4);
            this.panelControleFenetre.Name = "panelControleFenetre";
            this.panelControleFenetre.Size = new System.Drawing.Size(607, 10);
            this.panelControleFenetre.TabIndex = 3;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.Color.Transparent;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(562, 4);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(41, 35);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "✕";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // btnMaximiser
            // 
            this.btnMaximiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximiser.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximiser.FlatAppearance.BorderSize = 0;
            this.btnMaximiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximiser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaximiser.ForeColor = System.Drawing.Color.White;
            this.btnMaximiser.Location = new System.Drawing.Point(521, 4);
            this.btnMaximiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximiser.Name = "btnMaximiser";
            this.btnMaximiser.Size = new System.Drawing.Size(41, 35);
            this.btnMaximiser.TabIndex = 1;
            this.btnMaximiser.Text = "□";
            this.btnMaximiser.UseVisualStyleBackColor = false;
            this.btnMaximiser.Click += new System.EventHandler(this.BtnMaximiser_Click);
            // 
            // btnMinimiser
            // 
            this.btnMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimiser.FlatAppearance.BorderSize = 0;
            this.btnMinimiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimiser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimiser.ForeColor = System.Drawing.Color.White;
            this.btnMinimiser.Location = new System.Drawing.Point(480, 4);
            this.btnMinimiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimiser.Name = "btnMinimiser";
            this.btnMinimiser.Size = new System.Drawing.Size(41, 35);
            this.btnMinimiser.TabIndex = 0;
            this.btnMinimiser.Text = "─";
            this.btnMinimiser.UseVisualStyleBackColor = false;
            this.btnMinimiser.Click += new System.EventHandler(this.BtnMinimiser_Click);
            // 
            // panelCorps
            // 
            this.panelCorps.BackColor = System.Drawing.Color.White;
            this.panelCorps.Controls.Add(this.lblEmail);
            this.panelCorps.Controls.Add(this.txtEmail);
            this.panelCorps.Controls.Add(this.lblMotDePasse);
            this.panelCorps.Controls.Add(this.panelMdp);
            this.panelCorps.Controls.Add(this.lblErreur);
            this.panelCorps.Controls.Add(this.btnConnexion);
            this.panelCorps.Controls.Add(this.panelSeparateur);
            this.panelCorps.Controls.Add(this.btnQuitter);
            this.panelCorps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCorps.Location = new System.Drawing.Point(0, 0);
            this.panelCorps.Margin = new System.Windows.Forms.Padding(4);
            this.panelCorps.Name = "panelCorps";
            this.panelCorps.Padding = new System.Windows.Forms.Padding(50, 27, 50, 33);
            this.panelCorps.Size = new System.Drawing.Size(607, 883);
            this.panelCorps.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblEmail.Location = new System.Drawing.Point(58, 152);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(139, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Adresse Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtEmail.Location = new System.Drawing.Point(62, 179);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(506, 41);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblMotDePasse.Location = new System.Drawing.Point(58, 230);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(134, 23);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // panelMdp
            // 
            this.panelMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMdp.Controls.Add(this.txtPassword);
            this.panelMdp.Controls.Add(this.btnToggleMdp);
            this.panelMdp.Location = new System.Drawing.Point(61, 276);
            this.panelMdp.Margin = new System.Windows.Forms.Padding(4);
            this.panelMdp.Name = "panelMdp";
            this.panelMdp.Size = new System.Drawing.Size(506, 55);
            this.panelMdp.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPassword.Location = new System.Drawing.Point(0, 15);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(449, 25);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // btnToggleMdp
            // 
            this.btnToggleMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnToggleMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleMdp.FlatAppearance.BorderSize = 0;
            this.btnToggleMdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleMdp.Font = new System.Drawing.Font("Segoe UI Emoji", 11F);
            this.btnToggleMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.btnToggleMdp.Location = new System.Drawing.Point(454, 4);
            this.btnToggleMdp.Margin = new System.Windows.Forms.Padding(4);
            this.btnToggleMdp.Name = "btnToggleMdp";
            this.btnToggleMdp.Size = new System.Drawing.Size(46, 47);
            this.btnToggleMdp.TabIndex = 1;
            this.btnToggleMdp.Text = "👁";
            this.btnToggleMdp.UseVisualStyleBackColor = false;
            this.btnToggleMdp.Click += new System.EventHandler(this.BtnToggleMdp_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.lblErreur.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblErreur.Location = new System.Drawing.Point(57, 360);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(507, 53);
            this.lblErreur.TabIndex = 4;
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErreur.Visible = false;
            this.lblErreur.Click += new System.EventHandler(this.lblErreur_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatAppearance.BorderSize = 0;
            this.btnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(57, 433);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(507, 73);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // panelSeparateur
            // 
            this.panelSeparateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.panelSeparateur.Location = new System.Drawing.Point(50, 373);
            this.panelSeparateur.Margin = new System.Windows.Forms.Padding(4);
            this.panelSeparateur.Name = "panelSeparateur";
            this.panelSeparateur.Size = new System.Drawing.Size(507, 1);
            this.panelSeparateur.TabIndex = 6;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btnQuitter.Location = new System.Drawing.Point(57, 525);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(507, 60);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.lblVersion.Location = new System.Drawing.Point(810, 949);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(287, 21);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "SGREE v1.0  —  RH Solutions Senegal";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1301, 1000);
            this.Controls.Add(this.panelFond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGREE - Connexion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelFond.ResumeLayout(false);
            this.panelFond.PerformLayout();
            this.panelCarte.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelControleFenetre.ResumeLayout(false);
            this.panelCorps.ResumeLayout(false);
            this.panelCorps.PerformLayout();
            this.panelMdp.ResumeLayout(false);
            this.panelMdp.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── Déclarations ──────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelFond;
        private System.Windows.Forms.Panel panelCarte;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelControleFenetre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnMaximiser;
        private System.Windows.Forms.Button btnMinimiser;
        private System.Windows.Forms.Panel panelCorps;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Panel panelMdp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnToggleMdp;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Panel panelSeparateur;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblVersion;
    }
}