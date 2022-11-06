using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }//tamamlanmış metot
        public abstract void Delete();
        //tamamlanmamış metot
    }
    class SqlServer : DataBase
    {
        public override void Delete()
        {
           Console.WriteLine("Deleted by Sql");
        }
    }
    class Oracle : DataBase
    {
        public override void Delete()
        {
           Console.WriteLine("Deleted by Oracle");
        }
    }

}
//databaseler interface gibi yazamıyoruz örnek yukarıdadır.
//abstract class herbiri interihance özelliği taşır