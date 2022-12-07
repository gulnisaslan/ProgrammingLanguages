using System;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            AtamaVeIslemliAtama();
            MantiksalOperatorler();
            IliskiselOperatorler();
            AritmetikOperatorler();
        }
        public static void AtamaVeIslemliAtama(){
            Console.WriteLine("------------------- Atama Ve Islemli Atama Operatorler ----------------");
            int x = 3;
            int y= 3;

            y=y+2;
            Console.WriteLine(y);
            y+= 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

        }
        public static void MantiksalOperatorler(){
            Console.WriteLine("-------------------  Mantiksal Operatorler ----------------");
            // || = veya , && = ve , !=değil

            bool isSuccess=true;
            bool isCompleted=false;

            if (isSuccess&&isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
              if (isSuccess||isCompleted)
            {
                Console.WriteLine("Great!");
            }
              if (isSuccess&& !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
        }
   
        public static void IliskiselOperatorler(){
            Console.WriteLine("-------------------  Iliskisel Operatorler ----------------");
            
            /* < = Kücüktür  > = Büyüktür
            <=  =küçük eşittir  >= =Büyük eşittir
            == eşit eşittir != eşit değildir
            */

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


        }

        public static void AritmetikOperatorler(){
            Console.WriteLine("------------------- Aritmetik Operatorler----------------");
            
            /* +,-,*,/,++,% */
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;
            Console.WriteLine(sonuc1);

            //Mod Alma
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
