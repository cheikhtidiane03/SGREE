using CrystalDecisions.CrystalReports.Engine;

namespace EXAMEN_SGREE
{
    public partial class RptStatsType : ReportDocument
    {
        public RptStatsType()
        {
            string path = System.IO.Path.Combine(
                System.AppDomain.CurrentDomain.BaseDirectory,
                "Reports", "RptStatsType.rpt");
            this.Load(path);
        }

        public void SetDataSource(DsStatsEmployeur ds, string titreEmployeur)
        {
            this.SetDataSource(ds.StatsType);
            try { this.SetParameterValue("pTitre", "Contrats - " + titreEmployeur); }
            catch { }
        }
    }
}