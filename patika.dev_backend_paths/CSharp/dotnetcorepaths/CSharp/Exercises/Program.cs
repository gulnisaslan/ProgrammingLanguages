using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
           //Console.WriteLine("Hi")
           //Console.ReadLine();

            Console.WriteLine("Adınız Giriniz: ");
           var name =Console.ReadLine();
           Console.WriteLine("Soyadınız Giriniz: ");
           var surname =Console.ReadLine();

           Console.WriteLine($"merhaba {name} {surname}");
        }
    }
}
// Everything starts with "Hello World".
 // We write our story with a code:)