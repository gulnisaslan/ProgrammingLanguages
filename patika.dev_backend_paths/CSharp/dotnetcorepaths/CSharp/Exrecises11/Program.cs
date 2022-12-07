using System;

namespace Exrecises11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysAndLoops();
        }
        public static void ArraysAndLoops()
        {
            //Klavyeden girilen n tane sayının ortalamasını alma
            Console.WriteLine("Lütfen dizinin eleman sayısımı giriniz");    
            int arrayLength1=int.Parse(Console.ReadLine());
            int[]  numberArray= new int[arrayLength1];
            
            for (int i = 0; i < arrayLength1; i++)
            {
                Console.Write("Lütfen {0} sayısını giriniz:");
                numberArray[i]=int.Parse(Console.ReadLine());
            }

            int multiple=0;
            foreach (var number in numberArray)
                multiple+=number;
            Console.WriteLine("Ortalama:"+multiple/arrayLength1);
            
        }
        
    }
}
