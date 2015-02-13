using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        //[HttpPost]
        //public ActionResult Search(string name = "french")
        //{
        //    return Content(Server.HtmlEncode(name));
        //    //return RedirectToAction("Index", "Home", new { name = name });

        //    //return RedirectToRoute("Default", new { controller = "Home", action = "About" });

        //    //return File(Server.MapPath("~/Content/site.css"), "text/css");

        //    //return Json(new { Message = Server.HtmlEncode(name), Name = "Mahesh" }, JsonRequestBehavior.AllowGet);
        //}

        //[HttpGet]
        //public ActionResult Search()
        //{
        //    return Content("Hello HttpGet");
        //}

        //[Authorize]
        public ActionResult Search(string name = "french")
        {
            throw new Exception(" Bad Exception");
            return Content(Server.HtmlEncode(name));
        }

    }
}
