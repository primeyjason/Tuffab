using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuffab.Models;


namespace Tuffab.Controllers
{
    public class ImageController : Controller
    {

        private SiteDBContext db = new SiteDBContext(); 
        
        // GET: Image

        public ActionResult Show(int id)
        {
            var sitePicture = db.SitePictures.FirstOrDefault(pic => pic.ID == id);

            if (sitePicture == null)
            {
                return null;
            }
            else
                return File(sitePicture.Data, sitePicture.ContentType);
        }
    }
}