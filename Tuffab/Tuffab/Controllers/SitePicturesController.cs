using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tuffab.Models;
using TuffabLibrary.CustomUI.Attributes; 

namespace Tuffab.Controllers
{
    public class SitePicturesController : Controller
    {
        private SiteDBContext db = new SiteDBContext();  
            


        public SitePicturesController() : base()
        {
            
        }

        // GET: SitePictures
        [AdminOnlyAuthorize]
        public ActionResult Index()
        {
            return View(db.SitePictures.ToList());
        }

        // GET: SitePictures/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SitePicture sitePicture = db.SitePictures.Find(id);
            if (sitePicture == null)
            {
                return HttpNotFound();
            }
            return View(sitePicture);
        }

        // GET: SitePictures/Create
        public ActionResult Create()
        {
            return View(new SitePicture());
        }

        // POST: SitePictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Data,Caption,Width,Height,Filename,ContentType")] SitePicture sitePicture, HttpPostedFileBase file)
        {

            sitePicture.ContentType = file.ContentType;
            sitePicture.Filename = file.FileName;

            if (!ModelState.IsValidField("Data"))
            {
                ModelState["Data"].Errors.Clear();
                byte[] img = new byte[file.ContentLength];
                int byteCount = file.InputStream.Read(img, 0, img.Length);
                sitePicture.Data = img;
                if (!TryValidateModel(sitePicture))
                {
                    return View(sitePicture);
                }
            }

            
            if (ModelState.IsValid)
            {

                db.SitePictures.Add(sitePicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sitePicture);
            

        }

        // GET: SitePictures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SitePicture sitePicture = db.SitePictures.Find(id);
            if (sitePicture == null)
            {
                return HttpNotFound();
            }
            return View(sitePicture);
            
        }

        // POST: SitePictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Data,Caption")] SitePicture sitePicture)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(sitePicture).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(sitePicture);
        //}

        // GET: SitePictures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SitePicture sitePicture = db.SitePictures.Find(id);
            if (sitePicture == null)
            {
                return HttpNotFound();
            }
            return View(sitePicture);
        }

        // POST: SitePictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SitePicture sitePicture = db.SitePictures.Find(id);
            db.SitePictures.Remove(sitePicture);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
