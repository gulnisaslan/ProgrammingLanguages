package JavaBeginnerPath.BasicConceptsAndVariables.ManavHesaplama;

import java.util.Scanner;

public class ManavHesaplama {
    public static void main(String[] args) {
        double armut = 2.14, elma = 3.67,
         domates = 1.11, muz = 0.97, patlican = 5.0, kilo;
        
        double armutFiyat,elmaFiyat,domatesFiyat,muzFiyat,patlicanFiyat;
         Scanner s = new Scanner(System.in);

        System.out.print("Armut kaç kilo : ");
        kilo = s.nextInt();
        System.out.print("Elma kaç kilo : ");
        kilo = s.nextInt();
        System.out.print("Domates kaç kilo : ");
        kilo = s.nextInt();
        System.out.print("Muz kaç kilo : ");
        kilo = s.nextInt();
        System.out.print("Patlıcan kaç kilo : ");
        kilo = s.nextInt();
        
        armutFiyat = kilo * armut ; 
        System.out.println(armutFiyat);

        elmaFiyat = kilo * elma ; 
        System.out.println(elmaFiyat);

        domatesFiyat = kilo * domates ; 
        System.out.println(domatesFiyat);

        muzFiyat = kilo * muz ; 
        System.out.println(muzFiyat);

        patlicanFiyat = kilo * patlican ; 
        System.out.println(patlicanFiyat);

        double sonuc = armutFiyat + elmaFiyat + domatesFiyat + muzFiyat + patlicanFiyat;

        System.out.println("Toplam Tutar: " + sonuc);
        
    }
}
