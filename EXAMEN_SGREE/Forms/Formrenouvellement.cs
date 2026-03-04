using EXAMEN_SGREE.Services;
using SGREE.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    /// <summary>
    /// Formulaire modal pour renouveler un contrat CDD/Stage/Consultant.
    /// Affiche les infos actuelles et demande la nouvelle date de fin + nouveau salaire.
    /// </summary>
    public partial class FormRenouvellement : Form
    {
        private readonly int contratId;
        private readonly ContratService service;
        private Contrat contrat;

        public FormRenouvellement(int contratId, ContratService service)
        {
            this.contratId = contratId;
            this.service = service;
            InitializeComponent();
        }

        private void FormRenouvellement_Load(object sender, EventArgs e)
        {
            contrat = service.GetById(contratId);
            if (contrat == null) { this.Close(); return; }

            // Infos actuelles
            lblInfoNumero.Text = contrat.NumeroContrat;
            lblInfoType.Text = contrat.TypeContrat.ToString();
            lblInfoEmploye.Text = contrat.Employe != null ? contrat.Employe.Nom + " " + contrat.Employe.Prenom : "-";
            lblInfoDateFin.Text = contrat.DateFin.HasValue ? contrat.DateFin.Value.ToString("dd/MM/yyyy") : "-";
            lblInfoSalaire.Text = contrat.SalaireBase.ToString("N0") + " FCFA";

            // Proposer +1 an par défaut
            dtpNouvelleDateFin.Value = contrat.DateFin.HasValue
                ? contrat.DateFin.Value.AddYears(1)
                : DateTime.Today.AddYears(1);

            // Minimum/Maximum AVANT Value — sinon ArgumentOutOfRangeException
            nudNouveauSalaire.Minimum = 60000m;
            nudNouveauSalaire.Maximum = 99999999m;
            nudNouveauSalaire.Increment = 5000m;
            nudNouveauSalaire.ThousandsSeparator = true;
            nudNouveauSalaire.Value = Math.Max(nudNouveauSalaire.Minimum, Math.Min(nudNouveauSalaire.Maximum, contrat.SalaireBase));
        }

        private void BtnConfirmer_Click(object sender, EventArgs e)
        {
            var res = service.Renouveler(contratId, dtpNouvelleDateFin.Value, nudNouveauSalaire.Value);
            if (!res.Succes)
            {
                MessageBox.Show(res.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(res.Message, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}