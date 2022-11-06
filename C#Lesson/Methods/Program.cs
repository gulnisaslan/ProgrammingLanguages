using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program98uy
    {
        static void Main(string[] args)
        {
            //  Add();
            //  Add(); 
            // Add();
            // Add();
            // var result = Add2(20);

            int number1 =20;
            int number2 = 100;
            // var result2 = Add3(ref number1, number2);

            var result2 = Add3(out number1, number2);

             Console.WriteLine(result2);
            Console.WriteLine(number1);

            //    Console.WriteLine(Multiply(2, 4));

            //    Console.WriteLine(Multiply(2, 3, 5));

           // Console.WriteLine(Add4(3, 4, 5, 6, 7, 8, 9));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1 = 20, int number2 = 30)//default değerleri herzaman en sondakine verilir  baştakine verilmez

        {
            //return number1 +number2;
            var result = number1 + number2;
            return result;

        }
        static int Add3(out int number1, int number2)//ref keywordunde number1 olmak zorunda. out keywordunden böyle bir zorunluluk yoktur.
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }


        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }



    }


}
