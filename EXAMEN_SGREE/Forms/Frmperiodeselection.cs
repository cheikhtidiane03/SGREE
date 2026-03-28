using System;
using System.Windows.Forms;

namespace SGREE.Forms
{
    public partial class FrmPeriodeSelection : Form
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private int _nbMois = 12;

        public DateTime DateDebut => _dateDebut;
        public DateTime DateFin => _dateFin;
        public int NbMois => _nbMois;

        public FrmPeriodeSelection()
        {
            InitializeComponent();
        }

        private void FrmPeriodeSelection_Load(object sender, EventArgs e)
        {
            dtpDateFin.Value = DateTime.Today;
            dtpDateDebut.Value = DateTime.Today.AddMonths(-12);

            cmbPeriodeRapide.Items.AddRange(new object[] {
                "3 derniers mois",
                "6 derniers mois",
                "12 derniers mois",
                "Cette année",
                "Année précédente",
                "Personnalisé"
            });
            cmbPeriodeRapide.SelectedIndex = 2;
        }

        private void cmbPeriodeRapide_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool custom = cmbPeriodeRapide.SelectedIndex == 5;
            dtpDateDebut.Enabled = custom;
            dtpDateFin.Enabled = custom;

            switch (cmbPeriodeRapide.SelectedIndex)
            {
                case 0: // 3 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-3);
                    dtpDateFin.Value = DateTime.Today;
                    _nbMois = 3;
                    break;
                case 1: // 6 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-6);
                    dtpDateFin.Value = DateTime.Today;
                    _nbMois = 6;
                    break;
                case 2: // 12 mois
                    dtpDateDebut.Value = DateTime.Today.AddMonths(-12);
                    dtpDateFin.Value = DateTime.Today;
                    _nbMois = 12;
                    break;
                case 3: // Cette année
                    dtpDateDebut.Value = new DateTime(DateTime.Today.Year, 1, 1);
                    dtpDateFin.Value = DateTime.Today;
                    _nbMois = DateTime.Today.Month;
                    break;
                case 4: // Année précédente
                    dtpDateDebut.Value = new DateTime(DateTime.Today.Year - 1, 1, 1);
                    dtpDateFin.Value = new DateTime(DateTime.Today.Year - 1, 12, 31);
                    _nbMois = 12;
                    break;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (dtpDateDebut.Value >= dtpDateFin.Value)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _dateDebut = dtpDateDebut.Value;
            _dateFin = dtpDateFin.Value;
            _nbMois = (int)Math.Ceiling((_dateFin - _dateDebut).TotalDays / 30.0);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}