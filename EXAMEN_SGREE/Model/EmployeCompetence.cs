using EXAMEN_SGREE.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGREE.Models
{
    public class EmployeCompetence
    {
        [Key, Column(Order = 0)] 
        public int EmployeId { get; set; }

        [Key, Column(Order = 1)] 
        public int CompetenceId { get; set; }

        public NiveauCompetence Niveau { get; set; }
        public DateTime DateAcquisition { get; set; }
        public bool Certifie { get; set; }

        public Employe Employe { get; set; }
        public Competence Competence { get; set; }
    }
}