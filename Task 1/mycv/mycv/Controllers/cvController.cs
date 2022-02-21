using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mycv.Controllers
{
    public class cvController : Controller
    {
        // GET: cv
        

        public ActionResult index()
        {
            return View();
        }
        public ActionResult education()
        {
            return View();
        }

        public ActionResult project()
        {
            return View();
        }
        public ActionResult reference()
        {
            return View();
        }

    }
}