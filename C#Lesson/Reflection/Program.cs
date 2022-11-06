﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
           //DortIslem dortIslem = new DortIslem(2, 3);
           //Console.WriteLine(dortIslem.Topla2()) ;
           //Console.WriteLine(dortIslem.Topla(3, 4));
           
            var type = typeof(DortIslem);
           // DortIslem dortislem =  (DortIslem)Activator.CreateInstance(type,6,7);
            //  Console.WriteLine(dortislem.Topla(4, 5));
            //Console.WriteLine( dortislem.Topla2());

           var instance = (DortIslem)Activator.CreateInstance(type, 6, 7);
          Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));//getmethod() + inovke dediğimizde sadece metodu bize bulur.invonke dediğimizde instance yazmamız gerekiyor

           MethodInfo methodInfo= instance.GetType().GetMethod("Topla2");
           Console.WriteLine( methodInfo.Invoke(instance, null));
            Console.WriteLine("-----------------------");
            var metotlar = type.GetMethods();
            foreach (var info in metotlar)
            {
                Console.WriteLine("Metot Adı: {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name:{0}", attribute.GetType().Name);
                        
                }
            }
            


            Console.ReadLine();

        }
    } 
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;

        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;


        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 + _sayi2;

        }



    }
    
    class MetodNameAttribute:Attribute
    {
       public MetodNameAttribute(string name)
       {

       }
    }
    
}
