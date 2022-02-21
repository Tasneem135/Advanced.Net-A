using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myProduct.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Home()
        {
            ViewBag.Name = "Samsung";
            ViewBag.ID = "579";
            return View();
        }
        public ActionResult List()
        {
            string[] names = { "Samsung", "Apple", "Huawei", "Nokia", "Xiaomi", "OPPO", "Vivo","OnePlus","Lenovo","ASUS" };
            ViewBag.Names = names;
            return View();
        }
    }
}