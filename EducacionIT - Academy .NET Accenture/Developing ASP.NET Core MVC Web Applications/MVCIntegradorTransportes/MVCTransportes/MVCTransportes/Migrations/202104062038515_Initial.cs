namespace MVCTransportes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autoes",
                c => new
                    {
                        AutoID = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        Matricula = c.String(nullable: false),
                        Caracteristicas = c.String(nullable: false),
                        Chofer_ChoferID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AutoID)
                .ForeignKey("dbo.Chofers", t => t.Chofer_ChoferID, cascadeDelete: true)
                .Index(t => t.Chofer_ChoferID);
            
            CreateTable(
                "dbo.Chofers",
                c => new
                    {
                        ChoferID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        DNI = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Ciudad = c.String(nullable: false),
                        NroRegistro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChoferID);
            
            CreateTable(
                "dbo.Camions",
                c => new
                    {
                        CamionID = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        Matricula = c.String(nullable: false),
                        Caracteristicas = c.String(nullable: false),
                        Chofer_ChoferID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CamionID)
                .ForeignKey("dbo.Chofers", t => t.Chofer_ChoferID, cascadeDelete: true)
                .Index(t => t.Chofer_ChoferID);
            
            CreateTable(
                "dbo.Camionetas",
                c => new
                    {
                        CamionetaID = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false),
                        Modelo = c.String(nullable: false),
                        Matricula = c.String(nullable: false),
                        Caracteristicas = c.String(nullable: false),
                        Chofer_ChoferID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CamionetaID)
                .ForeignKey("dbo.Chofers", t => t.Chofer_ChoferID, cascadeDelete: true)
                .Index(t => t.Chofer_ChoferID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Camionetas", "Chofer_ChoferID", "dbo.Chofers");
            DropForeignKey("dbo.Camions", "Chofer_ChoferID", "dbo.Chofers");
            DropForeignKey("dbo.Autoes", "Chofer_ChoferID", "dbo.Chofers");
            DropIndex("dbo.Camionetas", new[] { "Chofer_ChoferID" });
            DropIndex("dbo.Camions", new[] { "Chofer_ChoferID" });
            DropIndex("dbo.Autoes", new[] { "Chofer_ChoferID" });
            DropTable("dbo.Camionetas");
            DropTable("dbo.Camions");
            DropTable("dbo.Chofers");
            DropTable("dbo.Autoes");
        }
    }
}
