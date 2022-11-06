using Northwind.Entities.Concreate;
using NorthWind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DataAccess.Abstract.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {

            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1,ProductName="Laptop",QuantityPerUnit="1 in a box ",UnitPrice=5000, UnitsInStock=4}
            };
            return products;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }


}
