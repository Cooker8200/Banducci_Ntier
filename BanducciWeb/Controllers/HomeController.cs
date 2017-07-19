using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanducciWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult _BanducciStory()
        {
            return PartialView("_BanducciStory");
        }

        public ActionResult _LeadershipTeam()
        {
            return PartialView("_LeadershipTeam");
        }

        public ActionResult _Partnerships()
        {
            return PartialView("_Partnerships");
        }

        public ActionResult CurrentNews()
        {
            return View();
        }

        public ActionResult Promotions()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
    }
}