using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList1();
            //List();

            //Console.WriteLine(cities.Contains("ankara"));
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, name = "gülnisa" });
            //customers.Add(new Customer { Id = 2, name = "beyza" });

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("city", "şehirler");
            dictionary.Add("table", "masa");
            Console.WriteLine(dictionary["city"]);
            foreach (var item in dictionary)
            {
               
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.ReadLine();


        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("ankara");
            cities.Add("istanbul");
            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, name = "gülnisa" },
                new Customer { Id = 2, name = "beyza" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                name = "ercan"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=5, name="merve"},
                new Customer{Id=8, name="kerim"}
            });
            Console.WriteLine(customers.Contains(customer2));
            // customers.Clear();



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.name);
            }
            var count = customers.Count;
            Console.WriteLine("count: {0}", count);
        }


        private static void ArrayList1()
        {
            ArrayList cities = new ArrayList();
            cities.Add("ankara");
            cities.Add("istanbul");
            cities.Add("gaziantep");
            cities.Add("mersin");
            cities.Add(1);
            cities.Add("a");

            foreach (var my in cities)
            {
                Console.WriteLine(my);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
//type safe güvenli tip olarak çalısılır.
