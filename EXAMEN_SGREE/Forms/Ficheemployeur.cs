using CrystalDecisions.CrystalReports.Engine;
using EXAMEN_SGREE.Enums;
using EXAMEN_SGREE.Services;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EXAMEN_SGREE
{
    public partial class FicheEmployeur : Form
    {
        private readonly Employeur employeur;

        public FicheEmployeur(Employeur emp)
        {
            InitializeComponent();
            this.employeur = emp;

            // Styles des en-têtes de grille (ne peuvent pas être dans le Designer)
            AppliquerStylesGrilles();
        }

        private void AppliquerStylesGrilles()
        {
            var headerStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(0, 122, 204),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold)
            };
            dgvDepartements.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvEmployes.ColumnHeadersDefaultCellStyle = headerStyle;
        }

        private void FicheEmployeur_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            this.Text = "Fiche Employeur - " + employeur.RaisonSociale;
            lblTitre.Text = "Fiche Employeur : " + employeur.RaisonSociale;
            InitTabInfos();
            ChargerInfos();
            ChargerDepartements();
            ChargerEmployes();
            ChargerStatistiques();
        }

        // ═══════════════════════════════════════════════════════════════
        //  ONGLET INFORMATIONS
        // ═══════════════════════════════════════════════════════════════
        private void InitTabInfos()
        {
            var top = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                BackColor = Color.FromArgb(0, 122, 204)
            };
            top.Controls.Add(new Label
            {
                Text = "Informations de l'Employeur",
                Font = new Font("Century Gothic", 13F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(15, 13)
            });
            tabInfos.Controls.Add(top);

            int lx1 = 30, vx1 = 230, lx2 = 530, vx2 = 720, sy = 75, rh = 52;
            AddRow(lx1, vx1, sy + (rh * 0), "ID :", out _, out lblIdVal);
            AddRow(lx2, vx2, sy + (rh * 0), "Raison Sociale :", out _, out lblRaisonVal);
            AddRow(lx1, vx1, sy + (rh * 1), "NINEA :", out _, out lblNINEAVal);
            AddRow(lx2, vx2, sy + (rh * 1), "Secteur :", out _, out lblSecteurVal);
            AddRow(lx1, vx1, sy + (rh * 2), "Adresse :", out _, out lblAdresseVal);
            AddRow(lx2, vx2, sy + (rh * 2), "Telephone :", out _, out lblTelephoneVal);
            AddRow(lx1, vx1, sy + (rh * 3), "Email :", out _, out lblEmailVal);
            AddRow(lx2, vx2, sy + (rh * 3), "Date Creation :", out _, out lblDateCreationVal);
            AddRow(lx1, vx1, sy + (rh * 4), "Statut :", out _, out lblStatutVal);
            tabInfos.Controls.Add(new Panel
            {
                Location = new Point(20, sy + (rh * 5) + 5),
                Size = new Size(950, 2),
                BackColor = Color.FromArgb(0, 122, 204)
            });
        }

        private void AddRow(int x1, int x2, int y, string txt, out Label lbl, out Label val)
        {
            lbl = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 10F, FontStyle.Bold),
                Location = new Point(x1, y),
                Text = txt
            };
            val = new Label
            {
                AutoSize = true,
                Font = new Font("Century Gothic", 10F),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(x2, y),
                Text = "-"
            };
            tabInfos.Controls.Add(lbl);
            tabInfos.Controls.Add(val);
        }

        private void ChargerInfos()
        {
            lblIdVal.Text = employeur.Id.ToString();
            lblRaisonVal.Text = employeur.RaisonSociale ?? "-";
            lblNINEAVal.Text = employeur.NINEA ?? "-";
            lblSecteurVal.Text = employeur.SecteurActivite ?? "-";
            lblAdresseVal.Text = employeur.Adresse ?? "-";
            lblTelephoneVal.Text = employeur.Telephone ?? "-";
            lblEmailVal.Text = employeur.Email ?? "-";
            lblDateCreationVal.Text = employeur.DateCreation.ToString("dd/MM/yyyy");
            lblStatutVal.Text = employeur.Statut.ToString();

            switch (employeur.Statut)
            {
                case StatutEmployeur.Actif: lblStatutVal.ForeColor = Color.Green; break;
                case StatutEmployeur.Suspendu: lblStatutVal.ForeColor = Color.Orange; break;
                case StatutEmployeur.Ferme: lblStatutVal.ForeColor = Color.Red; break;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  ONGLET DEPARTEMENTS
        // ═══════════════════════════════════════════════════════════════
        private void ChargerDepartements()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var list = db.Departements
                        .Where(d => d.EmployeurId == employeur.Id)
                        .Select(d => new
                        {
                            d.Id,
                            d.Code,
                            d.Libelle,
                            d.Description,
                            Responsable = d.Responsable != null
                                ? d.Responsable.Nom + " " + d.Responsable.Prenom : "-"
                        }).ToList();

                    dgvDepartements.DataSource = list;
                    if (dgvDepartements.Columns.Count > 0)
                    {
                        dgvDepartements.Columns["Id"].Visible = false;
                        dgvDepartements.Columns["Code"].HeaderText = "Code";
                        dgvDepartements.Columns["Libelle"].HeaderText = "Libelle";
                        dgvDepartements.Columns["Description"].HeaderText = "Description";
                        dgvDepartements.Columns["Responsable"].HeaderText = "Responsable";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur departements :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  ONGLET EMPLOYES
        // ═══════════════════════════════════════════════════════════════
        private void ChargerEmployes()
        {
            try
            {
                using (var db = new SGREE.Data.DbContextSgree())
                {
                    var list = db.Contrats
                        .Where(c => c.EmployeurId == employeur.Id)
                        .Select(c => new
                        {
                            c.Employe.Id,
                            c.Employe.Nom,
                            c.Employe.Prenom,
                            c.Poste,
                            Departement = c.Departement.Libelle,
                            c.DateDebut,
                            c.DateFin,
                            Type = c.TypeContrat.ToString(),
                            Statut = c.Statut.ToString(),
                            c.SalaireBase
                        }).ToList();

                    dgvEmployes.DataSource = list;
                    if (dgvEmployes.Columns.Count > 0)
                    {
                        dgvEmployes.Columns["Id"].Visible = false;
                        dgvEmployes.Columns["Nom"].HeaderText = "Nom";
                        dgvEmployes.Columns["Prenom"].HeaderText = "Prenom";
                        dgvEmployes.Columns["Poste"].HeaderText = "Poste";
                        dgvEmployes.Columns["Departement"].HeaderText = "Departement";
                        dgvEmployes.Columns["DateDebut"].HeaderText = "Debut";
                        dgvEmployes.Columns["DateFin"].HeaderText = "Fin";
                        dgvEmployes.Columns["Type"].HeaderText = "Type";
                        dgvEmployes.Columns["Statut"].HeaderText = "Statut";
                        dgvEmployes.Columns["SalaireBase"].HeaderText = "Salaire (FCFA)";
                        dgvEmployes.Columns["DateDebut"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvEmployes.Columns["DateFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvEmployes.Columns["SalaireBase"].DefaultCellStyle.Format = "N0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur employes :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  ONGLET STATISTIQUES
        // ═══════════════════════════════════════════════════════════════
        private void ChargerStatistiques()
        {
            try
            {
                var svc = new EmployeurService();
                var stats = svc.GetStats(employeur.Id);
                lblStatTotalEmployes.Text = stats.TotalEmployes.ToString();
                lblStatTotalContrats.Text = stats.TotalContrats.ToString();
                lblStatMasseSalariale.Text = stats.MasseSalariale.ToString("N0") + " FCFA";

                var parType = new List<(string Type, int Nombre)>();
                var parDept = new List<(string Dept, int NbEmp, decimal SalMoy)>();

                using (var db = new SGREE.Data.DbContextSgree())
                {
                    db.Contrats
                      .Where(c => c.EmployeurId == employeur.Id)
                      .GroupBy(c => c.TypeContrat)
                      .Select(g => new { Type = g.Key.ToString(), Nombre = g.Count() })
                      .ToList()
                      .ForEach(r => parType.Add((r.Type, r.Nombre)));

                    db.Contrats
                      .Where(c => c.EmployeurId == employeur.Id)
                      .GroupBy(c => c.Departement.Libelle)
                      .Select(g => new { Dept = g.Key, NbEmp = g.Count(), SalMoy = g.Average(x => x.SalaireBase) })
                      .ToList()
                      .ForEach(r => parDept.Add((r.Dept, r.NbEmp, r.SalMoy)));
                }

                var ds = new DsStatsEmployeur();
                ds.Charger(parType, parDept);

                var viewerType = CreateCrystalViewer();
                var viewerDept = CreateCrystalViewer();

                if (viewerType != null && viewerDept != null)
                {
                    viewerType.Dock = DockStyle.Fill;
                    viewerDept.Dock = DockStyle.Fill;
                    panelCrvType.Controls.Add(viewerType);
                    panelCrvDept.Controls.Add(viewerDept);
                    ChargerRapport(viewerType, new RptStatsType(), ds, true);
                    ChargerRapport(viewerDept, new RptStatsDept(), ds, false);
                }
                else
                {
                    AfficherFallback(parType, parDept);
                }

                ShowChart(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur statistiques :\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Control CreateCrystalViewer()
        {
            try
            {
                Assembly asm = null;
                foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    if (a.GetName().Name.Equals("CrystalDecisions.Windows.Forms", StringComparison.OrdinalIgnoreCase))
                    {
                        asm = a;
                        break;
                    }
                }

                if (asm == null)
                    asm = Assembly.Load("CrystalDecisions.Windows.Forms, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304");

                var t = asm?.GetType("CrystalDecisions.Windows.Forms.CrystalReportViewer");
                if (t == null) return null;

                var v = (Control)Activator.CreateInstance(t);
                SetProp(v, "ShowToolBar", true);
                SetProp(v, "ShowGroupTree", false);
                SetProp(v, "BorderStyle", BorderStyle.None);
                return v;
            }
            catch
            {
                return null;
            }
        }

        private void ChargerRapport(Control viewer, ReportDocument rpt, DsStatsEmployeur ds, bool isType)
        {
            try
            {
                if (isType)
                    ((RptStatsType)rpt).SetDataSource(ds, employeur.RaisonSociale);
                else
                    ((RptStatsDept)rpt).SetDataSource(ds, employeur.RaisonSociale);

                SetProp(viewer, "ReportSource", rpt);
                viewer.GetType().GetMethod("Refresh")?.Invoke(viewer, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapport non charge :\n" + ex.Message, "Crystal Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetProp(object obj, string prop, object val)
        {
            try { obj.GetType().GetProperty(prop)?.SetValue(obj, val, null); }
            catch { }
        }

        private void ShowChart(bool showType)
        {
            panelCrvType.Visible = showType;
            panelCrvDept.Visible = !showType;
            btnShowType.BackColor = showType ? Color.FromArgb(0, 122, 204) : Color.FromArgb(100, 100, 100);
            btnShowDept.BackColor = showType ? Color.FromArgb(100, 100, 100) : Color.FromArgb(0, 122, 204);
        }

        private void AfficherFallback(
            List<(string Type, int Nombre)> parType,
            List<(string Dept, int NbEmp, decimal SalMoy)> parDept)
        {
            panelCrvType.Controls.Add(new Label
            {
                Text = "Crystal Reports non disponible - tableau de substitution.",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Century Gothic", 9F),
                ForeColor = Color.DarkOrange
            });

            var dgvT = MakeFallbackDgv();
            dgvT.Location = new Point(10, 50);
            dgvT.Size = new Size(400, 250);
            var dtT = new System.Data.DataTable();
            dtT.Columns.Add("Type");
            dtT.Columns.Add("Nombre", typeof(int));
            foreach (var r in parType) dtT.Rows.Add(r.Type, r.Nombre);
            dgvT.DataSource = dtT;
            panelCrvType.Controls.Add(dgvT);

            var dgvD = MakeFallbackDgv();
            dgvD.Location = new Point(10, 10);
            dgvD.Size = new Size(600, 250);
            var dtD = new System.Data.DataTable();
            dtD.Columns.Add("Departement");
            dtD.Columns.Add("Nb Employes", typeof(int));
            dtD.Columns.Add("Salaire Moyen", typeof(decimal));
            foreach (var r in parDept) dtD.Rows.Add(r.Dept, r.NbEmp, r.SalMoy);
            dgvD.DataSource = dtD;
            panelCrvDept.Controls.Add(dgvD);
        }

        private DataGridView MakeFallbackDgv()
        {
            var dgv = new DataGridView
            {
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                EnableHeadersVisualStyles = false
            };
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            return dgv;
        }

        private void BtnShowType_Click(object sender, EventArgs e) => ShowChart(true);
        private void BtnShowDept_Click(object sender, EventArgs e) => ShowChart(false);
        private void BtnFermer_Click(object sender, EventArgs e) => this.Close();

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}