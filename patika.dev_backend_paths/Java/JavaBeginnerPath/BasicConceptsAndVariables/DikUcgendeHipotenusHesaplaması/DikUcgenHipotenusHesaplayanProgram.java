package JavaBeginnerPath.BasicConceptsAndVariables.DikUcgendeHipotenusHesaplaması;

import java.util.Scanner;

/**
 * DikUcgenHipotenusHesaplayanProgram
 */
public class DikUcgenHipotenusHesaplayanProgram {

    public static void main(String[] args) {
        // int a ,b;
        // double c;
        // Scanner scanner = new Scanner(System.in);
        // System.out.print("1.kenarı giriniz: ");
        // a = scanner.nextInt();
        // System.out.print("2.kenar: ");
        // b= scanner.nextInt();
        
        // c = Math.sqrt((a*a)+(b*b));

        
        // System.out.println(c);
        double a , b, c , s;
        double alan;
        Scanner  scanner =new Scanner(System.in);
        System.out.print("1.kenar ölçüsü");
        a = scanner.nextInt();
        System.out.print("2.kenar ölçüsü");
        b = scanner.nextInt();
        System.out.print("3.kenar ölçüsü");
        c = scanner.nextInt();
        s= (a+b+c)/2;
        alan=Math.sqrt(s*(s-a)*(s-b)*(s-c));

        System.out.println("Üçgenin alanı: " + alan);

      
    }
}