import java.util.Scanner;

public class CinZodyagi {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Dogum tarihinizi giriniz: ");
        int dogumYili =scanner.nextInt();

        
            if(dogumYili% 12 ==0){
                System.out.println(HayvanIsimleri.MAYMUN);
            }
            if(dogumYili% 12 ==1){
                System.out.println(HayvanIsimleri.HOROZ);
            }
            if(dogumYili% 12 ==2){
                System.out.println(HayvanIsimleri.KÖPEK);
            }
            if(dogumYili% 12 ==3){
                System.out.println(HayvanIsimleri.DOMUZ);
            }if(dogumYili% 12 ==4){
                System.out.println(HayvanIsimleri.FARE);
            }if(dogumYili% 12 ==5){
                System.out.println(HayvanIsimleri.OKUZ);
            }if(dogumYili% 12 ==6){
                System.out.println(HayvanIsimleri.KAPLAN);
            }if(dogumYili% 12 ==7){
                System.out.println(HayvanIsimleri.TAVSAN);
            }if(dogumYili% 12 ==8){
                System.out.println(HayvanIsimleri.EJDERHA);
            }if(dogumYili% 12 ==9){
                System.out.println(HayvanIsimleri.YILAN);
            }if(dogumYili% 12 ==10){
                System.out.println(HayvanIsimleri.AT);
            }if(dogumYili% 12 ==11){
                System.out.println(HayvanIsimleri.KOYUN);
            }
      

    }
    
}
enum HayvanIsimleri{
    MAYMUN,
    HOROZ,
    KÖPEK,
    DOMUZ,
    FARE,
    OKUZ,
    KAPLAN,
    TAVSAN,
    YILAN,
    AT,
    KOYUN,
    EJDERHA;


}
