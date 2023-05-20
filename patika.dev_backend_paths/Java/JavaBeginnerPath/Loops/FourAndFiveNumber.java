import java.util.Scanner;

public class FourAndFiveNumber {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Kuvvetinin alınması için kullanılan sayıyı giriniz: ");
        int sayi = input.nextInt();
        System.out.println("------------------------------");
        System.out.print("Kuvvetinin alınacagı sayıyı giriniz: ");
        int n = input.nextInt();
        
        for (int i = 1; i <= n; i*=sayi) {
            System.out.println(i);
            
        }
    }
    
}
