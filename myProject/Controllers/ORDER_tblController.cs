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
    public class ORDER_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: ORDER_tbl
        public ActionResult Index()
        {
            var oRDER_tbl = db.ORDER_tbl.Include(o => o.CUSTOMER_tbl).Include(o => o.SHOP_tbl);
            return View(oRDER_tbl.ToList());
        }

        // GET: ORDER_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDER_tbl oRDER_tbl = db.ORDER_tbl.Find(id);
            if (oRDER_tbl == null)
            {
                return HttpNotFound();
            }
            return View(oRDER_tbl);
        }

        // GET: ORDER_tbl/Create
        public ActionResult Create()
        {
            ViewBag.CUSTOMER_FID = new SelectList(db.CUSTOMER_tbl, "CUSTOMER_ID", "CUSTOMER_NAME");
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME");
            return View();
        }

        // POST: ORDER_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ORDER_ID,ORDER_DATE,SHOP_FID,CUSTOMER_FID,ORDER_STATUS,PAYMENT_MODE")] ORDER_tbl oRDER_tbl)
        {
            if (ModelState.IsValid)
            {
                db.ORDER_tbl.Add(oRDER_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CUSTOMER_FID = new SelectList(db.CUSTOMER_tbl, "CUSTOMER_ID", "CUSTOMER_NAME", oRDER_tbl.CUSTOMER_FID);
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", oRDER_tbl.SHOP_FID);
            return View(oRDER_tbl);
        }

        // GET: ORDER_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDER_tbl oRDER_tbl = db.ORDER_tbl.Find(id);
            if (oRDER_tbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.CUSTOMER_FID = new SelectList(db.CUSTOMER_tbl, "CUSTOMER_ID", "CUSTOMER_NAME", oRDER_tbl.CUSTOMER_FID);
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", oRDER_tbl.SHOP_FID);
            return View(oRDER_tbl);
        }

        // POST: ORDER_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ORDER_ID,ORDER_DATE,SHOP_FID,CUSTOMER_FID,ORDER_STATUS,PAYMENT_MODE")] ORDER_tbl oRDER_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oRDER_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CUSTOMER_FID = new SelectList(db.CUSTOMER_tbl, "CUSTOMER_ID", "CUSTOMER_NAME", oRDER_tbl.CUSTOMER_FID);
            ViewBag.SHOP_FID = new SelectList(db.SHOP_tbl, "SHOP_ID", "SHOP_NAME", oRDER_tbl.SHOP_FID);
            return View(oRDER_tbl);
        }

        // GET: ORDER_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORDER_tbl oRDER_tbl = db.ORDER_tbl.Find(id);
            if (oRDER_tbl == null)
            {
                return HttpNotFound();
            }
            return View(oRDER_tbl);
        }

        // POST: ORDER_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ORDER_tbl oRDER_tbl = db.ORDER_tbl.Find(id);
            db.ORDER_tbl.Remove(oRDER_tbl);
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
