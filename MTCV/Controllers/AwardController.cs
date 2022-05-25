using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MTCV.Models.ENTITY;
using MTCV.Repositories;

namespace MTCV.Controllers
{
    public class AwardController : Controller
    {
        GenericRepository<Award> repo = new GenericRepository<Award>();
        // GET: Award
        public ActionResult Index()
        {
            var award = repo.List();
            return View(award);
        }
    }
}