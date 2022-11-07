package JavaBeginnerPath.ConditionStatementsAndCodeBloks.SayilariBuyuktenKucugeSiralama;

import java.util.Scanner;

public class SayilariKucukBuyukSiralama {
    public static void main(String[] args) {
        int num1,num2,num3;
        Scanner input =  new Scanner(System.in);
        System.out.print("1.Sayıyı giriniz: ");
        num1 = input.nextInt();
        System.out.print("2.Sayıyı giriniz: ");
        num2 = input.nextInt();
        System.out.print("3.Sayıyı giriniz: ");
        num3 = input.nextInt();
        if(num1 < num2 && num1 < num3){
            if(num2 < num3){
                System.out.println(num1+"<"+num2+"<"+num3);
            }
            else if(num3<num2){
                System.out.println(num1+"<"+num3+"<"+num2); 
            }
            else{
                System.out.println(num3+"<"+num1+"<"+num2); 
            }
        }

    }
}
