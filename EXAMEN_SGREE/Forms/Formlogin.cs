using EXAMEN_SGREE.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class FormLogin : Form
    {
        private readonly UtilisateurService _service = new UtilisateurService();
        private int _tentatives = 0;
        private const int MAX_TENTATIVES = 5;

        public FormLogin()
        {
            InitializeComponent();
        }

        // ================================================================
        //  LOAD
        // ================================================================
        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Créer le compte admin par défaut si la table est vide
            try { _service.SeedAdminSiVide(); }
            catch { /* base pas encore migrée — on continue */ }

            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
            MasquerErreur();
        }

        // ================================================================
        //  CONNEXION
        // ================================================================
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            TenterConnexion();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) TenterConnexion();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPassword.Focus();
        }

        private void TenterConnexion()
        {
            MasquerErreur();

            string email = txtEmail.Text.Trim();
            string mdp = txtPassword.Text;

            // Validation basique côté UI
            if (string.IsNullOrWhiteSpace(email))
            { AfficherErreur("Veuillez saisir votre adresse email."); txtEmail.Focus(); return; }

            if (!email.Contains("@"))
            { AfficherErreur("L'adresse email n'est pas valide."); txtEmail.Focus(); return; }

            if (string.IsNullOrWhiteSpace(mdp))
            { AfficherErreur("Veuillez saisir votre mot de passe."); txtPassword.Focus(); return; }

            // Tentative d'authentification
            btnConnexion.Enabled = false;
            btnConnexion.Text = "Connexion...";
            Cursor = Cursors.WaitCursor;

            try
            {
                var user = _service.Authentifier(email, mdp);

                if (user == null)
                {
                    _tentatives++;
                    int restantes = MAX_TENTATIVES - _tentatives;

                    if (_tentatives >= MAX_TENTATIVES)
                    {
                        AfficherErreur("Compte bloqué après " + MAX_TENTATIVES +
                                       " tentatives. Relancez l'application.");
                        btnConnexion.Enabled = false;
                        return;
                    }

                    AfficherErreur("Email ou mot de passe incorrect. " +
                                   restantes + " tentative(s) restante(s).");
                    txtPassword.Clear();
                    txtPassword.Focus();

                    // Animation rouge sur les champs
                    AnimerErreurChamps();
                    return;
                }

                // ── Connexion réussie ────────────────────────────────────
                SessionUtilisateur.Ouvrir(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                AfficherErreur("Erreur de connexion : " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                btnConnexion.Enabled = _tentatives < MAX_TENTATIVES;
                btnConnexion.Text = "Se connecter";
            }
        }

        // ================================================================
        //  AFFICHER / MASQUER MOT DE PASSE
        // ================================================================
        private void BtnToggleMdp_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            btnToggleMdp.Text = txtPassword.UseSystemPasswordChar ? "👁" : "🙈";
        }

        // ================================================================
        //  FENÊTRE - BOUTONS DE CONTRÔLE
        // ================================================================
        private void BtnMinimiser_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximiser_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================================================================
        //  QUITTER
        // ================================================================
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================================================================
        //  HELPERS UI
        // ================================================================
        private void AfficherErreur(string message)
        {
            lblErreur.Text = "  ⚠  " + message;
            lblErreur.Visible = true;
        }

        private void MasquerErreur()
        {
            lblErreur.Text = "";
            lblErreur.Visible = false;
        }

        private void AnimerErreurChamps()
        {
            Color rouge = Color.FromArgb(255, 220, 220);
            Color neutre = SystemColors.Window;

            txtEmail.BackColor = rouge;
            txtPassword.BackColor = rouge;

            var timer = new Timer { Interval = 600 };
            timer.Tick += (s, ev) =>
            {
                txtEmail.BackColor = neutre;
                txtPassword.BackColor = neutre;
                ((Timer)s).Stop();
                ((Timer)s).Dispose();
            };
            timer.Start();
        }

        // ── Déplacer la fenêtre sans barre de titre ──────────────────────
        private bool _dragging;
        private Point _dragStart;

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { _dragging = true; _dragStart = e.Location; }
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point diff = Point.Subtract(e.Location, new Size(_dragStart));
                Location = Point.Add(Location, new Size(diff));
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErreur_Click(object sender, EventArgs e)
        {

        }
    }
}