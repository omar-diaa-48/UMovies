using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UMovies.Models;

namespace UMovies.ViewModels
{
    public class CustomersMoviesViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}