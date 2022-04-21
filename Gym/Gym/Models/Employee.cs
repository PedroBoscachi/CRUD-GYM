using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        private static List<Employee> employees = new List<Employee>();
        public static IQueryable<Employee> Employees
        {
            get
            {
                return employees.AsQueryable();
            }
        }

        static Employee()
        {
            Employee.employees.Add(
                new Employee { Id = 1, Name = "Raphael", Email = "raphael@gmail.com" });
            Employee.employees.Add(
                new Employee { Id = 2, Name = "Bruce", Email = "bruce@gmail.com" });
            Employee.employees.Add(
                new Employee { Id = 3, Name = "James", Email = "james@gmail.com" });
            Employee.employees.Add(
                new Employee { Id = 4, Name = "Selina", Email = "selina@gmail.com" });
            Employee.employees.Add(
                new Employee { Id = 5, Name = "Vick", Email = "vick@gmail.com" });
        }

        public static void Save(Employee employee)
        {
            var existingEmployee = Employee.employees.Find(e => e.Id == employee.Id);
            if(existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Email = employee.Email;
            }
            else
            {
                int biggestId = Employee.Employees.Max(e => e.Id);
                employee.Id = biggestId + 1;
                Employee.employees.Add(employee);
            }
        }

        public static bool Delete(int id)
        {
            var existingEmployee = Employee.employees.Find(e => e.Id == id);
            if(existingEmployee != null)
            {
                return Employee.employees.Remove(existingEmployee);
            }

            return false;
        }
    }
}
