namespace SistemaWebClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixInitial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicos", "Especialidad", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Medicos", "Ciudad", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicos", "Ciudad");
            DropColumn("dbo.Medicos", "Especialidad");
        }
    }
}
