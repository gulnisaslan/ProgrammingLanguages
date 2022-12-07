using System;

namespace Exercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
        }
        public static void ForLoop(){
            //Ekrandan girilen sayıya kadar olan  teksaıları yazınız
        //    Console.Write("sayı giriniz:");
        //     int sayac =int.Parse(Console.ReadLine());
        //     for (int i = 0; i <= sayac; i++)
        //     {
        //         if (i % 2==1)
        //          Console.WriteLine(i);
                
        //     }
        //     int tekToplam =0;
        //     int ciftToplam=0;
        //      for (int i = 0; i <=1000; i++)
        //      {
        //          if(i%2==1)
        //           tekToplam+=1;
                
        //         else
        //             ciftToplam+=1;
                
        //      }
        //      Console.WriteLine(tekToplam);
        //      Console.WriteLine(ciftToplam);

             //break-contiune
             for (int i = 0; i < 10; i++)
             {
                 if (i==4)
                 {
                     break;
                     
                 }
                 Console.WriteLine(i);
             }

                    for (int i = 0; i < 10; i++)
             {
                 if (i==4)
                 {
                     continue;
                     
                 }
                 Console.WriteLine(i);
             }
             
        }
    }
}
