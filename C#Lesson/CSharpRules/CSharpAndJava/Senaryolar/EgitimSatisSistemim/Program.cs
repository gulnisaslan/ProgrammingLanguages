using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimSatisSistemim
{
    class Program
    {
        static void Main(string[] args)
        {
            IEgitimService egitimService = new EgitimManager(new EfEgitimDal());
            foreach (var egitim in egitimService.ListeleEgitimler())
            {
                Console.WriteLine(egitim.Ad);
                Console.WriteLine(egitim.Fiyat);

            }
            Console.ReadLine();
        }

    }
    class Egitim:IEntity
    {
        public int Id { get; set; }
        public string  Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    public interface IEntity
    {
    }

    class EgitimManager:IEgitimService
    {
        private IEgitimDal _egitimDal;
        public EgitimManager(IEgitimDal egitimDal)
        {
            _egitimDal = egitimDal;
        }

        public List<Egitim> ListeleEgitim()
        {
            return _egitimDal.ListeleEgitimler();
        }

    
    }
    interface IEgitimDal
    {
        List<Egitim> ListeleEgitimler();
    }
    class EfEgitimDal : IEgitimDal
    {
        public List<Egitim> ListeleEgitimler()
        {

            return new List<Egitim>
            {
                new Egitim{Id=1,Ad="C# Kursu",Fiyat=200},
                new Egitim{Id=1,Ad="Python kursu",Fiyat=100},
                new Egitim{Id=1,Ad="php Kursu",Fiyat=200}


            };
        }
    }

    public interface IEgitimService
    {
        List<Egitim> ListeleEgitim();
    }
}
