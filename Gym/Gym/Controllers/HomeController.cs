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

        [HttpGet]
        public IActionResult DeleteEmployee(int? id)
        {
            if(id.HasValue && Employee.Employees.Any(e => e.Id == id))
            {
                var employee = Employee.Employees.Single(e => e.Id == id);
                return View(employee);
            }
            return RedirectToAction("Employees");
        }

        [HttpPost]
        public IActionResult DeleteEmployee(Employee employee)
        {
            TempData["EmployeeDeleted"] = Employee.Delete(employee.Id);
            return RedirectToAction("Employees");
        }

        [HttpGet]
        public IActionResult RegisterCustomer(int? id)
        {
            if(id.HasValue && Customer.Customers.Any(c => c.Id == id))
            {
                var customer = Customer.Customers.Single(c => c.Id == id);
                return View(customer);
            }

            return View();
        }

        [HttpPost]
        public IActionResult RegisterCustomer(Customer customer)
        {
            Customer.Save(customer);
            return RedirectToAction("Customers");
        }

        [HttpGet]
        public IActionResult DeleteCustomer(int? id)
        {
            if(id.HasValue && Customer.Customers.Any(c => c.Id == id))
            {
                var customer = Customer.Customers.Single(c => c.Id == id);
                return View(customer);
            }
            return RedirectToAction("Customers");
        }

        [HttpPost]
        public IActionResult DeleteCustomer(Customer customer)
        {
            TempData["CustomerDeleted"] = Customer.Delete(customer.Id);
            return RedirectToAction("Customers");
        }

        [HttpGet]
        public IActionResult RegisterEquipment(int? id)
        {
            if(id.HasValue && Equipment.Equipments.Any(e => e.Id == id))
            {
                var equipment = Equipment.Equipments.Single(e => e.Id == id);
                return View(equipment);
            }

            return View();
        }

        [HttpPost]
        public IActionResult RegisterEquipment(Equipment equipment)
        {
            Equipment.Save(equipment);
            return RedirectToAction("Equipments");
        }

        [HttpGet]
        public IActionResult DeleteEquipment(int? id)
        {
            if(id.HasValue && Equipment.Equipments.Any(e => e.Id == id))
            {
                var equipment = Equipment.Equipments.Single(e => e.Id == id);
                return View(equipment);
            }

            return RedirectToAction("Equipments");
        }

        [HttpPost]
        public IActionResult DeleteEquipment(Equipment equipment)
        {
            TempData["EquipmenDeleted"] = Equipment.Delete(equipment.Id);
            return RedirectToAction("Equipments");

        }

    }
}
