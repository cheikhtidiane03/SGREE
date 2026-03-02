using CrystalDecisions.CrystalReports.Engine;

namespace EXAMEN_SGREE
{
    public partial class RptStatsDept : ReportDocument
    {
        public RptStatsDept()
        {
            string path = System.IO.Path.Combine(
                System.AppDomain.CurrentDomain.BaseDirectory,
                "Reports", "RptStatsDept.rpt");
            this.Load(path);
        }

        public void SetDataSource(DsStatsEmployeur ds, string titreEmployeur)
        {
            this.SetDataSource(ds.StatsDept);
            try { this.SetParameterValue("pTitre", "Departements - " + titreEmployeur); }
            catch { }
        }
    }
}