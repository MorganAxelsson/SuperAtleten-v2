using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using DataLayer.Repository;

namespace SuperAtleten2.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork;
        public HomeController(Sa2DbEntities context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = unitOfWork.ExceptionLog.Get(1).Caller;
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}