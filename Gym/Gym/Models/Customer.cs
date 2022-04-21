using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        private static List<Customer> customers = new List<Customer>();
        public static IQueryable<Customer> Customers
        {
            get
            {
                return customers.AsQueryable();
            }
        }

        static Customer()
        {
            Customer.customers.Add(new Customer { Id = 1, Name = "Alfred", State = "São Paulo"}
                );
            Customer.customers.Add(new Customer { Id = 2, Name = "Fred", State = "Bahia" }
                );
            Customer.customers.Add(new Customer { Id = 3, Name = "Thelma", State = "Rio de Janeiro" }
                );
            Customer.customers.Add(new Customer { Id = 4, Name = "Cristiano", State = "New York" }
                );
            Customer.customers.Add(new Customer { Id = 5, Name = "Jennye", State = "Montana" }
                );
        }

        public static void Save(Customer customer)
        {
            var existingCustomer = Customer.customers.Find(c => c.Id == customer.Id);
            if(existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.State = customer.State;
            }
            else
            {
                int biggestId = Employee.Employees.Max(c => c.Id);
                customer.Id = biggestId + 1;
                Customer.customers.Add(customer);
            }
        }

        public static bool Delete(int id)
        {
            var existingCustomer = Customer.customers.Find(c => c.Id == id);
            if(existingCustomer != null)
            {
                Customer.customers.Remove(existingCustomer);
            }

            return false;
        }
    }
}
