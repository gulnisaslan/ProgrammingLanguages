import java.util.Scanner;

public class FactorialCalculate {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int r = input.nextInt();
        int minusfaktoriyel = 1;
        int nfaktoriyel = 1;
        int rFaktoriyel = 1;
        for (int i = 1; i <=n; i++) {
           nfaktoriyel *=i;
            
        }
        for (int i = 1; i <=r; i++) {
            rFaktoriyel *=i;
             
         }
         for (int i = 1; i <= (n-r); i++) {
            minusfaktoriyel *=i;
            
         }
         int kombinasyon = nfaktoriyel/(rFaktoriyel*minusfaktoriyel);
         System.out.println(kombinasyon);
         
    }
}
