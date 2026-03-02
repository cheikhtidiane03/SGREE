namespace EXAMEN_SGREE
{
    partial class FormRenouvellement
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
            this.panelInfos = new System.Windows.Forms.Panel();
            this.lblTitreInfos = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblInfoNumero = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblInfoEmploye = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblInfoDateFin = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.lblInfoSalaire = new System.Windows.Forms.Label();
            this.panelSaisie = new System.Windows.Forms.Panel();
            this.lblTitreSaisie = new System.Windows.Forms.Label();
            this.lblNouvelleDateFin = new System.Windows.Forms.Label();
            this.dtpNouvelleDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblNouveauSalaire = new System.Windows.Forms.Label();
            this.nudNouveauSalaire = new System.Windows.Forms.NumericUpDown();
            this.lblSmigNote = new System.Windows.Forms.Label();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.panelInfos.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNouveauSalaire)).BeginInit();
            this.panelBoutons.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(480, 50);

            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Text = "Renouvellement de Contrat";

            // panelInfos – résumé contrat actuel
            this.lblTitreInfos.AutoSize = true;
            this.lblTitreInfos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitreInfos.ForeColor = System.Drawing.Color.FromArgb(0, 100, 70);
            this.lblTitreInfos.Location = new System.Drawing.Point(10, 8);
            this.lblTitreInfos.Text = "Contrat actuel";

            int lx = 10, vx = 200, ry = 30, rh = 30;

            this.lblN1.AutoSize = true; this.lblN1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblN1.Location = new System.Drawing.Point(lx, ry); this.lblN1.Text = "Numero :";
            this.lblInfoNumero.AutoSize = true; this.lblInfoNumero.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblInfoNumero.Location = new System.Drawing.Point(vx, ry); this.lblInfoNumero.Name = "lblInfoNumero"; this.lblInfoNumero.Text = "-";

            this.lblN2.AutoSize = true; this.lblN2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblN2.Location = new System.Drawing.Point(lx, ry + rh); this.lblN2.Text = "Type :";
            this.lblInfoType.AutoSize = true; this.lblInfoType.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblInfoType.Location = new System.Drawing.Point(vx, ry + rh); this.lblInfoType.Name = "lblInfoType"; this.lblInfoType.Text = "-";

            this.lblN3.AutoSize = true; this.lblN3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblN3.Location = new System.Drawing.Point(lx, ry + rh * 2); this.lblN3.Text = "Employe :";
            this.lblInfoEmploye.AutoSize = true; this.lblInfoEmploye.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblInfoEmploye.Location = new System.Drawing.Point(vx, ry + rh * 2); this.lblInfoEmploye.Name = "lblInfoEmploye"; this.lblInfoEmploye.Text = "-";

            this.lblN4.AutoSize = true; this.lblN4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblN4.Location = new System.Drawing.Point(lx, ry + rh * 3); this.lblN4.Text = "Date fin actuelle :";
            this.lblInfoDateFin.AutoSize = true; this.lblInfoDateFin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblInfoDateFin.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblInfoDateFin.Location = new System.Drawing.Point(vx, ry + rh * 3); this.lblInfoDateFin.Name = "lblInfoDateFin"; this.lblInfoDateFin.Text = "-";

            this.lblN5.AutoSize = true; this.lblN5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblN5.Location = new System.Drawing.Point(lx, ry + rh * 4); this.lblN5.Text = "Salaire actuel :";
            this.lblInfoSalaire.AutoSize = true; this.lblInfoSalaire.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblInfoSalaire.Location = new System.Drawing.Point(vx, ry + rh * 4); this.lblInfoSalaire.Name = "lblInfoSalaire"; this.lblInfoSalaire.Text = "-";

            this.panelInfos.BackColor = System.Drawing.Color.FromArgb(240, 255, 245);
            this.panelInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfos.Controls.Add(this.lblTitreInfos);
            this.panelInfos.Controls.Add(this.lblN1); this.panelInfos.Controls.Add(this.lblInfoNumero);
            this.panelInfos.Controls.Add(this.lblN2); this.panelInfos.Controls.Add(this.lblInfoType);
            this.panelInfos.Controls.Add(this.lblN3); this.panelInfos.Controls.Add(this.lblInfoEmploye);
            this.panelInfos.Controls.Add(this.lblN4); this.panelInfos.Controls.Add(this.lblInfoDateFin);
            this.panelInfos.Controls.Add(this.lblN5); this.panelInfos.Controls.Add(this.lblInfoSalaire);
            this.panelInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfos.Location = new System.Drawing.Point(0, 50);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(480, 195);

            // panelSaisie – nouvelles valeurs
            this.lblTitreSaisie.AutoSize = true;
            this.lblTitreSaisie.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitreSaisie.ForeColor = System.Drawing.Color.FromArgb(0, 100, 70);
            this.lblTitreSaisie.Location = new System.Drawing.Point(10, 8);
            this.lblTitreSaisie.Text = "Nouvelles valeurs";

            this.lblNouvelleDateFin.AutoSize = true;
            this.lblNouvelleDateFin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNouvelleDateFin.Location = new System.Drawing.Point(10, 40);
            this.lblNouvelleDateFin.Text = "Nouvelle date de fin :";

            this.dtpNouvelleDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNouvelleDateFin.Location = new System.Drawing.Point(200, 38);
            this.dtpNouvelleDateFin.Name = "dtpNouvelleDateFin";
            this.dtpNouvelleDateFin.Size = new System.Drawing.Size(200, 26);
            this.dtpNouvelleDateFin.TabIndex = 0;

            this.lblNouveauSalaire.AutoSize = true;
            this.lblNouveauSalaire.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblNouveauSalaire.Location = new System.Drawing.Point(10, 80);
            this.lblNouveauSalaire.Text = "Nouveau salaire (FCFA) :";

            this.nudNouveauSalaire.Location = new System.Drawing.Point(200, 78);
            this.nudNouveauSalaire.Name = "nudNouveauSalaire";
            this.nudNouveauSalaire.Size = new System.Drawing.Size(180, 26);
            this.nudNouveauSalaire.TabIndex = 1;
            this.nudNouveauSalaire.Minimum = new decimal(new int[] { 60000, 0, 0, 0 });
            this.nudNouveauSalaire.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            this.nudNouveauSalaire.Value = new decimal(new int[] { 60000, 0, 0, 0 });
            this.nudNouveauSalaire.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            this.nudNouveauSalaire.ThousandsSeparator = true;

            this.lblSmigNote.AutoSize = true;
            this.lblSmigNote.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.lblSmigNote.ForeColor = System.Drawing.Color.Gray;
            this.lblSmigNote.Location = new System.Drawing.Point(200, 108);
            this.lblSmigNote.Text = "Minimum SMIG : 60 000 FCFA";

            this.panelSaisie.BackColor = System.Drawing.Color.FromArgb(248, 250, 255);
            this.panelSaisie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaisie.Controls.Add(this.lblTitreSaisie);
            this.panelSaisie.Controls.Add(this.lblNouvelleDateFin);
            this.panelSaisie.Controls.Add(this.dtpNouvelleDateFin);
            this.panelSaisie.Controls.Add(this.lblNouveauSalaire);
            this.panelSaisie.Controls.Add(this.nudNouveauSalaire);
            this.panelSaisie.Controls.Add(this.lblSmigNote);
            this.panelSaisie.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSaisie.Location = new System.Drawing.Point(0, 245);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(480, 130);

            // panelBoutons
            this.btnConfirmer.BackColor = System.Drawing.Color.FromArgb(0, 150, 100);
            this.btnConfirmer.FlatAppearance.BorderSize = 0;
            this.btnConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmer.Location = new System.Drawing.Point(80, 10);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(140, 36);
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.Click += new System.EventHandler(this.BtnConfirmer_Click);

            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAnnuler.Location = new System.Drawing.Point(260, 10);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 36);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);

            this.panelBoutons.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelBoutons.Controls.Add(this.btnConfirmer);
            this.panelBoutons.Controls.Add(this.btnAnnuler);
            this.panelBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoutons.Name = "panelBoutons";
            this.panelBoutons.Size = new System.Drawing.Size(480, 56);
            this.panelBoutons.TabIndex = 3;

            // FormRenouvellement
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 431);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.panelInfos);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRenouvellement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renouvellement de Contrat";
            this.Load += new System.EventHandler(this.FormRenouvellement_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfos.ResumeLayout(false);
            this.panelInfos.PerformLayout();
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNouveauSalaire)).EndInit();
            this.panelBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Label lblTitreInfos;
        private System.Windows.Forms.Label lblN1, lblN2, lblN3, lblN4, lblN5;
        private System.Windows.Forms.Label lblInfoNumero;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.Label lblInfoEmploye;
        private System.Windows.Forms.Label lblInfoDateFin;
        private System.Windows.Forms.Label lblInfoSalaire;
        private System.Windows.Forms.Panel panelSaisie;
        private System.Windows.Forms.Label lblTitreSaisie;
        private System.Windows.Forms.Label lblNouvelleDateFin;
        private System.Windows.Forms.DateTimePicker dtpNouvelleDateFin;
        private System.Windows.Forms.Label lblNouveauSalaire;
        private System.Windows.Forms.NumericUpDown nudNouveauSalaire;
        private System.Windows.Forms.Label lblSmigNote;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}