namespace Algortihm_Homework_1;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Liste uzunluğunu giriniz: ");  
        int num =Convert.ToInt32( Console.ReadLine());
        /*System.Console.Write("Bölen sayıyı giriniz: ");  
        int nums =Convert.ToInt32( Console.ReadLine());*/
        ReverseSentence(num);
        //Karsilastirma(num,nums);
      // PositiveNumber(num);
        
    }
    /*
    Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan
     n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    */
    public static void PositiveNumber(int n){
        List<int> numbers =  new List<int>();
        List<int> nums = new List<int>();
      
        for (int i = 0; i < n; i++)
        { 
            System.Console.Write("Listeye sayıları giriniz: ");  
            int num =Convert.ToInt32( Console.ReadLine());
            numbers.Add(num);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i]%2==0)
            {
                nums.Add(numbers[i]);
            }
        }
        foreach (var item in nums)
        {
            System.Console.WriteLine(item);
        }
    }
    /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
     Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
    public static void Karsilastirma(int n,int m){
        List<int> numbers =  new List<int>();
          List<int> nums = new List<int>();
      
        for (int i = 0; i < n; i++)
        { 
            System.Console.Write("Listeye sayıları giriniz: ");  
            int num =Convert.ToInt32( Console.ReadLine());
            numbers.Add(num);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i]==m||numbers[i]%m==0)
            {
               nums.Add(numbers[i]); 
            }
        }
        foreach (var item in nums)
        {
            System.Console.WriteLine(item);
        }


    }
    

    /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
     Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
     Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

     public static void ReverseSentence(int n){
        List<string> kelimeler =  new List<string>();
        for (int i = 0; i < n; i++)
        {
           System.Console.Write("Kelimeleri giriniz: ");
           string sentence = Console.ReadLine(); 
           kelimeler.Add(sentence);
        }
        
        for (int i = kelimeler.Count - 1; i >= 0 ; i--)
        {
            System.Console.WriteLine(kelimeler[i]);
        }
     }
     /*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
      Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
      public static void SumSentenceAndChar(int n){
       

           
    }
}
