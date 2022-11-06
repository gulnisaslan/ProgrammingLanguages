using Northwind.DataAccess.Concreate;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NorthWind.DataAccess.Abstract;
using Northwind.Business.Abstract;
using System.Data.Entity.Infrastructure;
using Northwind.Business.Validation.FluentValidation;
using FluentValidation;
using Northwind.Business.Utilities;

namespace Northwind.Business.Concreate
{
    public  class ProductManager:IProductService
    {
       private  IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            
                _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {

                throw new Exception("Silme Gerçekleşemedi");
            }
            
        }

        public List<Product> GetAll()
        {
            //Business code

            return _productDal.GetAll();


        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryId);
            
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p=>p.ProductName.ToLower().Contains(productName.ToLower()));
            
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
