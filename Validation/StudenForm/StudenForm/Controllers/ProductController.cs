using StudenForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudenForm.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            /*ViewBag.Name = "Samsung";
            ViewBag.ID = "579";
            return View();*/

            Sstudent s = new Sstudent();
            s.Name = "Tasneem";
            s.Id = 40416;
            s.Dob = "12-12-2021";
            s.Email="tasneem@gmail.com"
;            return View(s);
        }

        public ActionResult List()
        {
            List<Sstudent> students = new List<Sstudent>();
            for (int i=0;i<100;i++)
            {
                var s = new Sstudent
                {
                    Name = "Sstudent" + (i + 1),
                    Id = i + 1,
                    Dob = "Sstudent" + (i + 1),
                    Email = "Sstudent" + (i + 1),
                };
                students.Add(s);


            }
            return View(students);
        }
    }
}