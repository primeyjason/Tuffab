namespace Tuffab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SitePictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Data = c.Binary(nullable: false),
                        Caption = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SitePictures");
        }
    }
}
