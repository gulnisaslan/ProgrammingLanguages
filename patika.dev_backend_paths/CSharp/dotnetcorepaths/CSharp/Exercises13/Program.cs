namespace Exercises13;
class Program
{
    static void Main(string[] args)
    {

        /*
        erişim_belirteci geri_donus_tipi  metod_adi(parametreler/arg){
            return
            ----------+
        }
        
        */
      int x = 25;
      int y = 10;
      int topla =  Topla(x,y);
      System.Console.WriteLine(topla);

      //--------------------------------------------
      Metodlar metodlar =  new Metodlar();
      string salute ="merhaba .netcore";
    // metodlar.EkranYazdr(Convert.ToString(topla));
     // string ss =  metodlar.EkranYazdr(salute);
       metodlar.ArtirVeTopla(x,y);
     
      System.Console.WriteLine(ss);
      
     }
    static int Topla(int x,int y){
        return(x+y);
    }
}
class Metodlar
{
    public void EkranYazdr(string veri){
        System.Console.WriteLine(veri);
    }

    public int ArtirVeTopla(int d1,int d2){
        d1 += 1;
        d2 += 3;
        return d1 + d2;
    }
}
