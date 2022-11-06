using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=187,LastName="Aslan",Age=24 };
            CustomerDal customerDal = new CustomerDal();
            //customerDal.Add(customer);
            customerDal.AddNew(customer);
            Console.ReadLine();

        }
    }
    [ToTable("Customers")]
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }
       [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true )]
    class RequiredPropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]// bu kısımda classlar kullanılır
    class ToTableAttribute:Attribute
    {
       private string _tableName ;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }


       


    }


}
// [AttributeUsage(AttributeTargets.Class)] AttributeTargets.All yazdığımızda class ve onu altındaki kodlarada kullanabiliyoruz.
//class yazdığımızda ise sadece classlarda kulllanabiliyoruz.
//class RequiredPropertyAttribute : Attribute
//{
//
//}