namespace WAT.Admin.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaxTableModification : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.Paxes");
            AddColumn("dbo.Paxes", "Apellido", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Paxes", "Nombre", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Paxes", "Email", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Paxes", "Telefono", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.Paxes", "FechaNacimiento", c => c.DateTime(nullable: false));
            AddColumn("dbo.Paxes", "Ciudad", c => c.Int(nullable: false));
            AddColumn("dbo.Paxes", "Universidad", c => c.Int(nullable: false));
            AddColumn("dbo.Paxes", "AceptaTerminos", c => c.Boolean(nullable: false));
            DropColumn("dbo.Paxes", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Paxes", "FirstName", c => c.String(maxLength: 150));
            DropColumn("dbo.Paxes", "AceptaTerminos");
            DropColumn("dbo.Paxes", "Universidad");
            DropColumn("dbo.Paxes", "Ciudad");
            DropColumn("dbo.Paxes", "FechaNacimiento");
            DropColumn("dbo.Paxes", "Telefono");
            DropColumn("dbo.Paxes", "Email");
            DropColumn("dbo.Paxes", "Nombre");
            DropColumn("dbo.Paxes", "Apellido");
        }
    }
}
