using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                             orderby r.Rating descending
                             select r;
            return PartialView("_Review", bestReview.First());
        }
        //
        // GET: /Reviews/

        public ActionResult Index()
        {
            var model = from r in _reviews
                        orderby r.Country
                        select r;

            return View(model);
        }

        //
        // GET: /Reviews/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews/Edit/5

        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        //
        // POST: /Reviews/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            //try
            //{
            //    // TODO: Add update logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}

            var review = _reviews.Single(r => r.Id == id);

            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }
            return View(review);
        }

        //
        // GET: /Reviews/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview 
            {
                Id = 1,
                Name = "A",
                City = "A",
                Country = "A",
                Rating = 5
            },

            new RestaurantReview 
            {
                Id = 2,
                Name = "B",
                City = "B",
                Country = "B",
                Rating = 5
            },

            new RestaurantReview 
            {
                Id = 3,
                Name = "C",
                City = "C",
                Country = "C",
                Rating = 5
            },

            new RestaurantReview 
            {
                Id = 4,
                Name = "D",
                City = "D",
                Country = "D",
                Rating = 5
            }

        };
    }
}
