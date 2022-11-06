using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance   //kalıtımmiras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Gulnisa" },
                new Student{FirstName="Zehra" },
                new Person{FirstName ="Beyza"},
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }
            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }

}
// inheritance önce yazılır sonra interface yazılır.
//inheritance classlara interface deki gibi birden çok tanımlama yapılamaz örnek: class Work: Person,Person2 gibi
//classları tek başına bir anlamı vardır ama interfaceleri tek başına bir anlamı yoktur.
//kulladığınız senaryoya göre farklılık olusturur.interfacelerin kullanınız.interfaceler her nekadar inheritance olmasa da inheritance mantığıyla kullanılabilir.
//inheritance abstract classlarda kullanılır
