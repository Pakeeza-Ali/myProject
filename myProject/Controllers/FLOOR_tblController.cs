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
    public class FLOOR_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: FLOOR_tbl
        public ActionResult Index()
        {
            return View(db.FLOOR_tbl.ToList());
        }

        // GET: FLOOR_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FLOOR_tbl fLOOR_tbl = db.FLOOR_tbl.Find(id);
            if (fLOOR_tbl == null)
            {
                return HttpNotFound();
            }
            return View(fLOOR_tbl);
        }

        // GET: FLOOR_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FLOOR_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FLOOR_ID,FLOOR_NAME")] FLOOR_tbl fLOOR_tbl)
        {
            if (ModelState.IsValid)
            {
                db.FLOOR_tbl.Add(fLOOR_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fLOOR_tbl);
        }

        // GET: FLOOR_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FLOOR_tbl fLOOR_tbl = db.FLOOR_tbl.Find(id);
            if (fLOOR_tbl == null)
            {
                return HttpNotFound();
            }
            return View(fLOOR_tbl);
        }

        // POST: FLOOR_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FLOOR_ID,FLOOR_NAME")] FLOOR_tbl fLOOR_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fLOOR_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fLOOR_tbl);
        }

        // GET: FLOOR_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FLOOR_tbl fLOOR_tbl = db.FLOOR_tbl.Find(id);
            if (fLOOR_tbl == null)
            {
                return HttpNotFound();
            }
            return View(fLOOR_tbl);
        }

        // POST: FLOOR_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FLOOR_tbl fLOOR_tbl = db.FLOOR_tbl.Find(id);
            db.FLOOR_tbl.Remove(fLOOR_tbl);
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
