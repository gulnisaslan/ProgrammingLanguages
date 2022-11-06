public class Main {

    public static void main(String[] args) {
        // bug =mantıksal hatalar
        int number = 1;

        boolean isPrime = true;
        if (number == 1) {
            System.out.println("sayı asal değildir.");
            return;
        }
        if (number < 2) {
            System.out.println("Geçersiz Sayı");
        }

        for (int i = 2; i < number; i++) {
            if (number % i == 0) {
                isPrime = false;
            }

        }
        if (isPrime == true) {
            System.out.println("Sayı asaldır.");
        } else {
            System.out.println("Sayı asla degildir.");
        }

    }
}
