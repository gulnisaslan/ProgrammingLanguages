using System;

namespace Exercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WhileAndForeach();

        }
        public static void WhileAndForeach()
        {
            Console.WriteLine("****************While Loop***************");
            
                //1'den başlayarak Console'dan girilen sayıya kadar sayı dahil ortalama hesaplama
                Console.Write("Lütfen sayı giriniz:");
                int sayi=int.Parse(Console.ReadLine());
                int sayac=1;
                int toplam=0;
                while (sayac<=sayi)
                {
                     toplam+=sayac;
                     sayac++;
                     Console.WriteLine(toplam/sayi); 
                }

                //A'den Z'ye kadar tüm harfleri console'dan yazdır.
                char character='a';
                while (character<'z')
                {
                     Console.WriteLine(character);
                     character++;
                }    
                string[] cars={"Bmw","Ford","Toyota","Nissan"};
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
                         
            }
        }
    }

