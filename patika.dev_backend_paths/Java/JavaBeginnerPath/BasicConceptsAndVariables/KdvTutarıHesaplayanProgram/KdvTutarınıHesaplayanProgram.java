package JavaBeginnerPath.BasicConceptsAndVariables.KdvTutarıHesaplayanProgram;

import java.util.Scanner;

/**
 * KdvTutarınıHesaplayanProgram
 */
public class KdvTutarınıHesaplayanProgram {

    public static void main(String[] args) {
        double tutar ,kdv=0.18;
        Scanner input = new Scanner(System.in);

        System.out.print("Tutarı giriniz: ");
        tutar = input.nextInt();
        double kdvTutar = tutar * kdv;
        double kdvliTutar = kdvTutar + tutar;
        System.out.println("Kdv'li Tutar: " + kdvliTutar);

        /* Ödev
        Eğer girilen tutar 0 ve 1000 TL arasında ise KDV oranı %18 ,
        tutar 1000 TL'den büyük ise KDV oranını %8 olarak KDV tutarı 
        hesaplayan programı yazınız. */

        double result =tutar>0 && tutar<1000 ? tutar * 0.18 : tutar * 0.8;
        System.out.println("Kdv Oranı: " + result);
    }
}