

import java.util.LinkedList;
import java.util.Scanner;

/**
 * ThreeAndFourBetweenNumber
 */
public class ThreeAndFourBetweenNumber {
   
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int num1,sum = 0,count = 0;
        System.out.print("Sayı giriniz: ");
        num1 = scanner.nextInt();

      
        
  
        for (int i = 0; i <= num1; i++) {
            if((i % 3 == 0) && (i % 4 == 0)){
              System.out.println( sum += i);
                count++;
            }
        }

        System.out.println("Ortalama: "+sum/count);
       


    }
    
}