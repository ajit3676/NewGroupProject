using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewGroupProject.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Hours()
        {
            ViewBag.Message = "Your application Hours page.";

            return View();
        }

        public ActionResult My_Library_Account()
        {
            ViewBag.Message = "Your application Library Hours page.";

            return View();
        }
        public ActionResult Catagories()
        {
            ViewBag.Message = "Your application Category page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your application Contact Us page.";
            return View();
        }

    }
}