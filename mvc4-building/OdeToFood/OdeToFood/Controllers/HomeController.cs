using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeFoodDb _db = new OdeFoodDb();

        public ActionResult AutoComplete(string term)
        {
            var model = _db.Restaurants
                .Where(r => r.Name.StartsWith(term))
                .Take(10)
                .Select(r => new
                {
                    label = r.Name
                });
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [ChildActionOnly]
        [OutputCache(Duration=60)]
        public ActionResult SayHello()
        {
            return Content("Hello");
        }

        [OutputCache(Duration=5)]
        public ActionResult Index(string searchTerm = null, int page = 1)
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0}::{1}::{2}", controller, action, id);

            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            ViewBag.Message = message;


            //var model = _db.Restaurants.ToList();

            //var model = from r in _db.Restaurants
            //            orderby r.Reviews.Count descending
            //            select r;

            //var model = from r in _db.Restaurants
            //            orderby r.Reviews.Average(rw => rw.Rating) descending
            //            select r;

            //var model = from r in _db.Restaurants
            //            where searchTerm == null || r.Name.StartsWith(searchTerm)
            //            orderby r.Reviews.Average(rw => rw.Rating) descending
            //            select new RestaurantsListViewModel
            //            {
            //                Id = r.Id,
            //                Name = r.Name,
            //                City = r.City,
            //                Country = r.Country,
            //                CountOfReviews = r.Reviews.Count()
            //            };

            var model = _db.Restaurants
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .OrderByDescending(r => r.Reviews.Average(rw => rw.Rating))
                .Select(r => new RestaurantsListViewModel
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            CountOfReviews = r.Reviews.Count()
                        }).ToPagedList(page, 10);

            if (Request.IsAjaxRequest())
            {
                return PartialView("_Restaurants", model);
            }

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
