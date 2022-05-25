using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTCV.Models.ENTITY;
using MTCV.Repositories;

namespace MTCV.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education

        GenericRepository<Education> repo = new GenericRepository<Education>();
        public ActionResult Index()
        {
            var education = repo.List();
            return View(education);
        }
        public ActionResult EducationRemove(int id)
        {
            var silinecek = repo.Find(x=>x.ID==id);
            repo.TDelete(silinecek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EducationAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EducationAdd(Education p)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("EducationAdd");
            //}
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EducationUpdate(int id)
        {
            Education edu = repo.Find(x=>x.ID==id);
            return View(edu);
        }
        [HttpPost]
        public ActionResult EducationUpdate(Education p)
        {
            Education t = repo.Find(x=>x.ID==p.ID);
            t.ID = p.ID;
            t.HEAD = p.HEAD;
            t.SUBHEAD = p.SUBHEAD;
            t.SUBHEAD2 = p.SUBHEAD2;
            t.GNO = p.GNO;
            t.DATE = p.DATE;
            t.PHOTOURL = p.PHOTOURL;
            repo.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}