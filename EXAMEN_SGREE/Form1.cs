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
            // Plein écran au démarrage
            this.WindowState = FormWindowState.Maximized;

            // Afficher Dashboard par défaut
            AfficherControl("dashboard");
        }

        private void AfficherControl(string nom)
        {
            if (nom == null) nom = string.Empty;
            var key = nom.ToLowerInvariant();

            // Visibilité (protéger si le contrôle n'existe pas dans le designer)
            if (controlEmployeur1 != null) controlEmployeur1.Visible = key == "employeur";
            if (controlEmploye1 != null) controlEmploye1.Visible = key == "employe";
            if (controlContrat1 != null) controlContrat1.Visible = key == "contrat";
            if (controlDashboard1 != null) controlDashboard1.Visible = key == "dashboard";

            // Apporter au premier plan le contrôle actif
            if (key == "employeur" && controlEmployeur1 != null) controlEmployeur1.BringToFront();
            if (key == "employe" && controlEmploye1 != null) controlEmploye1.BringToFront();
            if (key == "contrat" && controlContrat1 != null) controlContrat1.BringToFront();
            if (key == "dashboard" && controlDashboard1 != null) controlDashboard1.BringToFront();

            // Couleurs des boutons — highlight sur le bouton actif
            var active = Color.FromArgb(0, 90, 160);
            var normal = Color.FromArgb(0, 122, 204);

            if (btnEmployeur != null) btnEmployeur.BackColor = key == "employeur" ? active : normal;
            if (btnEmploye != null) btnEmploye.BackColor = key == "employe" ? active : normal;
            if (btnContrat != null) btnContrat.BackColor = key == "contrat" ? active : normal;
            if (btnDashboard != null) btnDashboard.BackColor = key == "dashboard" ? active : normal;
        }

        private void btnEmployeur_Click(object sender, EventArgs e)
            => AfficherControl("employeur");

        private void btnEmploye_Click(object sender, EventArgs e)
            => AfficherControl("employe");

        private void btnContrat_Click(object sender, EventArgs e)
            => AfficherControl("contrat");

        private void btnDashboard_Click(object sender, EventArgs e)
            => AfficherControl("dashboard");

        private void button1_Click(object sender, EventArgs e) { }
    }
}