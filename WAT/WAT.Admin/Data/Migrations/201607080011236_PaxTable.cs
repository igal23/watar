namespace WAT.Admin.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaxTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paxes",
                c => new
                    {
                        PaxId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.PaxId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Paxes");
        }
    }
}
