namespace SistemaWebClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        MedicoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Matricula = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.MedicoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicos");
        }
    }
}
