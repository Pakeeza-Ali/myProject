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
        public ActionResult LoginAdmin(string email,string password)
        {
            int result = db.ADMIN_tbl.Where(x=>x.ADMIN_EMAIL ==email && x.ADMIN_PASSWORD==password).Count();
            if (result > 0)
            {
                return RedirectToAction("IndexAdmin");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email and Password";

                return View();
            }
            return View();
        }
    }
}