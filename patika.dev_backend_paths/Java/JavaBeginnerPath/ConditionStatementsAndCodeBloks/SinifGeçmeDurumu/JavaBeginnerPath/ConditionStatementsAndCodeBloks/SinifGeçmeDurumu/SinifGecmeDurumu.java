package JavaBeginnerPath.ConditionStatementsAndCodeBloks.SinifGeçmeDurumu;

import java.util.Scanner;

public class SinifGecmeDurumu {
    public static void main(String[] args) {
        int matematik ,fizik,kimya,turkce,muzik;
        Scanner input = new Scanner(System.in);

        System.out.print("matematik notu: ");
        matematik = input.nextInt();
        System.out.print("fizik notu: ");
        fizik=  input.nextInt();
        System.out.print("kimmya notu: ");
        kimya = input.nextInt();
        System.out.print("türkçe notu");
        turkce=input.nextInt();
        System.out.print("müzik notu");
        muzik = input.nextInt();

        double avarage = (matematik + muzik + turkce + kimya + fizik) / 5;

        if(avarage < 0 || avarage >100){
            System.out.println("Notunuz Geçersizdir. Notunuz hesaplanmadı.");

        } 
        else{
            if(avarage < 55){
                System.out.println("Sınıfta kaldınız.");
            }
            else{
                System.out.println("Sınıfı geçtiniz.");
            }
        }  
     }
}
