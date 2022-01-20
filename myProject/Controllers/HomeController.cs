using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myProject.Models;

namespace myProject.Controllers

{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult IndexCustomer()
        {
            return View();
        }
        public ActionResult IndexAdmin()
        {
            return View();
        }
        public ActionResult IndexShopkeeper()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Shops(int? id)
        {

            if (id != null)
            {
                ViewData["catid"] = id;
            }

            return View();
        }
        public ActionResult Product(int? id)
        {
           // ViewBag.Message = "Your application description page.";
            if(id!=null)
            {
                ViewData["catid"] = id;
            }
            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

        public ActionResult LoginAdmin()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult LoginAdmin(ADMIN_tbl a)
        {
            int result = db.ADMIN_tbl.Where(x=>x.ADMIN_EMAIL ==a.ADMIN_EMAIL && x.ADMIN_PASSWORD==a.ADMIN_PASSWORD).Count();
            if (result > 0)
            {
                return RedirectToAction("IndexAdmin");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email and Password";

                return View();
            }
           
        }
        public ActionResult LoginShopkeeper()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult LoginShopkeeper(SHOPKEEPER_tbl s)
        {
            int result = db.SHOPKEEPER_tbl.Where(x=>x.SHOPKEEPER_EMAIL == s.SHOPKEEPER_EMAIL && x.SHOPKEEPER_PASSWORD== s.SHOPKEEPER_PASSWORD).Count();
            if (result > 0)
            {
                return RedirectToAction("IndexShopkeeper","home");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email and Password";

                return View();
            }
           
        }
    }
}