using System;
using System.Collections.Generic;
using System.Text;
namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" added");
        }
        public void Listing(List<Customer> customers)
        {
            foreach (var custo in customers)
            {
                Console.WriteLine(custo.Name);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " Deleted");
        }
    }
}
