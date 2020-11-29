using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerSample.Models;
using CustomerSample.Attribute;

namespace CustomerSample.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {

            //foreach (var i in res)
            //{
            //    ViewData["X"] = i.CheckExist;
            //}
            return View();
        }

        [HttpPost]
        public ActionResult Add(CustomerModel customer)
        {

            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            return RedirectToAction("Add", "Customer");
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel customer)
        {
            //AsusDBDataContext db = new AsusDBDataContext();

            //CheckExistedFieldAttribute checkExistedField = new CheckExistedFieldAttribute();

            //var res = db.GetIdByFullName(customer.FullName).ToList();

            //if (res[0].CustomerID != null)
            //{
            //    customer.CustomerID = res[0].CustomerID;
            //}

            //checkExistedField.CustomerID = customer.CustomerID;

            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            return RedirectToAction("Edit", "Customer");
        }
    }

}