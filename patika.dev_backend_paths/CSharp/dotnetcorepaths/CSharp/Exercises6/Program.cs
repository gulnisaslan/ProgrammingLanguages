using System;

namespace Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            IfElse();
            TernaryOperator();
        }
        public static void IfElse(){
            int time= DateTime.Now.Hour;
            if (time>=6 && time <=11 )
            {
                Console.WriteLine("Gününüz aydın olsun efendim :)");
            }
            else if(time <=18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }
        }

        public static void TernaryOperator(){
            int time= DateTime.Now.Hour;
            string sonuc= time <= 18 ? "İyi günler":"iyi geceler";
            string sonuc2=time>=6&&time<=11?"Gününüz aydın olsun efendim :)":time<=18?"İyi günler":"İyi geceler";

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
        }

    }
}
