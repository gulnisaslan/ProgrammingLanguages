using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics 
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "istanbul", "GaziAntep");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer {FirstName="Gülnisa" },new Customer {FirstName="Haşim" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();


        }
        

    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }

    }
    interface IStudentDal:IRepository<int>
    {

    }
    interface IEntity
    {

    }
    class Student:IEntity
    {

    }
   
    interface IRepository<T>// where T :struct//değer veri tipi //1:class,IEntity,new() // bu şekilde yapabilmek için yukarıdaki gibi olmalı new() sona geldiğinde sadece newlenen için kullanılır.//veritabanı için kullanılır
        //generic constrain:
    {
        List<T > GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class Product
    {

    }
    interface IProductDal:IRepository<Product>
    {
    
    }
    class Customer
    {
        public string FirstName { get; set; }

    }
    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
  

    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
