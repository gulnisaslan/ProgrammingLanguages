using Northwind.DataAccess.Concreate.EntityFramework;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract.EntityFramework
{
    public  class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
