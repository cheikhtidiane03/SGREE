namespace EXAMEN_SGREE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutUtilisateurs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 100),
                        Prenom = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 255),
                        MotDePasseHash = c.String(nullable: false, maxLength: 255),
                        Sel = c.String(nullable: false, maxLength: 255),
                        Role = c.String(maxLength: 50),
                        Actif = c.Boolean(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        DerniereConnexion = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Utilisateurs", new[] { "Email" });
            DropTable("dbo.Utilisateurs");
        }
    }
}
