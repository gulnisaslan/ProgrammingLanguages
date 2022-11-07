

import java.util.Scanner;

public class KullaniciGirisi {
    public static void main(String[] args) {
        String username,password ;
     
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter Username: ");
        username = scanner.nextLine();
        System.out.print("Enter password: ");
        password =  scanner.nextLine();
        
        if(username.equals("gülnisa") && password.equals("123456")){
            System.out.println("Giriş Başarılı!!");
        }else{
            System.out.println("Kullanıcı Adınız veya Şifreniz lazım");
            System.out.print("Şifreniz yenilemek ister misiniz?");
            String answer = scanner.nextLine();
            String newPassword = scanner.nextLine();
            if(answer.equals("E")){
                if(newPassword.equals("123456")){
                    System.out.println("Önceki şifreniz ile aynı olamaz.");
                }else{
                    System.out.println("Şifreniz Yenilendi");
                    password = newPassword;
                }
            }
            else{
                System.out.println("Çıkış yapıldı");
              
            }
        }






    }
}


