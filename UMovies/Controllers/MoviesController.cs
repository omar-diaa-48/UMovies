using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMovies.Models;
using UMovies.ViewModels;

namespace UMovies.Controllers
{
    public class MoviesController : Controller
    {
        Movie movie = new Movie() { Name = "Shrek" };

        List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "John Smith", CustomerID = 1},
                new Customer{Name = "Mary Williams", CustomerID = 2}
            };

        // GET: Movies
        public ActionResult Random()
        {

            var viewModel = new CustomersMoviesViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}