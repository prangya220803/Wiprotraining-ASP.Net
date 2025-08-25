using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_wipro.Models;
using System.Collections.Generic;

namespace MVC_Core_wipro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult wipro()
        {
            // ✅ Create a list of Employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { empid = 101, firstname = "Prangya", lastname = "Sahoo", city = "Bhubaneswar" },
                new Employee { empid = 102, firstname = "Pratyush", lastname = "Sahoo", city = "Pune" },
                new Employee { empid = 103, firstname = "Sujata", lastname = "Sahoo", city = "Bangalore" }
            };

            return View(employees); // ✅ send list to view
        }
    }
}