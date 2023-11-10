using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBasedTestMVC
{
    public class MyController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();
        public ActionResult GermanCustomer()
        {
            var germanCustomers = db.customers.Where(c => c.Country == "OurGermany").ToList();
            return View(germanCustomers);
        }
        public ActionResult CustomerDetails()
        {
            var orderDetails = db.Customers
                .Join(db.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) => new { c, o })
                .Where(x => x.o.OrderID == 10248).ToList();
            return View(orderDetails);
        }
    }
}