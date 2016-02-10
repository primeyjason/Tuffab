using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuffab.Models; 

namespace Tuffab.Controllers
{
    public class HomeController : Controller
    {


        private SiteDBContext db = new SiteDBContext(); 
        public ActionResult Index()
        {
            return View(db.SitePictures.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.x = 5;
            Session.Add("Administrator", false); 
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact details";

            return View();
        }
    }
}