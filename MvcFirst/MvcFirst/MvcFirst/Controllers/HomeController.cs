using MvcFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<BikeModel> _bikes = new List<BikeModel>();
            _bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City="Skopje" });
            _bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            _bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            _bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            return View(_bikes);
        }

        public ActionResult Profile() {

            return View();
        }
    }
}