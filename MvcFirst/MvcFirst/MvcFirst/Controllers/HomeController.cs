﻿using MvcFirst.Models;
using Registar.BusinessLayer;
using Registar.BusinessLayer.Contracts;
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
            BikeSearchCommand command = new BikeSearchCommand();
            BikeSearchResult _result = CommandInvoker.InvokeCommand<BikeSearchCommand,BikeSearchResult>(command);
            List<BikeModel> _bikes = new List<BikeModel>();
            //_bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City="Skopje" });
            //_bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            //_bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            //_bikes.Add(new BikeModel() { Colour = "Red", Model = "CityBike", Prdoucer = "JB", RegNumber = "007", City = "Skopje" });
            return View(_result.Result);
        }

        public ActionResult Profile() {

            return View();
        }
    }
}