namespace Exercises14;
class Program
{
    //method overloading
    static void Main(string[] args)
    {
        //out
        //try parse ile birlikte kullanılır.
        string a = "9999";
        bool  sonuc=int.TryParse(a,out int sayi);
        if (sonuc)
        {
            System.Console.WriteLine("Başarılı!");
            System.Console.WriteLine(sayi);
        }else{
            System.Console.WriteLine("Başarısız");
        }

        
    
    }
}
class Methods
{
    public void Topla(int a ,int b,out int toplam){
       toplam = a+b;
    }
    public void PrintScreen(string veri){
        System.Console.WriteLine(veri);
    }
     public void PrintScreen(int veri){
        System.Console.WriteLine(veri);
    }
    
     public void PrintScreen(string veri1,string veri2){
        System.Console.WriteLine(veri1+ " " + veri2);
    }
}
