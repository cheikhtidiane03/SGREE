using System.Collections.Generic;
using System.Data;

namespace EXAMEN_SGREE
{
    /// <summary>
    /// DataSet typé source de données Crystal Reports.
    /// Deux tables : StatsType et StatsDept.
    /// </summary>
    public partial class DsStatsEmployeur : DataSet
    {
        public readonly DataTable StatsType;
        public readonly DataTable StatsDept;

        public DsStatsEmployeur()
        {
            this.DataSetName = "DsStatsEmployeur";

            StatsType = new DataTable("StatsType");
            StatsType.Columns.Add("Type", typeof(string));
            StatsType.Columns.Add("Nombre", typeof(int));
            this.Tables.Add(StatsType);

            StatsDept = new DataTable("StatsDept");
            StatsDept.Columns.Add("Departement", typeof(string));
            StatsDept.Columns.Add("NbEmployes", typeof(int));
            StatsDept.Columns.Add("SalaireMoyen", typeof(decimal));
            this.Tables.Add(StatsDept);
        }

        public void Charger(
            List<(string Type, int Nombre)> parType,
            List<(string Dept, int NbEmp, decimal SalMoy)> parDept)
        {
            StatsType.Rows.Clear();
            foreach (var (type, nombre) in parType)
                StatsType.Rows.Add(type, nombre);

            StatsDept.Rows.Clear();
            foreach (var (dept, nbEmp, salMoy) in parDept)
                StatsDept.Rows.Add(dept, nbEmp, salMoy);
        }
    }
}