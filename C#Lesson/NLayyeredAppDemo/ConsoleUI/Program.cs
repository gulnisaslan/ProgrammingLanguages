using Northwind.Business.Concreate;
using NorthWind.DataAccess.Abstract.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            categoryManager.GetAll(); ;
        }
    }
}
