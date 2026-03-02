using EXAMEN_SGREE.Enums;
using SGREE.Data;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAMEN_SGREE.Services
{
    public class ContratService
    {
        private const decimal SMIG = 60000m;
        private const int DUREE_MAX_CDD_MOIS = 24;

        // ─── CRUD ─────────────────────────────────────────────────────────
        public List<Contrat> GetAll()
        {
            using (var db = new DbContextSgree())
                return db.Contrats
                    .Include("Employe")
                    .Include("Employeur")
                    .Include("Departement")
                    .ToList();
        }

        public Contrat GetById(int id)
        {
            using (var db = new DbContextSgree())
                return db.Contrats
                    .Include("Employe")
                    .Include("Employeur")
                    .Include("Departement")
                    .FirstOrDefault(c => c.Id == id);
        }

        public ResultatOperation Add(Contrat contrat)
        {
            var validation = ValiderContrat(contrat, isNew: true);
            if (!validation.Succes) return validation;

            using (var db = new DbContextSgree())
            {
                contrat.NumeroContrat = GenererNumero(db);
                db.Contrats.Add(contrat);
                db.SaveChanges();
            }
            return ResultatOperation.Ok("Contrat enregistre avec succes.");
        }

        public ResultatOperation Update(Contrat contrat)
        {
            var validation = ValiderContrat(contrat, isNew: false);
            if (!validation.Succes) return validation;

            using (var db = new DbContextSgree())
            {
                var existing = db.Contrats.Find(contrat.Id);
                if (existing == null) return ResultatOperation.Erreur("Contrat introuvable.");

                existing.TypeContrat = contrat.TypeContrat;
                existing.DateDebut = contrat.DateDebut;
                existing.DateFin = contrat.DateFin;
                existing.SalaireBase = contrat.SalaireBase;
                existing.EmployeId = contrat.EmployeId;
                existing.EmployeurId = contrat.EmployeurId;
                existing.DepartementId = contrat.DepartementId;
                existing.Poste = contrat.Poste;
                existing.Statut = contrat.Statut;
                db.SaveChanges();
            }
            return ResultatOperation.Ok("Contrat modifie avec succes.");
        }

        public void Delete(int id)
        {
            using (var db = new DbContextSgree())
            {
                var c = db.Contrats.Find(id);
                if (c != null) { db.Contrats.Remove(c); db.SaveChanges(); }
            }
        }

        // ─── RENOUVELLEMENT ───────────────────────────────────────────────
        public ResultatOperation Renouveler(int contratId, DateTime nouvelleDateFin, decimal nouveauSalaire)
        {
            using (var db = new DbContextSgree())
            {
                var c = db.Contrats.Find(contratId);
                if (c == null) return ResultatOperation.Erreur("Contrat introuvable.");
                if (c.TypeContrat == TypeContrat.CDI) return ResultatOperation.Erreur("Un CDI n'a pas de date de fin a renouveler.");
                if (nouvelleDateFin <= c.DateFin) return ResultatOperation.Erreur("La nouvelle date de fin doit etre posterieure a l'ancienne.");
                if (nouveauSalaire < SMIG) return ResultatOperation.Erreur("Le salaire ne peut etre inferieur au SMIG (" + SMIG.ToString("N0") + " FCFA).");

                // Verifier la limite CDD
                if (c.TypeContrat == TypeContrat.CDD)
                {
                    var duree = (nouvelleDateFin - c.DateDebut).Days / 30.0;
                    if (duree > DUREE_MAX_CDD_MOIS)
                        return ResultatOperation.Erreur("Un CDD ne peut exceder " + DUREE_MAX_CDD_MOIS + " mois au total.");
                }

                c.DateFin = nouvelleDateFin;
                c.SalaireBase = nouveauSalaire;
                c.Statut = StatutContrat.EnCours;
                db.SaveChanges();
            }
            return ResultatOperation.Ok("Contrat renouvele avec succes.");
        }

        // ─── RESILIATION ──────────────────────────────────────────────────
        public ResultatOperation Resilier(int contratId, string motif)
        {
            if (string.IsNullOrWhiteSpace(motif))
                return ResultatOperation.Erreur("Le motif de resiliation est obligatoire.");

            using (var db = new DbContextSgree())
            {
                var c = db.Contrats.Find(contratId);
                if (c == null) return ResultatOperation.Erreur("Contrat introuvable.");
                if (c.Statut == StatutContrat.Resilie) return ResultatOperation.Erreur("Ce contrat est deja resilie.");

                c.Statut = StatutContrat.Resilie;
                c.DateFin = DateTime.Today;
                db.SaveChanges();
            }
            return ResultatOperation.Ok("Contrat resilie.");
        }

        // ─── ALERTES CONTRATS EXPIRANT ────────────────────────────────────
        /// <summary>Retourne les contrats expirant dans les 'joursAvant' jours.</summary>
        public List<Contrat> GetContratsExpirant(int joursAvant = 30)
        {
            var limite = DateTime.Today.AddDays(joursAvant);
            using (var db = new DbContextSgree())
                return db.Contrats
                    .Include("Employe")
                    .Include("Employeur")
                    .Where(c => c.Statut == StatutContrat.EnCours
                             && c.DateFin != null
                             && c.DateFin <= limite
                             && c.DateFin >= DateTime.Today)
                    .OrderBy(c => c.DateFin)
                    .ToList();
        }

        // ─── VALIDATION METIER ────────────────────────────────────────────
        public ResultatOperation ValiderContrat(Contrat c, bool isNew)
        {
            // Champs obligatoires
            if (string.IsNullOrWhiteSpace(c.Poste))
                return ResultatOperation.Erreur("Le poste est obligatoire.");

            if (c.EmployeId == 0)
                return ResultatOperation.Erreur("Selectionnez un employe.");

            if (c.EmployeurId == 0)
                return ResultatOperation.Erreur("Selectionnez un employeur.");

            if (c.DepartementId == 0)
                return ResultatOperation.Erreur("Selectionnez un departement.");

            // Regle : salaire >= SMIG
            if (c.SalaireBase < SMIG)
                return ResultatOperation.Erreur("Le salaire de base ne peut etre inferieur au SMIG (" + SMIG.ToString("N0") + " FCFA).");

            // Regle : date fin > date debut (sauf CDI)
            if (c.TypeContrat != TypeContrat.CDI)
            {
                if (c.DateFin == null)
                    return ResultatOperation.Erreur("La date de fin est obligatoire pour un " + c.TypeContrat + ".");
                if (c.DateFin <= c.DateDebut)
                    return ResultatOperation.Erreur("La date de fin doit etre superieure a la date de debut.");
            }

            // Regle : CDD <= 24 mois
            if (c.TypeContrat == TypeContrat.CDD && c.DateFin != null)
            {
                double duree = (c.DateFin.Value - c.DateDebut).Days / 30.0;
                if (duree > DUREE_MAX_CDD_MOIS)
                    return ResultatOperation.Erreur("Un CDD ne peut exceder " + DUREE_MAX_CDD_MOIS + " mois (2 ans).");
            }

            // Regle : un seul contrat actif par employe/employeur
            using (var db = new DbContextSgree())
            {
                var query = db.Contrats.Where(x =>
                    x.EmployeId == c.EmployeId &&
                    x.EmployeurId == c.EmployeurId &&
                    (x.Statut == StatutContrat.EnCours || x.Statut == StatutContrat.Actif));

                if (!isNew) query = query.Where(x => x.Id != c.Id);

                if (query.Any())
                    return ResultatOperation.Erreur("Cet employe possede deja un contrat actif chez cet employeur.");
            }

            return ResultatOperation.Ok(string.Empty);
        }

        // ─── GENERATION NUMERO ────────────────────────────────────────────
        private string GenererNumero(DbContextSgree db)
        {
            int annee = DateTime.Now.Year;
            int count = db.Contrats.Count(c => c.NumeroContrat.StartsWith("CTR-" + annee)) + 1;
            return "CTR-" + annee + "-" + count.ToString("D4");
        }
    }

    // ─── Classe résultat opération ─────────────────────────────────────────
    public class ResultatOperation
    {
        public bool Succes { get; private set; }
        public string Message { get; private set; }

        private ResultatOperation(bool succes, string message)
        { Succes = succes; Message = message; }

        public static ResultatOperation Ok(string message) => new ResultatOperation(true, message);
        public static ResultatOperation Erreur(string message) => new ResultatOperation(false, message);
    }
}