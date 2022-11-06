using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Merve";
            //string student2 = "Gülnisa";
            //string student3 = "Ercan";

            string[] students = new string[3] { "Merve", "Gülnisa", "Ercan" };
            students[0] = "Merve";
            students[1] = "Gülnisa";
            students[2] = "Ercan";

            string[] students2 = { "Merve", "Gülnisa", "Ercan" };//new[]
                                                                 // students2[3] = "ahmet";


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 4]
            {
                 {"İstanbul","Bursa","Sakarya","Balıkesir"},
                 {"mersin","antalya","adana","osmaniye"},
                 {"gaziantep","urfa","adıyaman","mardin"},
                 {"konya","ankara","çankırı","kayseri"},
                 {"erzurum","erzincan","malatya","elazığ"},
                 {"rize","bartın","samsun","trabzon"},
                 {"izmir","manisa","aydın","çanakkale"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************************");
            }

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
