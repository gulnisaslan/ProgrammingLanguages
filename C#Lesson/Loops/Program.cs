using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //forLoop();
            //whileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is not prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < -1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Gülnisa", "nihal", "meryem" };
            foreach (var student in students)
            {

                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do// şart sağlanmasa bile bir kere kullanılır
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void whileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is {0}", number);
        }

        private static void forLoop()
        {
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished");
        }
    }
}


//(int i=1; başlangıç sayacı:i<=100;şart blogu: i++=bir dönüş bittiğnde bir artır.)

//ctrl-r ctrl-m
