namespace Exercises15;
class Program
{
    //Rekursif metodlar
    static void Main(string[] args)
    {
     //factorial
     int result = 1;
     for (int i = 1; i < 5; i++)
     {
        result = result*3;
     }
     //rekursif
     System.Console.WriteLine(result);
     Islemler instance = new Islemler();
     System.Console.WriteLine(instance.Expo(3,4));

     //Extension
     string ad = "Gulnisa Aslan";
     bool sonuc = ad.CheckWhiteSpace();
     System.Console.WriteLine(sonuc);
     if(sonuc)
        System.Console.WriteLine(ad.RemoweWithWihteSpace());
    
     System.Console.WriteLine(ad.MakeLowerCase());
     System.Console.WriteLine(ad.MakeUpperCase());

    }
}
public class Islemler
{
    public int Expo(int sayi,int us){
        if (us<2)
        {
            return sayi;
        }
        return Expo(sayi,us-1)*sayi;

    }
}

public static class Extension{
    public static bool CheckWhiteSpace(this string param){
        return param.Contains(" ");
    }
    public static string RemoweWithWihteSpace(this string param){
       string[] dizi = param.Split(" ");
       return string.Join("",dizi);
    }
       public static string MakeUpperCase(this string param){
      
       return param.ToUpper();
    }
    public static string MakeLowerCase(this string param){
      
       return param.ToLower();
    }
    
    public static string SortArray(this int[] param){
        Array.Sort(param);
        return param ;
    }
    public static string EkranaYazdir(this int[] param){
       foreach (var item in param)
       {
          System.Console.WriteLine(item);
       }
    }
    public static bool IsEven(this int param){
        return param % 2 == 0;
    }
      public static string IsEven(this string param){
        return param.Substring(0,1);
    }
}