using EXAMEN_SGREE.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGREE.Models
{
    public class Competence
    {
        [Key]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public CategorieCompetence Categorie { get; set; }
        public string Description { get; set; }

        public List<EmployeCompetence> Employes { get; set; }
    }
}