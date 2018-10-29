using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vstore1.Models;

namespace Vstore1.Controllers
{
    public class GuestsController : Controller
    {
        [Route("Guests/Index")]
        public ActionResult Index()
        {
            var guests = new List<Guest>
            {
                new Guest { Fname = "Bob", Lname = "Bobberson", Id = 11},
                new Guest { Fname = "Jill", Lname = "Jillson", Id = 12}
            };

            return View(guests);
        }
    }
}