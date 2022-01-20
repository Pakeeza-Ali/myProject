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
    public class SHOP_tblController : Controller
    {
        private Model1 db = new Model1();

        // GET: SHOP_tbl
        public ActionResult Index()
        {
            var sHOP_tbl = db.SHOP_tbl.Include(s => s.CITY_tbl).Include(s => s.SHP_CATEGORY_tbl).Include(s => s.SHOPKEEPER_tbl);
            return View(sHOP_tbl.ToList());
        }

        // GET: SHOP_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOP_tbl sHOP_tbl = db.SHOP_tbl.Find(id);
            if (sHOP_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHOP_tbl);
        }

        // GET: SHOP_tbl/Create
        public ActionResult Create()
        {
            ViewBag.CITY_FID = new SelectList(db.CITY_tbl, "CITY_ID", "CITY_NAME");
            ViewBag.SHP_CATEGORY_FID = new SelectList(db.SHP_CATEGORY_tbl, "SHP_CATEGORY_ID", "SHP_CATEGORY_NAME", "SHP_CATEGORY_STATUS");
            ViewBag.SHOPKEEPER_FID = new SelectList(db.SHOPKEEPER_tbl, "SHOPKEEPER_ID", "SHOPKEEPER_NAME");
            return View();
        }

        // POST: SHOP_tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( SHOP_tbl sHOP_tbl, HttpPostedFileBase pic)
        {
                string path = Server.MapPath("~/Content/ProjectImages/" + pic.FileName);
                pic.SaveAs(path);
                sHOP_tbl.SHOP_IMAGE = "~/Content/ProjectImages/" + pic.FileName;
            

            if (ModelState.IsValid)
            {
                db.SHOP_tbl.Add(sHOP_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CITY_FID = new SelectList(db.CITY_tbl, "CITY_ID", "CITY_NAME", sHOP_tbl.CITY_FID);
            ViewBag.SHP_CATEGORY_FID = new SelectList(db.SHP_CATEGORY_tbl, "SHP_CATEGORY_ID", "SHP_CATEGORY_NAME", "SHP_CATEGORY_STATUS", sHOP_tbl.SHP_CATEGORY_FID);
            ViewBag.SHOPKEEPER_FID = new SelectList(db.SHOPKEEPER_tbl, "SHOPKEEPER_ID", "SHOPKEEPER_NAME", sHOP_tbl.SHOPKEEPER_FID);
            return View(sHOP_tbl);
        }

        // GET: SHOP_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOP_tbl sHOP_tbl = db.SHOP_tbl.Find(id);
            if (sHOP_tbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.CITY_FID = new SelectList(db.CITY_tbl, "CITY_ID", "CITY_NAME", sHOP_tbl.CITY_FID);
            ViewBag.FLOOR_FID = new SelectList(db.SHP_CATEGORY_tbl, "FLOOR_ID", "FLOOR_NAME", sHOP_tbl.SHP_CATEGORY_FID);
            ViewBag.SHOPKEEPER_FID = new SelectList(db.SHOPKEEPER_tbl, "SHOPKEEPER_ID", "SHOPKEEPER_NAME", sHOP_tbl.SHOPKEEPER_FID);
            return View(sHOP_tbl);
        }

        // POST: SHOP_tbl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SHOP_tbl sHOP_tbl, HttpPostedFileBase pic)
        {
            if (pic != null)
            {
                string path = Server.MapPath("~/Content/ProjectImages/" + pic.FileName);
                pic.SaveAs(path);
                sHOP_tbl.SHOP_IMAGE = "~/Content/ProjectImages/" + pic.FileName;
            }

            if (ModelState.IsValid)
            {
                db.Entry(sHOP_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CITY_FID = new SelectList(db.CITY_tbl, "CITY_ID", "CITY_NAME", sHOP_tbl.CITY_FID);
            ViewBag.FLOOR_FID = new SelectList(db.SHP_CATEGORY_tbl, "SHP_CATEGORY_ID", "SHP_CATEGORY_NAME", "SHP_CATEGORY_ICON", "SHP_CATEGORY_STATUS", sHOP_tbl.SHP_CATEGORY_FID);
            ViewBag.SHOPKEEPER_FID = new SelectList(db.SHOPKEEPER_tbl, "SHOPKEEPER_ID", "SHOPKEEPER_NAME", sHOP_tbl.SHOPKEEPER_FID);
            return View(sHOP_tbl);
        }

        // GET: SHOP_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SHOP_tbl sHOP_tbl = db.SHOP_tbl.Find(id);
            if (sHOP_tbl == null)
            {
                return HttpNotFound();
            }
            return View(sHOP_tbl);
        }

        // POST: SHOP_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SHOP_tbl sHOP_tbl = db.SHOP_tbl.Find(id);
            db.SHOP_tbl.Remove(sHOP_tbl);
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
