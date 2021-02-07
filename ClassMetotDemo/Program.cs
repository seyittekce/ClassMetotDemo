using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Age = 20,
                LastName = "TEKCE",
                Name  ="Seyit"
            };
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
        }
    }
}
