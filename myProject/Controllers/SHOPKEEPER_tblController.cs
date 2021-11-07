using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myProject.Models;

namespace myProject.Controllers
{
    public class SHOPKEEPER_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: SHOPKEEPER_tbl
        public ActionResult Index()
        {
            return View(db.SHOPKEEPER_tbl.ToList());
        }

        // GET: SHOPKEEPER_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOPKEEPER_tbl sHOPKEEPER_tbl = db.SHOPKEEPER_tbl.Find(id);
            if (sHOPKEEPER_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHOPKEEPER_tbl);
        }

        // GET: SHOPKEEPER_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SHOPKEEPER_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SHOPKEEPER_ID,SHOPKEEPER_NAME,SHOPKEEPER_CONTACT,SHOPKEEPER_CNIC,SHOPKEEPER_EMAIL,SHOPKEEPER_PASSWORD,SHOPKEEPER_ADDRESS")] SHOPKEEPER_tbl sHOPKEEPER_tbl)
        {
            if (ModelState.IsValid)
            {
                db.SHOPKEEPER_tbl.Add(sHOPKEEPER_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sHOPKEEPER_tbl);
        }

        // GET: SHOPKEEPER_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOPKEEPER_tbl sHOPKEEPER_tbl = db.SHOPKEEPER_tbl.Find(id);
            if (sHOPKEEPER_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHOPKEEPER_tbl);
        }

        // POST: SHOPKEEPER_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SHOPKEEPER_ID,SHOPKEEPER_NAME,SHOPKEEPER_CONTACT,SHOPKEEPER_CNIC,SHOPKEEPER_EMAIL,SHOPKEEPER_PASSWORD,SHOPKEEPER_ADDRESS")] SHOPKEEPER_tbl sHOPKEEPER_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sHOPKEEPER_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sHOPKEEPER_tbl);
        }

        // GET: SHOPKEEPER_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOPKEEPER_tbl sHOPKEEPER_tbl = db.SHOPKEEPER_tbl.Find(id);
            if (sHOPKEEPER_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHOPKEEPER_tbl);
        }

        // POST: SHOPKEEPER_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SHOPKEEPER_tbl sHOPKEEPER_tbl = db.SHOPKEEPER_tbl.Find(id);
            db.SHOPKEEPER_tbl.Remove(sHOPKEEPER_tbl);
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
