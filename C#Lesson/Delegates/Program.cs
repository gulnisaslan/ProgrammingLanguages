using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    //void değer olan ve parametre alamyan operasyonlara delegelik yapıyor.
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            
            myDelegate();
            MyDelegate2  myDelegate2= customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");
           
            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Hesapla;
            myDelegate3 += matematik.Hesapla2;

            int sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);
            Console.ReadLine();

        }// en son verdiğiniz delege calışır return değer gönderirken
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert );
        }
    }
    public class Matematik
    {
        public int Hesapla(int number1,int number2)
        {
            return number1 + number2;
        }
        public int Hesapla2(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
//delegates = Günümüzde delegeleri action ve func gibi tutucularla tutabiliyoruz.Action exceptionda kullanmıstık.Action aslında bir metoda yani metod bloğuna karşılık gelir.Void olanları Yani değer çeviren metodlarda kullanılır.void türüdür.

//func = değer döndürür