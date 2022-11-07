package JavaBeginnerPath.ConditionStatementsAndCodeBloks.UcakBiletiHesaplama;

import java.util.Scanner;

public class UcakBiletiHesaplama {
    public static void main(String[] args) {
        Scanner scanner =  new Scanner(System.in);
        int yas,km,yolculukTipi;
        System.out.print("Yasınız Giriniz: ");
        yas = scanner.nextInt();
        System.out.print("Mesafeyi km turunden Giriniz: ");
        km = scanner.nextInt();
        System.out.print("Gidis icin 1,Gidiş -Donus için 2'yi Giriniz: "); 
        yolculukTipi= scanner.nextInt();

        Double tutar = km * 0.10;
   

        if(km <0 || yolculukTipi>2 && yolculukTipi<0){
            System.out.println("Hatalı veri girdiniz.");
        }
        else{
            if(yas<12){
                Double discount = (tutar *0.50)*yolculukTipi;
                System.out.println(discount+" %50 indirim uygulanmıştır.");
                cond(discount, yolculukTipi);
            }
            if(yas>=12 || yas<=24){
                Double discount = (tutar *0.10)*yolculukTipi;
                System.out.println(discount+" %10 indirim uygulanmıştır.");
                cond(discount, yolculukTipi);
            }
            if(yas>65){
               
                Double discount = (tutar *0.30)*yolculukTipi;
                System.out.println(discount+" %30 indirim uygulanmıştır.");
                cond(discount, yolculukTipi);
               
            }
        }
        
    }
    public static void cond(Double discount,int yolculukTipi) {
        if(yolculukTipi==2){
            Double plusDiscount = discount * 0.20;
            System.out.println(plusDiscount + " %20 ek indirim uygulanmıştır.");

        }
        
    }
}
