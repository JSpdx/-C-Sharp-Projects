using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime DOB, string hadDUI, int? tickets, string coverage, int carYear, string carMake, string carModel)
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var customer = new Customer() { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, DOB = DOB, HadDUI = hadDUI, Tickets = tickets, Coverage = coverage };
                var car = new Car() { CarYear = carYear, CarMake = carMake, CarModel = carModel };
                             
                db.Customers.Add(customer);
                db.Cars.Add(car);
                db.SaveChanges();

            }
            return View();
        }
    }
}