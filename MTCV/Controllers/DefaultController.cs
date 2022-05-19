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
            return PartialView();
        }
    }
}