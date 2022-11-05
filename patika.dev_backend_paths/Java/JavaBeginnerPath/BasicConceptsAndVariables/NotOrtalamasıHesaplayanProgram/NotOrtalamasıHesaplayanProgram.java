package JavaBeginnerPath.BasicConceptsAndVariables.NotOrtalamasıHesaplayanProgram;

import java.util.Scanner;

public class NotOrtalamasıHesaplayanProgram {
   public static void main(String[] args) {
       
        int mat,kimya,muzik,tarih,turkce,fizik;

        Scanner input = new Scanner(System.in);
        
        System.out.print("Matematik Notunuz: ");
        mat = input.nextInt();

        System.out.print("Kimya Notunuz: ");
        kimya = input.nextInt();

        System.out.print("Müzik Notunuz: ");
        muzik = input.nextInt();

        System.out.print("Tarih Notunuz: ");
        tarih = input.nextInt();

        System.out.print("Turkce Notunuz: ");
        turkce = input.nextInt();
        
        System.out.print("Fizik Notunuz: ");
        fizik = input.nextInt();

        int toplam = mat + kimya + muzik + tarih + turkce + fizik;
        double sonuc = toplam / 6.0;

        System.out.println("Not Ortalamanız : " + sonuc);

        String result = sonuc > 60.0 ? "Geçtiniz":"Kaldınız";
      System.out.println(result);

    }
    
}