using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMovies.Models;

namespace UMovies.Controllers
{
    public class CustomersController : Controller
    {
        BusinessModelContext DBContext = new BusinessModelContext();
        // GET: Customers
        public ActionResult Index()
        {
            return View(DBContext.Customers);
        }

        public ActionResult Details(int id)
        {
            return View(DBContext.Customers.FirstOrDefault(c=>c.CustomerID == id));
        }

        protected override void Dispose(bool disposing)
        {
            DBContext.Dispose();    
        }
    }
}