using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
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
    }
}
