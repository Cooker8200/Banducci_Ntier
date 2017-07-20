using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanducciBusiness;
using BanducciModels;

namespace BanducciWeb.Controllers
{
    public class LocationsController : Controller
    {
        public LocationsController()
        {
            _locations = new LocationsManager();
        }

        private LocationsManager _locations;

        public ActionResult Index()
        {
            return View("LocationsHome");
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locations.Create(model);
            }

            return RedirectToAction("Create");
        }
    }
}