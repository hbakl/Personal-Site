using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db =new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TblAbout.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblExperience.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TblEducation.ToList();
            return PartialView(egitimler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TblSkill.ToList();
            return PartialView(yetenekler);
        }

        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TblInterest.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.TblCertificate.ToList();
            return PartialView(sertifikalar);
        }


        [HttpGet]
        public PartialViewResult iletisim()
        {
                return PartialView();
        }


        [HttpPost]
        public PartialViewResult iletisim(TblContact t)
        {
            t.Date = DateTime.Now;
            db.TblContact.Add(t);
            db.SaveChanges();
            return PartialView();
        }


    }
}