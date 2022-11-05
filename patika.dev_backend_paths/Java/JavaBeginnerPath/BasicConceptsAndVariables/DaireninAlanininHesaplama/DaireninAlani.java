package JavaBeginnerPath.BasicConceptsAndVariables.DaireninAlanininHesaplama;

import java.util.Scanner;

public class DaireninAlani {
    public static void main(String[] args) {
        double pi = 3.14;
        int alfa,r;
        double parcaAlani;

   
        Scanner s = new Scanner(System.in);
        System.out.print("radius degerini giriniz: ");
        r = s.nextInt() ;
        System.out.print("alfa degerini giriniz: ");
        alfa = s.nextInt() ;
        double alan = pi * r * r;
        double cevre = 2 * pi * r;
        
        System.out.println("Dairenin Alanı : " + alan);
        System.out.println("Dairenin çevresi : " + cevre);

        parcaAlani = (pi*(r*r)*alfa)/360;
        System.out.println("Parca alanı :" + parcaAlani);

    }
}
