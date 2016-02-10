namespace Tuffab.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;
    using System.IO;


    internal sealed class Configuration : DbMigrationsConfiguration<Tuffab.Models.SiteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Tuffab.Models.SiteDBContext";
        }

        protected override void Seed(Tuffab.Models.SiteDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
      //      if (System.Diagnostics.Debugger.IsAttached == false)
        //        System.Diagnostics.Debugger.Launch();

            try
            {
           //     var imgPath = Path.Combine(HttpRuntime.AppDomainAppPath, "Images", "image1.jpg");


                
                /*context.SitePictures.Add(
                    new Models.SitePicture()
                    {
                        Caption = "Image 1",
                        Data = File.ReadAllBytes(imgPath),
                        Width = 640,
                        Height = 480
                    }
                    );*/
            }
            catch(Exception e)
            {

            }


        }
    }
}
