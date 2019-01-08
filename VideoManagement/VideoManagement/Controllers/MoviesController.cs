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
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie {Name = "Lord of the Rings"};

            var customers = new List<Customer>
            {
                new Customer { Name = "Bob"},
                new Customer { Name = "John"},
                new Customer { Name = "Joe"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        


    }
}