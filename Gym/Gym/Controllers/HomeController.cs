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

        public IActionResult Equipments()
        {
            return View(Equipment.Equipments);
        }

        [HttpGet]
        public IActionResult RegisterEmployee(int? id)
        {
            if(id.HasValue && Employee.Employees.Any(u => u.Id == id))
            {
                var employee = Employee.Employees.Single(e => e.Id == id);
                return View(employee);
            }
            return View();
        }

        [HttpPost]
        public IActionResult RegisterEmployee(Employee employee)
        {
            Employee.Save(employee);
            return RedirectToAction("Employees");
        }

    }
}
