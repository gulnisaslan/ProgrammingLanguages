using System;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("*****Type Conversions*******");
             ImplicitConversion();
             ExplicitConversion();
             ToStringMethods();
             SystemConvertClass();
             ParseMethods();

        }
        public static void ImplicitConversion(){
            Console.WriteLine("******Implicit Conversion(Bilinçsiz Dönüşüm)*********");
            Console.WriteLine("Not:Düşük kapasiteli bir değişkenin  yüksek kapasiteli değişkene atanmasıdır.");
            byte a=5;
            sbyte b=30;
            short c=10;

            int d = a+b+c;
            Console.WriteLine("d: "+d);
            long h =d;
            Console.WriteLine("h: "+h);
            float i=h;
            Console.WriteLine("i: " +i);
            string e="Zikriye";
            char f='k';

            object g=e+f+h;
            Console.WriteLine("g: "+g);


        }
         public static void ExplicitConversion(){
            Console.WriteLine("******Explicit Conversion(Bilinçsiz Dönüşüm)*********");
            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y:" +y);

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t:" +t);

            float w=10.3f;
            byte c=(byte)w;//verikaybına sebep olur.
            Console.WriteLine("c:" +c);

        }
        public static void ToStringMethods(){
            Console.WriteLine("***********ToString Method*********");
            int x=6;
            string y=x.ToString();
            Console.WriteLine("y: "+ y);

            string z=12.5f.ToString();
               
            Console.WriteLine("z:" +z);
        }
   
        public static void SystemConvertClass(){
            Console.WriteLine("********System.Convert Class*******");
            string metin1="10",metin2="20";
            int sayi1;
            sayi1=Convert.ToInt32(metin1);
            int sayi2;
            sayi2=Convert.ToInt32(metin2);
            int toplam=sayi1+sayi2;
            Console.WriteLine("Toplam: " + toplam);
        }

        public static void ParseMethods(){
            Console.WriteLine("*********Parse Method******** ");
            string metin1= "10";
            string metin2=  "10,25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            Console.WriteLine(rakam1);
            double1=Double.Parse(metin2);
            Console.WriteLine(rakam1);
        }
    
    }
}
