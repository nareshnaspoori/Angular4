using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ng2Mvc5Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["index"] = "we are in Index Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            if (TempData["index"]!=null)
            {
                ViewBag.Message = TempData["index"];
                TempData.Keep("index");
            }
         
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            if (TempData["index"] != null)
            {
                ViewBag.Message = TempData["index"];
            }

            return View();
        }
    }
}