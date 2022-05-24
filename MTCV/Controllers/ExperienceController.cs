using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTCV.Models.ENTITY;
using MTCV.Repositories;
namespace MTCV.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var Experience = repo.List();
            return View(Experience);
        }
        [HttpGet]
        public ActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExperienceAdd(Experience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult ExperienceRemove(int id)
        {
            var remove = repo.Find(x => x.ID == id);
            repo.TDelete(remove);
            return RedirectToAction("Index");
        }
    }
}