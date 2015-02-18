using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {

        OdeFoodDb _db = new OdeFoodDb();

        //[ChildActionOnly]
        //public ActionResult BestReview()
        //{
        //    var bestReview = null;

        //    return PartialView("_Review", bestReview.First());
        //}
        //
        // GET: /Reviews/

        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);

            if (restaurant != null)
            {
                return View(restaurant);
            }

            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }



        //static List<RestaurantReview> _reviews = new List<RestaurantReview>
        //{
        //    new RestaurantReview 
        //    {
        //        Id = 1,
        //        Name = "A",
        //        City = "A",
        //        Country = "A",
        //        Rating = 5
        //    },

        //    new RestaurantReview 
        //    {
        //        Id = 2,
        //        Name = "B",
        //        City = "B",
        //        Country = "B",
        //        Rating = 5
        //    },

        //    new RestaurantReview 
        //    {
        //        Id = 3,
        //        Name = "C",
        //        City = "C",
        //        Country = "C",
        //        Rating = 5
        //    },

        //    new RestaurantReview 
        //    {
        //        Id = 4,
        //        Name = "D",
        //        City = "D",
        //        Country = "D",
        //        Rating = 5
        //    }

        //};
    }
}
