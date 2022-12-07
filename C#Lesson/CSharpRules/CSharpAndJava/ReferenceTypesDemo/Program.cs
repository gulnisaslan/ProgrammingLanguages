using System;

namespace ReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             int sayi =20;
             int sayi2=25;
             sayi=sayi2;
             sayi2=30;
             Console.WriteLine(sayi);
             Console.WriteLine(sayi2);

             int[] sayilar1=new int[]{1,2,3};
             int[] sayilar2=new int[]{4,5,6};
             sayilar1=sayilar2;
             sayilar2[0]=30;
             Console.WriteLine(sayilar2[0]);


        }
    }

     
}
