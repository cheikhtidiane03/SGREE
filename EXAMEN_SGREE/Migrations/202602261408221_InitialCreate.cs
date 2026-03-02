namespace EXAMEN_SGREE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Categorie = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeCompetences",
                c => new
                    {
                        EmployeId = c.Int(nullable: false),
                        CompetenceId = c.Int(nullable: false),
                        Niveau = c.Int(nullable: false),
                        DateAcquisition = c.DateTime(nullable: false),
                        Certifie = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeId, t.CompetenceId })
                .ForeignKey("dbo.Competences", t => t.CompetenceId, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.EmployeId, cascadeDelete: true)
                .Index(t => t.EmployeId)
                .Index(t => t.CompetenceId);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        CNI = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        SituationMatrimoniale = c.Int(nullable: false),
                        NombreEnfants = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contrats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroContrat = c.String(),
                        TypeContrat = c.Int(nullable: false),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(),
                        SalaireBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeId = c.Int(nullable: false),
                        EmployeurId = c.Int(nullable: false),
                        DepartementId = c.Int(nullable: false),
                        Poste = c.String(),
                        Statut = c.Int(nullable: false),
                        MotifResiliation = c.String(),
                        Departement_Id = c.Int(),
                        Employeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departements", t => t.Departement_Id)
                .ForeignKey("dbo.Employeurs", t => t.Employeur_Id)
                .ForeignKey("dbo.Departements", t => t.DepartementId)
                .ForeignKey("dbo.Employes", t => t.EmployeId)
                .ForeignKey("dbo.Employeurs", t => t.EmployeurId)
                .Index(t => t.EmployeId)
                .Index(t => t.EmployeurId)
                .Index(t => t.DepartementId)
                .Index(t => t.Departement_Id)
                .Index(t => t.Employeur_Id);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Libelle = c.String(),
                        Description = c.String(),
                        EmployeurId = c.Int(nullable: false),
                        ResponsableId = c.Int(),
                        Employeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employeurs", t => t.Employeur_Id)
                .ForeignKey("dbo.Employeurs", t => t.EmployeurId)
                .ForeignKey("dbo.Employes", t => t.ResponsableId)
                .Index(t => t.EmployeurId)
                .Index(t => t.ResponsableId)
                .Index(t => t.Employeur_Id);
            
            CreateTable(
                "dbo.Employeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaisonSociale = c.String(),
                        NINEA = c.String(),
                        SecteurActivite = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                        Statut = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contrats", "EmployeurId", "dbo.Employeurs");
            DropForeignKey("dbo.Contrats", "EmployeId", "dbo.Employes");
            DropForeignKey("dbo.Contrats", "DepartementId", "dbo.Departements");
            DropForeignKey("dbo.Departements", "ResponsableId", "dbo.Employes");
            DropForeignKey("dbo.Departements", "EmployeurId", "dbo.Employeurs");
            DropForeignKey("dbo.Departements", "Employeur_Id", "dbo.Employeurs");
            DropForeignKey("dbo.Contrats", "Employeur_Id", "dbo.Employeurs");
            DropForeignKey("dbo.Contrats", "Departement_Id", "dbo.Departements");
            DropForeignKey("dbo.EmployeCompetences", "EmployeId", "dbo.Employes");
            DropForeignKey("dbo.EmployeCompetences", "CompetenceId", "dbo.Competences");
            DropIndex("dbo.Departements", new[] { "Employeur_Id" });
            DropIndex("dbo.Departements", new[] { "ResponsableId" });
            DropIndex("dbo.Departements", new[] { "EmployeurId" });
            DropIndex("dbo.Contrats", new[] { "Employeur_Id" });
            DropIndex("dbo.Contrats", new[] { "Departement_Id" });
            DropIndex("dbo.Contrats", new[] { "DepartementId" });
            DropIndex("dbo.Contrats", new[] { "EmployeurId" });
            DropIndex("dbo.Contrats", new[] { "EmployeId" });
            DropIndex("dbo.EmployeCompetences", new[] { "CompetenceId" });
            DropIndex("dbo.EmployeCompetences", new[] { "EmployeId" });
            DropTable("dbo.Employeurs");
            DropTable("dbo.Departements");
            DropTable("dbo.Contrats");
            DropTable("dbo.Employes");
            DropTable("dbo.EmployeCompetences");
            DropTable("dbo.Competences");
        }
    }
}
