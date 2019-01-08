using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoManagement.Models;
using VideoManagement.ViewModels;

namespace VideoManagement.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Lord of the Rings"},
                new Movie { Id = 2, Name = "Harry Potter"},
                new Movie { Id = 3, Name = "Planet of the Apes"}
            };
        }

    }
}