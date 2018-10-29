using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vstore1.Models;

namespace Vstore1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Guest> Guests { get; set; }
    }
}