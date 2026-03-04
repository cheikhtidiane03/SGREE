using CrystalDecisions.CrystalReports.Engine;

namespace SGREE.Reports
{
    // ════════════════════════════════════════════════════════════════════
    // RptDashboardKPI
    // DataSet attendu : "DashboardKPI"
    // Tables          : KPI { Indicateur, Valeur, Description, Categorie }
    //                   Metadata { DateGeneration, GenerePar, Titre }
    // ════════════════════════════════════════════════════════════════════
    public class RptDashboardKPI : ReportClass
    {
        public override string ResourceName
        {
            get { return "RptDashboardKPI.rpt"; }
        }
    }

    // ════════════════════════════════════════════════════════════════════
    // RptAlertesDashboard
    // DataSet attendu : "Alertes"
    // Table           : Alertes { Type, Message, DateAlerte, Priorite, EntiteId, EntiteNom }
    // Paramètre       : DateRapport (DateTime)
    // ════════════════════════════════════════════════════════════════════
    public class RptAlertesDashboard : ReportClass
    {
        public override string ResourceName
        {
            get { return "RptAlertesDashboard.rpt"; }
        }
    }

    // ════════════════════════════════════════════════════════════════════
    // RptEvolutionEffectifs
    // DataTable attendue : colonnes Mois(DateTime), TotalEmployes(Int),
    //                               NouveauxContrats(Int)
    // Paramètre         : AnneeCourante (Int32)
    // ════════════════════════════════════════════════════════════════════
    public class RptEvolutionEffectifs : ReportClass
    {
        public override string ResourceName
        {
            get { return "RptEvolutionEffectifs.rpt"; }
        }
    }

    // ════════════════════════════════════════════════════════════════════
    // RptRepartitionSecteurs
    // DataTable attendue : colonnes Secteur(String), Nombre(Int32)
    // ════════════════════════════════════════════════════════════════════
    public class RptRepartitionSecteurs : ReportClass
    {
        public override string ResourceName
        {
            get { return "RptRepartitionSecteurs.rpt"; }
        }
    }
}