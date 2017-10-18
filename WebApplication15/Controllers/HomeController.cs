using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string msg = "hello world!";
            ViewBag.Msg = msg;
            ViewData["Msg"] = msg;
            TempData["Msg"] = msg;
            return View();
        }

    public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}