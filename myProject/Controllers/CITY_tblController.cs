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
    public class CITY_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: CITY_tbl
        public ActionResult Index()
        {
            return View(db.CITY_tbl.ToList());
        }

        // GET: CITY_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CITY_tbl cITY_tbl = db.CITY_tbl.Find(id);
            if (cITY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(cITY_tbl);
        }

        // GET: CITY_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CITY_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CITY_ID,CITY_NAME,POSTAL_CODE")] CITY_tbl cITY_tbl)
        {
            if (ModelState.IsValid)
            {
                db.CITY_tbl.Add(cITY_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cITY_tbl);
        }

        // GET: CITY_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CITY_tbl cITY_tbl = db.CITY_tbl.Find(id);
            if (cITY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(cITY_tbl);
        }

        // POST: CITY_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CITY_ID,CITY_NAME,POSTAL_CODE")] CITY_tbl cITY_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cITY_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cITY_tbl);
        }

        // GET: CITY_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CITY_tbl cITY_tbl = db.CITY_tbl.Find(id);
            if (cITY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(cITY_tbl);
        }

        // POST: CITY_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CITY_tbl cITY_tbl = db.CITY_tbl.Find(id);
            db.CITY_tbl.Remove(cITY_tbl);
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
