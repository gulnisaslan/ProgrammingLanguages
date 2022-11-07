package JavaBeginnerPath.ConditionStatementsAndCodeBloks.ArtikYili;

import java.util.Scanner;

public class ArtikYili {
            
    public static void main(String[] args) {
        Scanner  scanner = new Scanner(System.in);
        System.out.print("Yılı Giriniz: ");
        int year = scanner.nextInt();

        if(year % 4==0){
            System.out.println(year+ " Artık yıldır.");
        } 
        if(year % 4 == 1){
            System.out.println(year + " Artık yıl değildir.");
        }           
    }
}
