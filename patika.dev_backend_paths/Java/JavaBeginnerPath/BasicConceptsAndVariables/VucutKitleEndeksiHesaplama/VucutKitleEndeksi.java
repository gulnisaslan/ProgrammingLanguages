package JavaBeginnerPath.BasicConceptsAndVariables.VucutKitleEndeksiHesaplama;

import java.util.Scanner;

public class VucutKitleEndeksi {
    public static void main(String[] args) {
        double boy, kilo ; 
        Scanner input = new Scanner(System.in);

        System.out.print("Boyunuz Girin: ");
        boy = input.nextInt();
        System.out.print("Kilonunuz Girin: ");
        kilo =input.nextInt();

        double sonuc = kilo / (boy * boy);

        System.out.println("Vucut kitle Endeksiniz: " + sonuc);
    }
    
}
