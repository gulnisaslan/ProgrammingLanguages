using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InterFaces
{
    interface ICostumerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql  Update");
        }
    }

    class OracleCustomerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle  Update");
        }
    }

    class CustomerManeger
    {
        public void Add(ICostumerDal customerDal)
        {
            customerDal.Add();
        }
    }
}