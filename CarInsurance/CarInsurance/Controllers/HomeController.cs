using CarInsurance.Models;
using CarInsurance.ViewModels;
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
                var car = new Car() { CarYear = carYear, CarMake = carMake.ToLower(), CarModel = carModel.ToLower() };
                customer.Quote = getQuote(customer, car);         
                db.Customers.Add(customer);
                db.Cars.Add(car);
                db.SaveChanges();

                var customerVm = new CustomerVM() { FirstName = customer.FirstName, LastName = customer.LastName, Quote = customer.Quote, Coverage = customer.Coverage};
                

            return View(customerVm);
            }
        }

        private int getQuote(Customer customer, Car car)
        {
            decimal quote = 50;
            var today = DateTime.Today;
            var age = today.Year - customer.DOB.Year;
            int ticketFee = Convert.ToInt32(customer.Tickets * 10);
            quote += ticketFee;
            if (age < 18) quote += 100;
            else if (age < 25 && age >= 18) quote += 25;
            else if (age > 100) quote += 25;

            if (car.CarYear < 2000) quote += 25;
            else if (car.CarYear > 2015) quote += 25;

            if (car.CarMake == "porsche" && car.CarModel != "911 carrera") quote += 25;
            else if (car.CarMake == "porsche" && car.CarModel == "911 carrera") quote += 50;

            if (customer.HadDUI == "on") quote += quote * .25m;
            if (customer.Coverage == "Full Coverage") quote += quote * .5m;

            return Convert.ToInt32(quote);
        }
    }
}