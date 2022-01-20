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
    public class PRODUCT_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRODUCT_tbl
        public ActionResult Index()
        {
            var pRODUCT_tbl = db.PRODUCT_tbl.Include(p => p.P_CATEGORY_tbl);
            return View(pRODUCT_tbl.ToList());
        }

        // GET: PRODUCT_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_tbl pRODUCT_tbl = db.PRODUCT_tbl.Find(id);
            if (pRODUCT_tbl == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_tbl);
        }

        // GET: PRODUCT_tbl/Create
        public ActionResult Create()
        {
            ViewBag.P_CATEGORY_FID = new SelectList(db.P_CATEGORY_tbl, "P_CATEGORY_ID", "P_CATEGORY_NAME");
            return View();
        }

        // POST: PRODUCT_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PRODUCT_tbl pRODUCT_tbl,HttpPostedFileBase imag)
        {
            string fullpath=Server.MapPath("~/Content/ProjectImages/"+imag.FileName);
            imag.SaveAs(fullpath);
            pRODUCT_tbl.PRODUCT_IMAGE = "~/Content/ProjectImages/" + imag.FileName;

            if (ModelState.IsValid)
            {
                db.PRODUCT_tbl.Add(pRODUCT_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.P_CATEGORY_FID = new SelectList(db.P_CATEGORY_tbl, "P_CATEGORY_ID", "P_CATEGORY_NAME", pRODUCT_tbl.P_CATEGORY_FID);
            return View(pRODUCT_tbl);
        }

        // GET: PRODUCT_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_tbl pRODUCT_tbl = db.PRODUCT_tbl.Find(id);
            if (pRODUCT_tbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.CATEGORY_FID = new SelectList(db.P_CATEGORY_tbl, "P_CATEGORY_ID", "P_CATEGORY_NAME", pRODUCT_tbl.P_CATEGORY_FID);
            return View(pRODUCT_tbl);
        }

        // POST: PRODUCT_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PRODUCT_tbl pRODUCT_tbl, HttpPostedFileBase imag)
        { 
            if (imag != null)
            {
                string fullpath = Server.MapPath("~/Content/ProjectImages/" + imag.FileName);
                imag.SaveAs(fullpath);
                pRODUCT_tbl.PRODUCT_IMAGE = "~/Content/ProjectImages/" + imag.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Entry(pRODUCT_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.P_CATEGORY_FID = new SelectList(db.P_CATEGORY_tbl, "P_CATEGORY_ID", "P_CATEGORY_NAME", pRODUCT_tbl.P_CATEGORY_FID);
            return View(pRODUCT_tbl);
        }

        // GET: PRODUCT_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_tbl pRODUCT_tbl = db.PRODUCT_tbl.Find(id);
            if (pRODUCT_tbl == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_tbl);
        }

        // POST: PRODUCT_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCT_tbl pRODUCT_tbl = db.PRODUCT_tbl.Find(id);
            db.PRODUCT_tbl.Remove(pRODUCT_tbl);
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
