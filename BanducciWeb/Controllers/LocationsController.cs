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
            var LocControllerDbList = _locationsManager.List();
            return View(LocControllerDbList);  //todo
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult NullStoreView()
        {
            return View("Null");
        }

        public ActionResult ChangeSaved()
        {
            return View();
        }

        public ActionResult TryAgain()
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NullStoreView");
          
            }

            Locations locations = _locationsManager.GetId(id);

            if (locations == null){

                return RedirectToAction("NullStoreView");
            }

            return View(locations);
        }

        public ActionResult AddStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.Create(model);
            }

            return RedirectToAction("ChangeSaved");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NullStoreView"); 
            }

            Locations locations = _locationsManager.GetId(id);

            if (locations == null)
            {
                return RedirectToAction("NullStoreView");
            }

            return View(locations);

        }

        public ActionResult EditStore(Locations model)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.EditStore(model);
            }

            return RedirectToAction("ChangeSaved");
        }

        public ActionResult DeleteStore(Locations locations)
        {
            if (ModelState.IsValid)
            {
                _locationsManager.Delete(locations);
                return RedirectToAction("ChangeSaved");
            }

            else
            {
                return RedirectToAction("Try Again");
            }

            
        }
    }
}