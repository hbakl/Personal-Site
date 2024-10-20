using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCv.Repositories
{
    public class DeneyimRepository
    {
        DbCvEntities db = new DbCvEntities();
        public List<TblExperience> List()
        {
            return db.TblExperience.ToList();

        }

         
    }
}