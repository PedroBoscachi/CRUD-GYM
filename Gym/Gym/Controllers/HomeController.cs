using Gym.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(Employee.Employees);
        }

        public IActionResult Customers()
        {
            return View(Customer.Customers);
        }
    }
}
