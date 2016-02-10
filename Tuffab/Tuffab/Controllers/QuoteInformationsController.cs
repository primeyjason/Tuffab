using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tuffab.Models;

namespace Tuffab.Controllers
{
    public class QuoteInformationsController : Controller
    {
        private SiteDBContext db = new SiteDBContext();

        // GET: QuoteInformations
        [HttpGet]
        public ActionResult Index()
        {
            return View(new QuoteInformation()); 
        }

        [HttpPost]
        public ActionResult Index(QuoteInformation quote)
        {
            //return View(db.QuoteInformations.ToList());

            if (ModelState.IsValid)
            {
                db.QuoteInformations.Add(quote); 
                db.SaveChanges();
                return RedirectToAction("ThankYou",  new { fullName = quote.FullName });
            }
            else
                return View(quote);

            
        }



        [HttpGet]
        public ActionResult ThankYou(string fullName)
        {
            ViewBag.FullName = fullName;
            return View("ThankYou"); 


        }


        /*
        // GET: QuoteInformations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuoteInformation quoteInformation = db.QuoteInformations.Find(id);
            if (quoteInformation == null)
            {
                return HttpNotFound();
            }
            return View(quoteInformation);
        }

        // GET: QuoteInformations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuoteInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FullName,Phone,Email,Description")] QuoteInformation quoteInformation)
        {
            if (ModelState.IsValid)
            {
                db.QuoteInformations.Add(quoteInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quoteInformation);
        }

        // GET: QuoteInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuoteInformation quoteInformation = db.QuoteInformations.Find(id);
            if (quoteInformation == null)
            {
                return HttpNotFound();
            }
            return View(quoteInformation);
        }

        // POST: QuoteInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FullName,Phone,Email,Description")] QuoteInformation quoteInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quoteInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quoteInformation);
        }

        // GET: QuoteInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuoteInformation quoteInformation = db.QuoteInformations.Find(id);
            if (quoteInformation == null)
            {
                return HttpNotFound();
            }
            return View(quoteInformation);
        }

        // POST: QuoteInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuoteInformation quoteInformation = db.QuoteInformations.Find(id);
            db.QuoteInformations.Remove(quoteInformation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    */
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
