using EXAMEN_SGREE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SGREE.Models
{
    public class Employe
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string CNI { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public SituationMatrimoniale SituationMatrimoniale { get; set; }
        public int NombreEnfants { get; set; }
    }
}