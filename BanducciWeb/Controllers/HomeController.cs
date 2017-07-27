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

        public ActionResult _JonB_GetBio()
        {
            return PartialView("_JonBanducciBio");
        }

        public ActionResult _MichelleB_GetBio()
        {
            return PartialView("_MichelleBanducciBio");
        }

        public ActionResult _Therese_GetBio()
        {
            return PartialView("_ThereseWunderlichBio");
        }
        public ActionResult _Jim_GetBio()
        {
            return PartialView("_JimFuegnerBio");
        }
        public ActionResult _Angie_GetBio()
        {
            return PartialView("_AngieBuscherBio");
        }

        public ActionResult _Julie_GetBio()
        {
            return PartialView("_JulieBio");
        }

        public ActionResult _Barb_GetBio()
        {
            return PartialView("_BarbBio");
        }

        public ActionResult _Carol_GetBio()
        {
            return PartialView("_CarolBio");
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