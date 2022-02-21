using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsTask.Models.DataBase;


namespace NewsTask.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            News_DBEntities db = new News_DBEntities();
            var data = db.News.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new News());
        }

        [HttpPost]
        public ActionResult Create(News n)
        {

            if (ModelState.IsValid)
            {
                News_DBEntities db = new News_DBEntities();
                db.News.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            News_DBEntities db = new News_DBEntities();

            var news = (from n in db.News
                        where n.Id == id
                        select n).FirstOrDefault();
            return View(news);
        }

        [HttpPost]
        public ActionResult Edit(News ne)
        {
            News_DBEntities db = new News_DBEntities();

            var news = (from n in db.News
                        where n.Id == ne.Id
                        select n).FirstOrDefault();
            db.Entry(news).CurrentValues.SetValues(ne);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            News_DBEntities db = new News_DBEntities();

            var news = (from n in db.News
                        where n.Id == id
                        select n).FirstOrDefault();
            return View(news);
        }

        [HttpPost]
        public ActionResult Delete(News ne)

        {
            News_DBEntities db = new News_DBEntities();

            var news = (from n in db.News
                        where n.Id == ne.Id
                        select n).FirstOrDefault();
            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
