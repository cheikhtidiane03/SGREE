using SGREE.Data;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EXAMEN_SGREE.Services
{
    public class UtilisateurService
    {
   
        private static string GenererSel()
        {
            byte[] buf = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
                rng.GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private static string Hacher(string motDePasse, string sel)
        {
            string combined = sel + motDePasse;
            using (var sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(combined));
                return Convert.ToBase64String(hash);
            }
        }

        public Utilisateur Authentifier(string email, string motDePasse)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(motDePasse))
                return null;

            using (var db = new DbContextSgree())
            {
                var user = db.Utilisateurs
                    .FirstOrDefault(u =>
                        u.Email == email.Trim().ToLower() &&
                        u.Actif);

                if (user == null) return null;

                string hash = Hacher(motDePasse, user.Sel);
                if (hash != user.MotDePasseHash) return null;

                user.DerniereConnexion = DateTime.Now;
                db.SaveChanges();

                return user;
            }
        }

        public List<Utilisateur> GetAll()
        {
            using (var db = new DbContextSgree())
                return db.Utilisateurs.ToList();
        }

        public Utilisateur GetById(int id)
        {
            using (var db = new DbContextSgree())
                return db.Utilisateurs.Find(id);
        }

        public void Creer(string nom, string prenom, string email,
                          string motDePasse, string role = "Utilisateur")
        {
            string sel = GenererSel();
            string hash = Hacher(motDePasse, sel);

            using (var db = new DbContextSgree())
            {
                db.Utilisateurs.Add(new Utilisateur
                {
                    Nom = nom.Trim(),
                    Prenom = prenom.Trim(),
                    Email = email.Trim().ToLower(),
                    MotDePasseHash = hash,
                    Sel = sel,
                    Role = role,
                    Actif = true,
                    DateCreation = DateTime.Now
                });
                db.SaveChanges();
            }
        }

        public bool ChangerMotDePasse(int id, string ancienMdp, string nouveauMdp)
        {
            using (var db = new DbContextSgree())
            {
                var user = db.Utilisateurs.Find(id);
                if (user == null) return false;

                string hashAncien = Hacher(ancienMdp, user.Sel);
                if (hashAncien != user.MotDePasseHash) return false;

                user.Sel = GenererSel();
                user.MotDePasseHash = Hacher(nouveauMdp, user.Sel);
                db.SaveChanges();
                return true;
            }
        }

        public void ReinitialiserMotDePasse(int id, string nouveauMdp)
        {
            using (var db = new DbContextSgree())
            {
                var user = db.Utilisateurs.Find(id);
                if (user == null) return;
                user.Sel = GenererSel();
                user.MotDePasseHash = Hacher(nouveauMdp, user.Sel);
                db.SaveChanges();
            }
        }

        public void Supprimer(int id)
        {
            using (var db = new DbContextSgree())
            {
                var user = db.Utilisateurs.Find(id);
                if (user != null)
                { db.Utilisateurs.Remove(user); db.SaveChanges(); }
            }
        }

        public bool EmailExiste(string email, int excludeId = 0)
        {
            using (var db = new DbContextSgree())
                return db.Utilisateurs.Any(u =>
                    u.Email == email.Trim().ToLower() && u.Id != excludeId);
        }

 
        public void SeedAdminSiVide()
        {
            using (var db = new DbContextSgree())
            {
                if (!db.Utilisateurs.Any())
                    //Creer("Admin", "SGREE", "admin@sgree.sn", "Admin@1234", "Admin");
                    Creer("Cheikh Tidiane", "Ba", "cheikh.catb@gmail.com", "password", "Admin");

            }
        }
    }
}