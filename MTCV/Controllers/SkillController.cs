using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTCV.Models.ENTITY;
using MTCV.Repositories;

namespace MTCV.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        GenericRepository<Skill> repo = new GenericRepository<Skill>();
        public ActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }
        public ActionResult Delete(int id)
        {
            var delete = repo.Find(x=>x.ID==id);
            repo.TDelete(delete);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Skill s = repo.Find(x=>x.ID==id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Update(Skill p)
        {
            Skill t = repo.Find(x => x.ID == p.ID);
            t.SKILL = p.SKILL;
            t.Oran = p.Oran;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}