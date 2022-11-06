using Northwind.Business.Abstract;
using Northwind.Entities.Concreate;
using NorthWind.DataAccess.Abstract;
using NorthWind.DataAccess.Abstract.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concreate
{
    public class CategoryManager : ICategoryService
    {
       ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
