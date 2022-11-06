using Northwind.Entities.Concreate;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Abstract.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concreate.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    
    }
}
//veritabanı işleri yaplır.

    