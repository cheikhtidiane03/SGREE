using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGREE.Models
{
    public class Departement
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public int EmployeurId { get; set; }
        public int? ResponsableId { get; set; }

        public Employeur Employeur { get; set; }
        public Employe Responsable { get; set; }
        public List<Contrat> Contrats { get; set; }
    }
}