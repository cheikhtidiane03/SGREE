using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            // ── Afficher le nom de l'utilisateur connecté ─────────────────
            if (SessionUtilisateur.EstConnecte)
            {
                string nom = SessionUtilisateur.UtilisateurConnecte.NomComplet;
                string role = SessionUtilisateur.UtilisateurConnecte.Role;
                this.Text = "Cheikh Tidiane  —  " + nom + " (" + role + ")";
                lblUtilisateur.Text = " " + nom + "  |  " + role;
            }

            // ── Dashboard affiché par défaut ──────────────────────────────
            AfficherControl("dashboard");
        }

        // ================================================================
        //  Navigation
        // ================================================================
        private void AfficherControl(string nom)
        {
            if (nom == null) nom = string.Empty;
            string key = nom.ToLowerInvariant();

            if (controlEmployeur1 != null) controlEmployeur1.Visible = key == "employeur";
            if (controlEmploye1 != null) controlEmploye1.Visible = key == "employe";
            if (controlContrat1 != null) controlContrat1.Visible = key == "contrat";
            if (controlDashboard1 != null) controlDashboard1.Visible = key == "dashboard";

            if (key == "employeur" && controlEmployeur1 != null) controlEmployeur1.BringToFront();
            if (key == "employe" && controlEmploye1 != null) controlEmploye1.BringToFront();
            if (key == "contrat" && controlContrat1 != null) controlContrat1.BringToFront();
            if (key == "dashboard" && controlDashboard1 != null) controlDashboard1.BringToFront();

            Color active = Color.FromArgb(0, 60, 130);
            Color normal = Color.FromArgb(0, 122, 204);

            if (btnDashboard != null) btnDashboard.BackColor = key == "dashboard" ? active : normal;
            if (btnEmployeur != null) btnEmployeur.BackColor = key == "employeur" ? active : normal;
            if (btnEmploye != null) btnEmploye.BackColor = key == "employe" ? active : normal;
            if (btnContrat != null) btnContrat.BackColor = key == "contrat" ? active : normal;
        }

        // ================================================================
        //  Handlers boutons sidebar
        // ================================================================
        private void BtnDashboard_Click(object sender, EventArgs e)
            => AfficherControl("dashboard");

        private void BtnEmployeur_Click(object sender, EventArgs e)
            => AfficherControl("employeur");

        private void BtnEmploye_Click(object sender, EventArgs e)
            => AfficherControl("employe");

        private void BtnContrat_Click(object sender, EventArgs e)
            => AfficherControl("contrat");

        private void ControlContrat1_Load(object sender, EventArgs e) { }

        // ================================================================
        //  Déconnexion
        // ================================================================
        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            var rep = MessageBox.Show(
                "Voulez-vous vous deconnecter ?",
                "Deconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
            {
                SessionUtilisateur.Fermer();
                this.Hide();

                // Rouvrir le login
                using (var login = new FormLogin())
                {
                    if (login.ShowDialog() == DialogResult.OK &&
                        SessionUtilisateur.EstConnecte)
                    {
                        // Nouvelle session — mettre à jour le nom affiché
                        string nom = SessionUtilisateur.UtilisateurConnecte.NomComplet;
                        string role = SessionUtilisateur.UtilisateurConnecte.Role;
                        this.Text = "Cheikh Tidiane  —  " + nom + " (" + role + ")";
                        lblUtilisateur.Text = " " + nom + "  |  " + role;
                        this.Show();
                        AfficherControl("dashboard");
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void lblUtilisateur_Click(object sender, EventArgs e)
        {

        }
    }
}