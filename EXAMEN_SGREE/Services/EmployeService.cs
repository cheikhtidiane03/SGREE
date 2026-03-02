using SGREE.Data;
using SGREE.Models;
using System.Collections.Generic;
using System.Linq;

namespace EXAMEN_SGREE.Services
{
    public class EmployeService
    {
        public List<Employe> GetAll()
        {
            using (var db = new DbContextSgree())
                return db.Employes.ToList();
        }

        public Employe GetById(int id)
        {
            using (var db = new DbContextSgree())
                return db.Employes.Find(id);
        }

        public void Add(Employe emp)
        {
            using (var db = new DbContextSgree())
            {
                db.Employes.Add(emp);
                db.SaveChanges();
            }
        }

        public void Update(Employe emp)
        {
            using (var db = new DbContextSgree())
            {
                var existing = db.Employes.Find(emp.Id);
                if (existing == null) return;
                existing.Nom = emp.Nom;
                existing.Prenom = emp.Prenom;
                existing.Adresse = emp.Adresse;
                existing.Email = emp.Email;
                existing.Telephone = emp.Telephone;
                existing.CNI = emp.CNI;
                existing.DateNaissance = emp.DateNaissance;
                existing.NombreEnfants = emp.NombreEnfants;
                existing.SituationMatrimoniale = emp.SituationMatrimoniale;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbContextSgree())
            {
                var emp = db.Employes.Find(id);
                if (emp != null)
                {
                    db.Employes.Remove(emp);
                    db.SaveChanges();
                }
            }
        }

        public bool CNIExists(string cni, int excludeId = 0)
        {
            using (var db = new DbContextSgree())
                return db.Employes.Any(e => e.CNI == cni && e.Id != excludeId);
        }
    }
}