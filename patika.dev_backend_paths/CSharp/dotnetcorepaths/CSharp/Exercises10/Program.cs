using System;

namespace Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }
        public static void Arrays()
        {
            string[] colours = new string[5];
            string[] animals= {"Dog","Cat","Bird","Donkey"};
            int [] numbers={10,20,30,5,6};
            colours[0]="Blue";
            Console.WriteLine(animals[1]);
            Console.WriteLine(colours[0]);
            Console.WriteLine(numbers[3]);

        }
    }
}
