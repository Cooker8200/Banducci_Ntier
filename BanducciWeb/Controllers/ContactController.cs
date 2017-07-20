using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BanducciModels;
using BanducciBusiness;
using System.Threading.Tasks;

namespace BanducciWeb.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
            _email = new ContactManager();
        }

        private ContactManager _email;

        public ActionResult ContactHome()
        {
            return View("ContactUs");
        }

        public ActionResult Sent()
        {
            return PartialView("_Sent");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendContact(ContactForm model)
        {
            if (ModelState.IsValid)
            {
                _email.ContactForm(model);
            }

            return RedirectToAction("Sent"); //todo
        }
    }
}