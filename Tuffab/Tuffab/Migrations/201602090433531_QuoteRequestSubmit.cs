namespace Tuffab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteRequestSubmit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuoteInformations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuoteInformations");
        }
    }
}
