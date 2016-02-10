namespace Tuffab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsForSitePicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SitePictures", "Filename", c => c.String());
            AddColumn("dbo.SitePictures", "ContentType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SitePictures", "ContentType");
            DropColumn("dbo.SitePictures", "Filename");
        }

        
    }
}
