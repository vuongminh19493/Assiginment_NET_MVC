using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_ASP_Final.Models;

namespace Assignment_ASP_Final.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var model = db.Categories
                .Where(c => c.Products.Count >= 4)
                .OrderBy(c => Guid.NewGuid()).ToList();


            return View(model);
        }

        public ActionResult Search()
        {
            var name = Request["term"];

            var data = db.Products
                .Where(p => p.Name.Contains(name))
                .Select(p => p.Name).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Category()
        {
            var model = db.Categories;
            return PartialView("_Category", model);
        }

    }
}