using assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment.Controllers
{
    public class Account : Controller
    {
        List<Countries> ct;
        private void loadcitis()
        {
            ct = new List<Countries>(); 
            ct.Add(new Countries() { Name = "India", Cities = new string[3] { "Mumbai", "Pune", "Delhi" } });
            ct.Add(new Countries() { Name = "USA", Cities = new string[3] { "Washington", "Arlington", "Newyork" } });
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Signup1()
        {
            loadcitis();
            ViewBag.Countries = ct;
            return View();
        }
        public string [] GetCities(string country)
        {
            loadcitis();
            string[] cities = ct.SingleOrDefault(c => c.Name == country).Cities;
            return cities;
        }
        [HttpPost]
        public IActionResult Signup1(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Signup1");
            }
            else
            {
                ViewBag.IsSuccess = true;
                return View();
            }

        }
        
    }
}
