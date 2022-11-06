using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Save();
        }
    }
    class Customer
    {
        protected int Id { get; set; }    //protected interit edilen sınıflarda da kullanılır private sadece o class özeldir
        public void Save()
        {
            int Id;
        }
        public void Delete()
        {

        }
    }
    class Student : Customer
    {
        public void Save2()
        {

        }
    }

    public class Course
    {
        public string Name { get; set; }
    }




}
//customer customer=new customer();
//custumer.Id();
//yazdığımızda çıkmaz çünkü o student classına ait tanımlamadır(private bir degişkendir

//private=sadece tanımlandığı yerde
//protected= interitence(kalıtım ) edilen heryerde
//internal ise kendi proje dosyasının heryerinde 
//public ise referans verilen tüm projelerde kullanılır.