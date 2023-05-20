import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        double  price = 2.20;
        Scanner in = new Scanner(System.in);
        Double km = in.nextDouble();
        Double result = 10.0;

        double tutar =  km < 1 ? 20.0: result+(km*price);
        System.out.println(tutar);

    }
}
