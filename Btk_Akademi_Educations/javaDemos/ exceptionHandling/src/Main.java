public class Main {

    public static void main(String[] args) {
//        String sehir = "Ankara";
//        int sayi  = sehir;//bu uyglama hata verir.

       try
       {
           int[] sayilar = new int[]{1,2,3};
           System.out.println(sayilar[3]);
       }
       catch (StringIndexOutOfBoundsException exception) {
           System.out.println(exception);
       }
//       catch (ArrayIndexOutOfBoundsException exception){
//           System.out.println(exception);
//       }
       catch ( Exception exception){
           System.out.println("Loglandı."+exception);
       }
       finally {
           System.out.println("ben her türlü çalışırım.");
       }


    }
}
