using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTCV.Models.ENTITY;

namespace MTCV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        ContextCv db = new ContextCv();
        public ActionResult Index()
        {
            var degerler = db.Abouts.ToList();
            return View(degerler);
        }
        public PartialViewResult Experience()
        {
            var deneyimler = db.experiences.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Education()
        {
            var egitim = db.educations.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Skill()
        {
            var yetenekler = db.skills.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Interest()
        {
            var hobi = db.Interests.ToList();
            return PartialView(hobi);
        }
        public PartialViewResult Award()
        {
            var sertifikalar = db.Awards.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Contact(Contact contact)
        {
            contact.DATE = DateTime.Today.ToString();
            db.contacts.Add(contact);
            db.SaveChanges();
            return PartialView();
        }
    }
}