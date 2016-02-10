namespace Tuffab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SitePictures", "Width", c => c.Int(nullable: false));
            AddColumn("dbo.SitePictures", "Height", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SitePictures", "Height");
            DropColumn("dbo.SitePictures", "Width");
        }
    }
}
