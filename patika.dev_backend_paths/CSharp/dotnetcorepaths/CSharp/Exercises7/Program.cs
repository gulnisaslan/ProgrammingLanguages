using System;

namespace Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchCase();
        }

        public static void SwitchCase(){
            
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case  2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Agustos ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Hatalı veri.");
                    break;
            }
            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesiniz");
                    break;
                
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesiniz");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimindesiniz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz");
                    break;  
                
                default:
                    Console.WriteLine("Yanlış bilgi");
                    break;  
            }
        }
    }
}
