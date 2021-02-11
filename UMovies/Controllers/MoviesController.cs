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
        BusinessModelContext DBContext = new BusinessModelContext();

        // GET: Movies
        public ActionResult Random()
        {
            return View(DBContext.Movies);
        }


        public ActionResult Details(int id)
        {
            return View(DBContext.Movies.FirstOrDefault(m=>m.MovieID == id));
        }

        protected override void Dispose(bool disposing)
        {
            DBContext.Dispose();
        }

    }
}