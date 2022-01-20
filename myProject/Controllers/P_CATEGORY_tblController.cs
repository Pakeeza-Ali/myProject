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
    public class P_CATEGORY_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: CATEGORY_tbl
        public ActionResult Index()
        {
            var cATEGORY_tbl = db.P_CATEGORY_tbl.Include(c => c.SHOP_tbl);
            return View(cATEGORY_tbl.ToList());
        }

        // GET: CATEGORY_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            P_CATEGORY_tbl cATEGORY_tbl = db.P_CATEGORY_tbl.Find(id);
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
        public ActionResult Create(P_CATEGORY_tbl cATEGORY_tbl, HttpPostedFileBase pro_icon)
        {
            if (pro_icon != null)
            {
                string fullpath = Server.MapPath("~/Content/ProjectImages/" + pro_icon.FileName);
                pro_icon.SaveAs(fullpath);
                cATEGORY_tbl.P_CATEGORY_ICON = "~/Content/ProjectImages/" + pro_icon.FileName;
            }
            if (ModelState.IsValid)
            {
                db.P_CATEGORY_tbl.Add(cATEGORY_tbl);
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
            P_CATEGORY_tbl cATEGORY_tbl = db.P_CATEGORY_tbl.Find(id);
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
        public ActionResult Edit(P_CATEGORY_tbl cATEGORY_tbl, HttpPostedFileBase pic)
        {
            if (pic != null)
            {
                string fullpath = Server.MapPath("~/Content/ProjectImages/" + pic.FileName);
                pic.SaveAs(fullpath);
                cATEGORY_tbl.P_CATEGORY_ICON = "~/Content/ProjectImages/" + pic.FileName;
            }
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
            P_CATEGORY_tbl cATEGORY_tbl = db.P_CATEGORY_tbl.Find(id);
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
            P_CATEGORY_tbl cATEGORY_tbl = db.P_CATEGORY_tbl.Find(id);
            db.P_CATEGORY_tbl.Remove(cATEGORY_tbl);
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
