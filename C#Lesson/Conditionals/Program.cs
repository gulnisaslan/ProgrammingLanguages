using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        
    
            static void Main(string[] args)
            {
                var number = 10;
                //if (number == 10) ;
                //{
                //    Console.WriteLine("number is 10");
                //    //Console.WriteLine(number == 10 ? "munber is 10" : "number is not 10")
                //        ;
                //}
                //else if (number == 20);
                //{
                //    Console.WriteLine("number is 20");
                //}
                //else
                //{
                //    Console.WriteLine("number is not 10 or 20");
                //}
                switch (number)
                {
                    case 10:
                        Console.WriteLine("number is 10");
                        break;
                    case 20:
                        Console.WriteLine("number is 20");
                        break;

                    default:
                        Console.WriteLine("number is not 10 or 20");
                        break;


                        
                }
                Console.WriteLine("Ayasofya bizimdir.");
   
                Console.ReadLine();

            }



        }
    }
