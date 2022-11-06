import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Main {

    public static void main(String[] args) throws IOException {
          BufferedReader reader=null;
          int total= 0;
          try {
         reader = new BufferedReader(new FileReader("D:\\gülnisaslan yazılım\\yazılım\\javaDemos\\readingFileDemo\\src\\numbers.txt" ));
         String line = null;
         while ((line = reader.readLine())!=null){
             total += Integer.valueOf(line);

         }
         System.out.println("Toplam: " + total);
          }catch (NumberFormatException e){

          }
      catch (FileNotFoundException e) {
         System.out.println(e);
      }
          /*finally {
              try{
                  reader.close();
              }
              catch (Exception e){

              }

          }*/
        finally {
            reader.close();
        }
    }
}
