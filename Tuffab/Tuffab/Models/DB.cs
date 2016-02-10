using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Tuffab.Models
{
    

    public class SiteDBContext : DbContext
    {
        public SiteDBContext() : base((string)ConfigurationManager.ConnectionStrings["Tuffab"].ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SiteDBContext, Tuffab.Migrations.Configuration>());
        }
        public DbSet<SitePicture> SitePictures { get; set; }

        public System.Data.Entity.DbSet<Tuffab.Models.QuoteInformation> QuoteInformations { get; set; }
    }
}
