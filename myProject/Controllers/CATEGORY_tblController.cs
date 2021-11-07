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
    public class CATEGORY_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: CATEGORY_tbl
        public ActionResult Index()
        {
            var cATEGORY_tbl = db.CATEGORY_tbl.Include(c => c.SHOP_tbl);
            return View(cATEGORY_tbl.ToList());
        }

        // GET: CATEGORY_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY_tbl cATEGORY_tbl = db.CATEGORY_tbl.Find(id);
            if (cATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORY_tbl);
        }

        // GET: CATEGORY_tbl/Create
        public ActionResult Create()
        {
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME");
            return View();
        }

        // POST: CATEGORY_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CATEGORY_ID,CATEGORY_NAME,CRTEGORY_STATUS,SHOP_FID")] CATEGORY_tbl cATEGORY_tbl)
        {
            if (ModelState.IsValid)
            {
                db.CATEGORY_tbl.Add(cATEGORY_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", cATEGORY_tbl.SHOP_FID);
            return View(cATEGORY_tbl);
        }

        // GET: CATEGORY_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY_tbl cATEGORY_tbl = db.CATEGORY_tbl.Find(id);
            if (cATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", cATEGORY_tbl.SHOP_FID);
            return View(cATEGORY_tbl);
        }

        // POST: CATEGORY_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CATEGORY_ID,CATEGORY_NAME,CRTEGORY_STATUS,SHOP_FID")] CATEGORY_tbl cATEGORY_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cATEGORY_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", cATEGORY_tbl.SHOP_FID);
            return View(cATEGORY_tbl);
        }

        // GET: CATEGORY_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY_tbl cATEGORY_tbl = db.CATEGORY_tbl.Find(id);
            if (cATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORY_tbl);
        }

        // POST: CATEGORY_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CATEGORY_tbl cATEGORY_tbl = db.CATEGORY_tbl.Find(id);
            db.CATEGORY_tbl.Remove(cATEGORY_tbl);
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
