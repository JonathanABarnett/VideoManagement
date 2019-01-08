using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoManagement.Models;

namespace VideoManagement.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie {Name = "Lord of the Rings"};

            return View(movie);
        }
    }
}