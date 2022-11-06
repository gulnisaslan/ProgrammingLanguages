public class Main {

    public static void main(String[] args) {
        char grade = 'B';

        switch (grade) {
            case 'A':
                System.out.println("mükemmel : geçtiniz.");
                break;
            case 'B':
            case 'C':
                System.out.println("iyi: geçtiniz.");
                break;
            case 'D':
                System.out.println("idare eder : geçtiniz.");
                break;
            case 'F':
                System.out.println("sınıfta kaldınız.");
            default:
                System.out.println("gecersiz not girdiniz.");
        }
    }
}
//ctrl+shift+alt+l