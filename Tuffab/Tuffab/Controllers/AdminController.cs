using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Tuffab.Controllers
{


    public class SessionState: HttpSessionStateBase
    {
        public override HttpCookieMode CookieMode
        {
            get
            {
                return HttpCookieMode.UseDeviceProfile;
            }
        }

        public override void Add(string name, object value)
        {
            base.Add(name, value);
        }

        public override void Clear()
        {
            base.Clear();
        }

        public override SessionStateMode Mode
        {
            get
            {
                return SessionStateMode.InProc; 
            }
        }

    }

    [RequireHttps]
    public class AdminController : Controller
    {

        private SessionState SessionState = new SessionState();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        // GET: Admin
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            Session.Add("Administrator", true);
            ViewBag.Administrator = "Yes";
            //ViewData["Administrator"] = "Yes";
            
            return RedirectToAction("Index", "Home");

            
        }


        // GET: Admin
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("Administrator");

            return RedirectToAction("Index", "Home");


        }
    }
}