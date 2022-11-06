using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(23); customerManager.List();
            Product product = new Product { Id = 1, name = "laptop" };
            Product product2 = new Product(2, "Computer");

            EmployerManager employerManager = new EmployerManager(new DatabaseLogger());
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            employerManager.Add();
            Teacher.Number = 10;
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();



        }
    }
    class CustomerManager
    {

        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("listed! {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {

        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to filebase");
        }
    }
    class EmployerManager
    {
        // public ILogger Logger { get; set; }
        private ILogger _logger;
        public EmployerManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
   
}
//ctor=tab iki kere tıklat.. constructors
//statiği direkte sınıfın isminde çağrıyoruz.sınıf static olmaması gerekiyor...
//static olmayanı ise instence çağrıyoruz
//class'ın bazı özellikleri static bazı özellikler statik olmaması gerekiyor
