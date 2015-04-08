using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nesjartun.Contact;
using Nesjartun.Models;

namespace Nesjartun.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public ActionResult Form()
        {
            return PartialView("_Form", new ContactModel());
        }

        // GET: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(ContactModel model)
        {
            if (!ModelState.IsValid) return View("_Form", model);

            try
            {
                _contactService.SendContactRequest(model);
            }
            catch (Exception e)
            {
                //TODO: Log
                return PartialView("_Error");
            }
            return PartialView("_Success");
        }
    }
}