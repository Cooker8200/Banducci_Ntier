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
            _locationsManager = new LocationsManager();
        }

        private LocationsManager _locationsManager;

        public ActionResult LocationsHome()
        {
            return View();  //todo
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult AddStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.Create(model);
            }

            return RedirectToAction("Create");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Create");  //todo change
            }

            Locations locations = _locationsManager.GetId(id);

            if (locations == null)
            {
                return RedirectToAction("Create");
            }

            return View(locations);

        }

        public ActionResult EditStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.EditStore(model);
            }

            return RedirectToAction("Create");
        }

        public ActionResult DeleteStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.Delete(model);
            }

            return RedirectToAction("Create");
        }
    }
}