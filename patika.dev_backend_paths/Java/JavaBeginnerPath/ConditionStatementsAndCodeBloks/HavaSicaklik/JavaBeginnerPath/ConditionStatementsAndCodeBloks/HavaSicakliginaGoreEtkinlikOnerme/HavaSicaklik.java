package JavaBeginnerPath.ConditionStatementsAndCodeBloks.HavaSicakliginaGoreEtkinlikOnerme;

import java.util.Scanner;

public class HavaSicaklik {
    public static void main(String[] args) {
        int derece ;
        Scanner scanner = new Scanner(System.in);
        System.out.print("Hava sıcaklığını giriniz: ");
        derece = scanner.nextInt();
        String  etkinlik = derece < 5 ? "Kayak" :
         derece >= 5 && derece <15 ? "Sinema" :
         derece >=15 && derece <25 ? "Piknik" : "Yüzme";
        System.out.println(etkinlik);
    }
}
