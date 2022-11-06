using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFarmeWorkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }//bu yöntem verileriniz çok olunca daha avantajlıdır.veritabanında sadece almak istediginiz veriyi alıyorsunuz.

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min &&p.UnitPrice<=max ).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.SingleOrDefault(p => p.Id == id);
                return result;
            }
        }//FirstOrDefault= birden cok ayn veri geldiğnde ilk olanı gösteriyor.
        //SingleOrDefault ise bir veriden birden fazla varsa hata firlatıp veriden birden fazla uyarısı veriyor.



        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
