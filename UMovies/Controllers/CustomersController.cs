using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UMovies.Models;
using System.Data.Entity;
using UMovies.ViewModels;

namespace UMovies.Controllers
{
    public class CustomersController : Controller
    {
        BusinessModelContext DBContext = new BusinessModelContext();
        // GET: Customers
        public ActionResult Index()
        {
            return View(DBContext.Customers.Include(c=>c.MembershipType));
        }

        public ActionResult Details(int id)
        {
            var CustomerDetailed = DBContext.Customers.Include(c => c.MembershipType).FirstOrDefault(c => c.CustomerID == id);

            if (CustomerDetailed == null)
                return HttpNotFound();

            return View();
        }

        public ActionResult NewCustomer()
        {
            var ViewModel = new CustomerMembershipTypesViewModel
            {
                MembershipTypes = DBContext.MembershipTypes.ToList()
            };

            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult NewCustomer(Customer AddedCustomer)
        {
            DBContext.Customers.Add(AddedCustomer);
            DBContext.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult EditCustomer(int id)
        {
            var EditedCustomer = DBContext.Customers.FirstOrDefault(c => c.CustomerID == id);

            if (EditedCustomer == null)
                return HttpNotFound();

            ViewBag.MembershipTypes = DBContext.MembershipTypes;
            return View(EditedCustomer);
        }

        [HttpPost]
        public ActionResult EditCustomer(int id, Customer EditedCustomer)
        {
            var CustomerToBeEdited = DBContext.Customers.FirstOrDefault(c=>c.CustomerID == id);

            CustomerToBeEdited.Name = EditedCustomer.Name;
            CustomerToBeEdited.BirthDate = EditedCustomer.BirthDate;
            CustomerToBeEdited.IsSubscribedToNewsletter = EditedCustomer.IsSubscribedToNewsletter;
            CustomerToBeEdited.MembershipTypeID = EditedCustomer.MembershipTypeID;

            DBContext.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            DBContext.Dispose();    
        }
    }
}