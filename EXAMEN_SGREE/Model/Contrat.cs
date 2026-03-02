using EXAMEN_SGREE.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGREE.Models
{
    public class Contrat
    {
        [Key]
        public int Id { get; set; }
        public string NumeroContrat { get; set; }
        public TypeContrat TypeContrat { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public decimal SalaireBase { get; set; }
        public int EmployeId { get; set; }
        public int EmployeurId { get; set; }
        public int DepartementId { get; set; }
        public string Poste { get; set; }
        public StatutContrat Statut { get; set; }
        public string MotifResiliation { get; set; }

        public Employe Employe { get; set; }
        public Employeur Employeur { get; set; }
        public Departement Departement { get; set; }
    }
}