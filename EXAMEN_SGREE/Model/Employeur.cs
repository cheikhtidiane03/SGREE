using EXAMEN_SGREE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGREE.Models
{
    public class Employeur
    {
        [Key]
        public int Id { get; set; }
        public string RaisonSociale { get; set; }
        public string NINEA { get; set; }
        public string SecteurActivite { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
        public StatutEmployeur Statut { get; set; }

        public List<Departement> Departements { get; set; } = new List<Departement>();
        public List<Contrat> Contrats { get; set; } = new List<Contrat>();
    }
}