using front_end_web_app_html5_javascript_css.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace front_end_web_app_html5_javascript_css.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Echo(string searchPhrase = "Mahesh")
        {
            var echoModel = new EchoModel();
            echoModel.EchoName = searchPhrase;
            return View(echoModel);
        }
    }
}