using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
              //InterfacesIntro();
            //Demo();


            ICostumerDal[] customerDals = new ICostumerDal[2]
            {
                 new SqlServerCustomerDal(),
                 new OracleCustomerDal(),
            };

            foreach (var custumerDal in customerDals)
            {
                custumerDal.Add();
            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManeger customerManager =
            new CustomerManeger();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "Gülnisa",
                LastName = "Aslan",
                Address = "İstanbul"
            };
            Student student = new Student
            {
                Id = 187,
                FirstName = "Gülnisa",
                LastName = "Aslan",
                Departmant = "ilahiyat"
            };
            //manager.Add(new Customer { Id = 2, FirstName = "Gülnisa", LastName = "Aslan", Address = "İstanbul" });
            manager.Add(student);
            manager.Add(customer);
            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
// ctr+k+d düzen verme
