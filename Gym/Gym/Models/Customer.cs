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
    }
}
