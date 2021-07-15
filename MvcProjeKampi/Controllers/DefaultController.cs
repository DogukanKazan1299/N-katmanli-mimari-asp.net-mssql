using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
    }
}