using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers/")]
        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer() {Name = "Norman Croan"},
                new Customer() {Name = "Ralph Madeup"},
                new Customer() {Name = "Jose Nonexistent"},
                new Customer() {Name = "Fictional Jane"}
            };

            var viewModel = new AllCustomersViewModel()
            {
                Customers = customers
            };
            return View(viewModel);
        } 
    }
}