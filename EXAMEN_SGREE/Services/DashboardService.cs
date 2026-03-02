using EXAMEN_SGREE.Enums;
using SGREE.Data;
using SGREE.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAMEN_SGREE.Services
{
    /// <summary>
    /// Agrège toutes les données nécessaires au tableau de bord SGREE.
    /// </summary>
    public class DashboardService
    {
        // ═══════════════════════════════════════════════════════════════
        //  KPIs PRINCIPAUX
        // ═══════════════════════════════════════════════════════════════
        public DashboardKpis GetKpis()
        {
            using (var db = new DbContextSgree())
            {
                var employes = db.Employes.ToList();
                var employeurs = db.Employeurs.ToList();
                var contrats = db.Contrats.ToList();
                var depts = db.Departements.ToList();

                var contratsActifs = contrats.Where(c =>
                    c.Statut == StatutContrat.Actif ||
                    c.Statut == StatutContrat.EnCours).ToList();

                return new DashboardKpis
                {
                    TotalEmployes = employes.Count,
                    TotalEmployeurs = employeurs.Count,
                    TotalContrats = contrats.Count,
                    TotalDepartements = depts.Count,
                    ContratsActifs = contratsActifs.Count,
                    MasseSalarialeGlobale = contratsActifs.Sum(c => c.SalaireBase),
                    SalaireMoyen = contratsActifs.Any() ? contratsActifs.Average(c => c.SalaireBase) : 0,
                    EmployesSansContrat = employes.Count(e =>
                        !contrats.Any(c => c.EmployeId == e.Id &&
                            (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours))),
                    EmployeursActifs = employeurs.Count(e => e.Statut == StatutEmployeur.Actif),
                    ContratsExpirantSoon = contrats.Count(c =>
                        c.DateFin.HasValue &&
                        c.DateFin.Value > DateTime.Today &&
                        c.DateFin.Value <= DateTime.Today.AddDays(30) &&
                        (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours))
                };
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  RÉPARTITION PAR SECTEUR (pour camembert)
        // ═══════════════════════════════════════════════════════════════
        public List<(string Secteur, int NbEmployeurs, int NbEmployes)> GetRepartitionSecteur()
        {
            using (var db = new DbContextSgree())
            {
                var employeurs = db.Employeurs
                    .Where(e => e.Statut == StatutEmployeur.Actif)
                    .ToList();

                var contrats = db.Contrats
                    .Where(c => c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours)
                    .ToList();

                return employeurs
                    .GroupBy(e => string.IsNullOrWhiteSpace(e.SecteurActivite) ? "Non défini" : e.SecteurActivite)
                    .Select(g => (
                        Secteur: g.Key,
                        NbEmployeurs: g.Count(),
                        NbEmployes: contrats
                            .Where(c => g.Select(x => x.Id).Contains(c.EmployeurId))
                            .Select(c => c.EmployeId).Distinct().Count()
                    ))
                    .OrderByDescending(x => x.NbEmployeurs)
                    .Take(8)
                    .ToList();
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  ÉVOLUTION DES EFFECTIFS (6 derniers mois)
        // ═══════════════════════════════════════════════════════════════
        public List<(string Mois, int NbContrats, decimal MasseSalariale)> GetEvolutionMensuelle()
        {
            using (var db = new DbContextSgree())
            {
                var contrats = db.Contrats.ToList();
                var result = new List<(string, int, decimal)>();

                for (int i = 5; i >= 0; i--)
                {
                    var date = DateTime.Today.AddMonths(-i);
                    var debut = new DateTime(date.Year, date.Month, 1);
                    var fin = debut.AddMonths(1).AddDays(-1);

                    var actifs = contrats.Where(c =>
                        c.DateDebut <= fin &&
                        (!c.DateFin.HasValue || c.DateFin.Value >= debut) &&
                        (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours ||
                         c.Statut == StatutContrat.Termine)).ToList();

                    result.Add((
                        date.ToString("MMM yy"),
                        actifs.Count,
                        actifs.Sum(c => c.SalaireBase)
                    ));
                }
                return result;
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  RÉPARTITION PAR TYPE DE CONTRAT
        // ═══════════════════════════════════════════════════════════════
        public List<(string Type, int Nombre)> GetRepartitionTypeContrat()
        {
            using (var db = new DbContextSgree())
            {
                return db.Contrats
                    .GroupBy(c => c.TypeContrat)
                    .Select(g => new { Type = g.Key.ToString(), Nombre = g.Count() })
                    .ToList()
                    .Select(x => (x.Type, x.Nombre))
                    .OrderByDescending(x => x.Nombre)
                    .ToList();
            }
        }

        // ═══════════════════════════════════════════════════════════════
        //  ALERTES COMPLÈTES
        // ═══════════════════════════════════════════════════════════════
        public List<AlerteDashboard> GetAlertes()
        {
            var alertes = new List<AlerteDashboard>();

            using (var db = new DbContextSgree())
            {
                var contrats = db.Contrats.Include("Employe").Include("Employeur").ToList();
                var employes = db.Employes.ToList();

                // Contrats expirant dans 30 jours
                var expirants = contrats.Where(c =>
                    c.DateFin.HasValue &&
                    c.DateFin.Value > DateTime.Today &&
                    c.DateFin.Value <= DateTime.Today.AddDays(30) &&
                    (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours));

                foreach (var c in expirants.OrderBy(c => c.DateFin))
                {
                    int jours = (int)(c.DateFin.Value - DateTime.Today).TotalDays;
                    alertes.Add(new AlerteDashboard
                    {
                        Niveau = jours <= 7 ? NiveauAlerte.Critique : jours <= 15 ? NiveauAlerte.Urgent : NiveauAlerte.Attention,
                        Categorie = "Contrat expirant",
                        Message = (c.Employe != null ? c.Employe.Nom + " " + c.Employe.Prenom : "?") +
                                     " — " + c.TypeContrat + " expire dans " + jours + " jour(s)",
                        Detail = c.Employeur != null ? c.Employeur.RaisonSociale : "",
                        DateEcheance = c.DateFin.Value
                    });
                }

                // Employés sans contrat actif
                var sansContrat = employes.Where(e =>
                    !contrats.Any(c => c.EmployeId == e.Id &&
                        (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours)));

                foreach (var e in sansContrat.Take(10))
                {
                    alertes.Add(new AlerteDashboard
                    {
                        Niveau = NiveauAlerte.Information,
                        Categorie = "Sans contrat actif",
                        Message = e.Nom + " " + e.Prenom + " n'a aucun contrat en cours",
                        Detail = e.Email ?? "",
                        DateEcheance = DateTime.Today
                    });
                }

                // Employeurs suspendus avec contrats actifs
                var empSuspendus = db.Employeurs
                    .Where(e => e.Statut == StatutEmployeur.Suspendu).ToList();
                foreach (var emp in empSuspendus)
                {
                    int nb = contrats.Count(c => c.EmployeurId == emp.Id &&
                        (c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours));
                    if (nb > 0)
                        alertes.Add(new AlerteDashboard
                        {
                            Niveau = NiveauAlerte.Urgent,
                            Categorie = "Employeur suspendu",
                            Message = emp.RaisonSociale + " est suspendu mais a " + nb + " contrat(s) actif(s)",
                            Detail = emp.NINEA ?? "",
                            DateEcheance = DateTime.Today
                        });
                }
            }

            return alertes.OrderBy(a => a.Niveau).ThenBy(a => a.DateEcheance).ToList();
        }

        // ═══════════════════════════════════════════════════════════════
        //  TOP EMPLOYEURS (par nb employés)
        // ═══════════════════════════════════════════════════════════════
        public List<(string RaisonSociale, string Secteur, int NbEmployes, decimal MasseSalariale)> GetTopEmployeurs()
        {
            using (var db = new DbContextSgree())
            {
                var contrats = db.Contrats
                    .Include("Employeur")
                    .Where(c => c.Statut == StatutContrat.Actif || c.Statut == StatutContrat.EnCours)
                    .ToList();

                return contrats
                    .GroupBy(c => c.EmployeurId)
                    .Select(g => (
                        RaisonSociale: g.First().Employeur?.RaisonSociale ?? "?",
                        Secteur: g.First().Employeur?.SecteurActivite ?? "-",
                        NbEmployes: g.Select(c => c.EmployeId).Distinct().Count(),
                        MasseSalariale: g.Sum(c => c.SalaireBase)
                    ))
                    .OrderByDescending(x => x.NbEmployes)
                    .Take(5)
                    .ToList();
            }
        }
    }

    // ═══════════════════════════════════════════════════════════════════
    //  MODÈLES DASHBOARD
    // ═══════════════════════════════════════════════════════════════════
    public class DashboardKpis
    {
        public int TotalEmployes { get; set; }
        public int TotalEmployeurs { get; set; }
        public int TotalContrats { get; set; }
        public int TotalDepartements { get; set; }
        public int ContratsActifs { get; set; }
        public decimal MasseSalarialeGlobale { get; set; }
        public decimal SalaireMoyen { get; set; }
        public int EmployesSansContrat { get; set; }
        public int EmployeursActifs { get; set; }
        public int ContratsExpirantSoon { get; set; }
    }

    public enum NiveauAlerte { Critique = 0, Urgent = 1, Attention = 2, Information = 3 }

    public class AlerteDashboard
    {
        public NiveauAlerte Niveau { get; set; }
        public string Categorie { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
        public DateTime DateEcheance { get; set; }
    }
}