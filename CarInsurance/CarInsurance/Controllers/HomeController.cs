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
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime DOB, bool? hadDUI, int? tickets, string coverage, decimal? quote, ICollection<Car> cars)
        {
            
            return View();
        }
    }
}