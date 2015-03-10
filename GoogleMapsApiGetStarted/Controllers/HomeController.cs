using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapsApiGetStarted.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Foo()
        {

            return File(Server.MapPath("~/Views/Goe.Json"), "text/json");
        }

        public ActionResult Foo1()
        {

            return File(Server.MapPath("~/Views/Goe1.Json"), "text/json");
        }

        public ActionResult GeoJSON()
        {
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