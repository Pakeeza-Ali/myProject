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
    public class SHP_CATEGORY_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: SHP_CATEGORY_tbl
        public ActionResult Index()
        {
            return View(db.SHP_CATEGORY_tbl.ToList());
        }

        // GET: SHP_CATEGORY_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHP_CATEGORY_tbl sHP_CATEGORY_tbl = db.SHP_CATEGORY_tbl.Find(id);
            if (sHP_CATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHP_CATEGORY_tbl);
        }

        // GET: SHP_CATEGORY_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SHP_CATEGORY_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SHP_CATEGORY_tbl sHP_CATEGORY_tbl, HttpPostedFileBase icon)
        {
            if (icon != null)
            {
                string fullpath = Server.MapPath("~/Content/ProjectImages/" + icon.FileName);
                icon.SaveAs(fullpath);
                sHP_CATEGORY_tbl.SHP_CATEGORY_ICON = "~/Content/ProjectImages/" + icon.FileName;
            }
            if (ModelState.IsValid)
            {
                db.SHP_CATEGORY_tbl.Add(sHP_CATEGORY_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sHP_CATEGORY_tbl);
        }

        // GET: SHP_CATEGORY_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHP_CATEGORY_tbl sHP_CATEGORY_tbl = db.SHP_CATEGORY_tbl.Find(id);
            if (sHP_CATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHP_CATEGORY_tbl);
        }

        // POST: SHP_CATEGORY_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SHP_CATEGORY_tbl sHP_CATEGORY_tbl,HttpPostedFileBase icon)
        {
            if (icon != null)
            {
                string fullpath = Server.MapPath("~/Content/ProjectImages/" + icon.FileName);
                icon.SaveAs(fullpath);
                sHP_CATEGORY_tbl.SHP_CATEGORY_ICON = "~/Content/ProjectImages/" + icon.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Entry(sHP_CATEGORY_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sHP_CATEGORY_tbl);
        }

        // GET: SHP_CATEGORY_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHP_CATEGORY_tbl sHP_CATEGORY_tbl = db.SHP_CATEGORY_tbl.Find(id);
            if (sHP_CATEGORY_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHP_CATEGORY_tbl);
        }

        // POST: SHP_CATEGORY_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SHP_CATEGORY_tbl sHP_CATEGORY_tbl = db.SHP_CATEGORY_tbl.Find(id);
            db.SHP_CATEGORY_tbl.Remove(sHP_CATEGORY_tbl);
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
