using System;

namespace Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchAndFinally();
            TryCatchAndFinally1();
            TryCatchAndFinally2();
            TryCatchAndFinally3();
        }
        public static void TryCatchAndFinally(){
    // Try catch blokları sayesinde uygulama içerisinde bir hata oluştuğunda belirtilen işlemler yaptırılabilir.
    // try{ Hataya sebebiyet verme ihtimali olan kod }
    // catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
    // finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Girmiş olduğunuz sayı: {sayi}");
                 
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hata mesajı: {ex.Message.ToString()}");
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla onaylandı.");
            }
        }

        public static void TryCatchAndFinally1(){
           try
            {
             int a=int.Parse(null);
                 
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Boş değer girdiniz: {ex}");
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla onaylandı.");
            }
        }

        public static void TryCatchAndFinally2(){
           try
            {
             int a=int.Parse("test");
                 
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Veri tipi uygun değil: {ex}");
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla onaylandı.");
            }
        }
        public static void TryCatchAndFinally3(){
           try
            {
             int a=int.Parse("-200000000000");
                 
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"Çok küçük yada çok büyük bir değer girdiniz: {ex}");
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla onaylandı.");
            }
        }
    }
    
}
