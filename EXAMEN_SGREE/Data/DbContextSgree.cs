using SGREE.Models;
using System.Data.Entity;

namespace SGREE.Data
{
    public class DbContextSgree : DbContext
    {
        public DbContextSgree() : base("name=SgreeDbContext1")
        {
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Employeur> Employeurs { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<EmployeCompetence> EmployeCompetences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<EmployeurStats>();

            modelBuilder.Entity<Employe>().ToTable("Employes");
            modelBuilder.Entity<Employeur>().ToTable("Employeurs");
            modelBuilder.Entity<Departement>().ToTable("Departements");
            modelBuilder.Entity<Contrat>().ToTable("Contrats");
            modelBuilder.Entity<Competence>().ToTable("Competences");
            modelBuilder.Entity<EmployeCompetence>().ToTable("EmployeCompetences");

            // 🚫 Departement -> Employeur
            modelBuilder.Entity<Departement>()
                .HasRequired(d => d.Employeur)
                .WithMany()
                .HasForeignKey(d => d.EmployeurId)
                .WillCascadeOnDelete(false);

            // 🚫 Departement -> Responsable
            modelBuilder.Entity<Departement>()
                .HasOptional(d => d.Responsable)
                .WithMany()
                .HasForeignKey(d => d.ResponsableId)
                .WillCascadeOnDelete(false);

            // 🚫 Contrat -> Employeur
            modelBuilder.Entity<Contrat>()
                .HasRequired(c => c.Employeur)
                .WithMany()
                .HasForeignKey(c => c.EmployeurId)
                .WillCascadeOnDelete(false);

            // 🚫 Contrat -> Departement
            modelBuilder.Entity<Contrat>()
                .HasRequired(c => c.Departement)
                .WithMany()
                .HasForeignKey(c => c.DepartementId)
                .WillCascadeOnDelete(false);

            // 🚫 Contrat -> Employe
            modelBuilder.Entity<Contrat>()
                .HasRequired(c => c.Employe)
                .WithMany()
                .HasForeignKey(c => c.EmployeId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}