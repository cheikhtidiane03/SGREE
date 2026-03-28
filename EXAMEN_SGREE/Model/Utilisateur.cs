using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGREE.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        [MaxLength(255)] 
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string MotDePasseHash { get; set; }

        [Required]
        public string Sel { get; set; }

        public string Role { get; set; } = "Utilisateur";

        public bool Actif { get; set; } = true;

        public DateTime DateCreation { get; set; } = DateTime.Now;

        public DateTime? DerniereConnexion { get; set; }

        [NotMapped]
        public string NomComplet => Nom + " " + Prenom;
    }
}