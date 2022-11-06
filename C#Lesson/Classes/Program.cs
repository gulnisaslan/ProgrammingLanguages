using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductsManager productsManager = new ProductsManager();
            productsManager.Add();
            productsManager.Update();

            Customer customer = new Customer();
            customer.Id = 12345;
            customer.Name = "Hatice Beyza";
            customer.LastName = "Aktaş";
            customer.City = "istanbul";

            Customer customer2 = new Customer
            {
                Id = 125478,
                Name = "Gülnisa",
                LastName = "Aslan",
                City = "İstanbul"
            };
            Console.WriteLine(productsManager);
            Console.WriteLine(customerManager);
            Console.WriteLine(customer.City);
            Console.WriteLine(customer2.Name);
            Console.ReadLine();





        }
    }
   
   
}
