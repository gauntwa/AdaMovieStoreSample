using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdaMovieStoreSample.DataLayer;

namespace AdaMovieStoreSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult MovieDetail(int id=1)
        {
            ViewBag.id = id;
            return View();
        }

    }
}
