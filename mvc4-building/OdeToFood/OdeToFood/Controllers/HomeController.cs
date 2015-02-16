using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeFoodDb _db = new OdeFoodDb();

        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0}::{1}::{2}", controller, action, id);

            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            ViewBag.Message = message;


            var model = _db.Restaurants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";
            //ViewBag.Location = "Colombo, Sri Lanka";

            var model = new AboutModel();
            model.Name = "Mahesh";
            model.Location = "Colombo";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
