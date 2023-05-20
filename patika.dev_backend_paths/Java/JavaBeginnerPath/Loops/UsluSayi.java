import java.util.Scanner;

public class UsluSayi {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int sayi,ussu;
        ussu = in.nextInt();
        sayi = in.nextInt();
       int result = 1;
       for (int i = 0; i < ussu; i++) {
          result *=sayi;
       }
       System.out.println(result);
    }
}
