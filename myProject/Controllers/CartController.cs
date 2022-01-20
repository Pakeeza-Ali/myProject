using System;
using myProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myProject.Controllers
{
    public class CartController : Controller
    {
        Model1 db = new Model1();
        // GET: Cart
        public ActionResult BuyNow(int id)
        {
            List<PRODUCT_tbl> CartList = new List<PRODUCT_tbl>();
            if (Session["cart"] != null)
            {
                CartList = (List<PRODUCT_tbl>)Session["cart"];
            }
            PRODUCT_tbl pRODUCT_tbl = db.PRODUCT_tbl.Where(x => x.PRODUCT_ID == id).FirstOrDefault();
            CartList.Add(pRODUCT_tbl);
            Session["cart"] = CartList;

            return RedirectToAction("DisplayCart");
        }
        public ActionResult DisplayCart()
        {
            return View();
        }
        public ActionResult RemoveFromCart(int id)
        {
            List<PRODUCT_tbl> list = new List<PRODUCT_tbl>();
            list = (List<PRODUCT_tbl>)Session["cart"];
            list.RemoveAt(id);
            Session["cart"] = list;
            return RedirectToAction("Displaycart");
        }
        public ActionResult PlustoCart(int id)
        {
            List<PRODUCT_tbl> list = new List<PRODUCT_tbl>();
            list = (List<PRODUCT_tbl>)Session["cart"];
            list[id].Quantity++;
            Session["cart"] = list;
            return RedirectToAction("Displaycart");
        }
        public ActionResult MinusFromCart(int id)
        {
            List<PRODUCT_tbl> list = new List<PRODUCT_tbl>();
            list = (List<PRODUCT_tbl>)Session["cart"];
            list[id].Quantity--;
            Session["cart"] = list;
            return RedirectToAction("Displaycart");
        }
    }
}