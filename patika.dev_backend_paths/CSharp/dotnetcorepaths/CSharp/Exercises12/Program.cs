using System;

namespace Exercises12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClassMethods();
        }
        public static void ArrayClassMethods()
        {
            int[] numbers ={23,12,15,16,86,10,11,14};
            
            //Sırasız Liste
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
           
            //Sıralı Liste
            Console.WriteLine("\n*****Sort Arrays******");
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
           
            //İndekslenmiş Liste Elemanı
            Console.WriteLine("\n*****IndexOf Arrays******");
            Console.WriteLine(Array.IndexOf(numbers,11));
            
            //Liste elemanlarını sıfırlama temizleme
            Console.WriteLine("\n*****Clear Arrays******");
            Array.Clear(numbers,2,2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse Array
            Console.WriteLine("\n*************Reverse Arrays********");
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Resize Arrays
            Console.WriteLine("\n*********Resize Arrays********");
            Array.Resize<int>(ref numbers,9);
            numbers[8]=99;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }
    }
}
