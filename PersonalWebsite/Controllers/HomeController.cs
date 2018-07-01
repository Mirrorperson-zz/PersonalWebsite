using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
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

        public ActionResult Projects()
        {
            ViewBag.Message = "Your projects page.";

            return RedirectToAction("Index", "Projects");
        }
    }
}