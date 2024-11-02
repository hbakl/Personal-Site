using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var experience = repo.List();
            return View(experience);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            TblExperience t=repo.Find(x=>x.ID==id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult ExperienceBring(int id)
        {
            TblExperience t = repo.Find(x => x.ID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult ExperienceBring(TblExperience p)
        {
            TblExperience t = repo.Find(x => x.ID == p.ID);
            t.Title = p.Title;
            t.Subtitle = p.Subtitle;
            t.Date = p.Date;
            t.Explanation = p.Explanation;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}