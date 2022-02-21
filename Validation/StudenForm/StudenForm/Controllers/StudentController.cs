using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudenForm.Models;

namespace StudenForm.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("List","Product");

            }
            return View(s);
        }

        [HttpPost]
        public ActionResult Submit()
        {
            Student s = new Student();
            s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.Dob = Request["Dob"];
            s.Email = Request["Email"];


            return View(s);
        }
    }
}