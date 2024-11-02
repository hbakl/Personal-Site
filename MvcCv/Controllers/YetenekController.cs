using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {            

        GenericRepository<TblSkill> repo=new GenericRepository<TblSkill>();
        public ActionResult Index()
        {
            var yetenekler=repo.List();
            return View(yetenekler);
        }


        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniYetenek(TblSkill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }

}