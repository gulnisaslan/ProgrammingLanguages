using System;


namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           CustomerManager customerManager=new CustomerManager( );
           customerManager.Add(
               new Customer{
                   FirstName="Gülnisa",
                   LastName="Aslan",
                   Identity="12222",
                   CityId=27
                });
                 //FirstName en az iki karakter olacak
                customerManager.Add(
               new Customer{
                   FirstName="Ercan",
                   LastName="Aslan",
                   Identity="122223",
                   CityId=27
                });
                customerManager.Add(
               new Customer{
                   FirstName="Semih Sercan",
                   LastName="Aslan",
                   Identity="12222",
                   CityId=27
                });
        }
    }

    class CustomerManager{
        
         CustomerDal customerDal=new CustomerDal();
        public void Add(Customer customer){
             Validate(customer);
              if(!customerDal.CustomerExists(customer)){
                  customerDal.Add(customer);
            }
            
        }
        public void  AddByOtherBusiness(Customer customer){
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);
            ValidateFirstNameLength(customer);
            if(!customerDal.CustomerExists(customer)){
                  customerDal.Add(customer);
            }
            

        }
        //Hatalı kullanım 47 ile 55 satırlar arası
          private  void Validate(Customer customer){
             if( String.IsNullOrEmpty(customer.FirstName)||
             String.IsNullOrEmpty(customer.LastName)||
             String.IsNullOrEmpty(customer.Identity))
             {
                    throw new Exception("Validasyon hatası oldu");
            }
        }

        private  void ValidateFirstNameIfEmpty(Customer customer){
             if( String.IsNullOrEmpty(customer.FirstName)){
                    throw new Exception("Validasyon hatası oldu");
            }
        }

          private  void ValidateLastNameIfEmpty(Customer customer){
             if( String.IsNullOrEmpty(customer.LastName)){
                    throw new Exception("Validasyon hatası oldu");
            }
        }
          private  void ValidateIdentityIfEmpty(Customer customer){
             if( String.IsNullOrEmpty(customer.Identity)){
                    throw new Exception("Validasyon hatası oldu");
            }
        }


        private  void ValidateFirstNameLength(Customer customer){
             if( customer.FirstName.Length<2){
                    throw new Exception("Validasyon hatası oldu");
            }
        }

    }
    interface ICustomerDal
    {
       void Add(Customer customer);
       bool CustomerExists(Customer customer);
    }

     public class EfCustomerDal : ICustomerDal
     {
          void Add(Customer customer)
          {
               throw new NotImplementedException();
          }

          bool CustomerExists(Customer customer)
          {
               throw new NotImplementedException();
          }
     }
     class CustomerDal{
        private DatabaseType _databaseType;

          public CustomerDal(DatabaseType databaseType)
          {
              _databaseType=databaseType;
          }

          public void Add(Customer customer){
            if (_databaseType==DatabaseType.Oracle)
            {
                Console.WriteLine("NHibernate kullanarak veritabanına eklendi");
            }
            else{
                System.Console.WriteLine("Entityframework kullanarak eklendi.");
            }
        }
        public bool CustomerExists(Customer customer){
            return true;
        }
    }
    class Customer{

        public int Id { get; set; }
        public int CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }

    }
    
}
