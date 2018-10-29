using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vstore1.Models;
using Vstore1.ViewModels;

namespace Vstore1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Cool Street 1", Id = 1 };

            var guests = new List<Guest>
            {
                new Guest { Fname = "Bob", Lname = "Bobberson"},
                new Guest { Fname = "Jill", Lname = "Jillson"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Guests = guests
            };  

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }


        
    }
}