using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdaMovieStoreSample.DataLayer;
using AdaMovieStoreSample.Models;
using Newtonsoft.Json;

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

        public ActionResult Customers()
        {
            var rawCustomers = System.IO.File.ReadAllLines(@"C:\Users\x1e5.NORD\Source\Repos\AdaMovieStoreSample\AdaMovieStoreSample\AdaMovieStoreSample\AdaMovieStoreSample\App_Data\customers.json");
            var customers = JsonConvert.DeserializeObject<List<Customer>>(string.Join("\r\n",rawCustomers));
            return View(customers);
        }

    }
}
