using EXAMEN_SGREE.Enums;
using SGREE.Data;
using SGREE.Models;
using System.Collections.Generic;
using System.Linq;

namespace EXAMEN_SGREE.Services
{
    public class EmployeurService
    {
        public List<Employeur> GetAll()
        {
            using (var db = new DbContextSgree())
                return db.Employeurs.ToList();
        }

        public Employeur GetById(int id)
        {
            using (var db = new DbContextSgree())
                return db.Employeurs.Find(id);
        }

        public void Add(Employeur emp)
        {
            using (var db = new DbContextSgree())
            {
                db.Employeurs.Add(emp);
                db.SaveChanges();
            }
        }

        public void Update(Employeur emp)
        {
            using (var db = new DbContextSgree())
            {
                var existing = db.Employeurs.Find(emp.Id);
                if (existing == null) return;
                existing.RaisonSociale = emp.RaisonSociale;
                existing.NINEA = emp.NINEA;
                existing.SecteurActivite = emp.SecteurActivite;
                existing.Adresse = emp.Adresse;
                existing.Telephone = emp.Telephone;
                existing.Email = emp.Email;
                existing.DateCreation = emp.DateCreation;
                existing.Statut = emp.Statut;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DbContextSgree())
            {
                var emp = db.Employeurs.Find(id);
                if (emp != null)
                {
                    db.Employeurs.Remove(emp);
                    db.SaveChanges();
                }
            }
        }

        public bool NIEAExists(string ninea, int excludeId = 0)
        {
            using (var db = new DbContextSgree())
                return db.Employeurs.Any(e => e.NINEA == ninea && e.Id != excludeId);
        }

        public EmployeurStats GetStats(int employeurId)
        {
            using (var db = new DbContextSgree())
            {
                var contrats = db.Contrats
                    .Where(c => c.EmployeurId == employeurId)
                    .ToList();

                // Masse salariale = contrats actifs (EnCours ou Actif)
                var contratsActifs = contrats.Where(c =>
                    c.Statut == StatutContrat.EnCours ||
                    c.Statut == StatutContrat.Actif);

                return new EmployeurStats
                {
                    TotalContrats = contrats.Count,
                    TotalEmployes = contrats.Select(c => c.EmployeId).Distinct().Count(),
                    MasseSalariale = contratsActifs.Sum(c => c.SalaireBase)
                };
            }
        }
    }
}