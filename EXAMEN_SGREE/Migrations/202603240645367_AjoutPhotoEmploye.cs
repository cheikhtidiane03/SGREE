namespace EXAMEN_SGREE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutPhotoEmploye : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "Photo", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employes", "Photo");
        }
    }
}
