package JavaBeginnerPath.ConditionStatementsAndCodeBloks.HesapMakinesi;

import java.util.Scanner;

public class HesapMakinesi {
    public static void main(String[] args) {
        int sayi1,sayi2,select;
     
        Scanner scanner = new Scanner(System.in);

        sayi1 = scanner.nextInt();
        sayi2 = scanner.nextInt();
       select = scanner.nextInt();

        switch (select) {
            case 1 :
                System.out.println("Toplam : " + (sayi1 + sayi2) );
                break;
            case 2:
                System.out.println("Cıkarma : " +(sayi1 - sayi2));
                break;
            
            case 3:
                System.out.println("Bölme : " +(sayi1 / sayi2));
                break;
            case 4:
                System.out.println("Çarpma: " +(sayi1 * sayi2));
                break;
        
            default:
                System.out.println("Geçersiz işlem yaptınız.");
                break;
        }

        
    }
    
}
