//built in


//import matematik.Dortislem;
//import matematik.Logaritma;
import matematik.*;
import java.util.Scanner;
public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("الاسمك: ");
        String  isim = scanner.nextLine();
        System.out.println("اهلان و سهلان"+" "+isim);
        Dortislem dortislem = new Dortislem();
        dortislem.toplam(2,3);
        Logaritma logaritma = new Logaritma();

    }
}
