import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class Main {

    public static void main(String[] args) {
        ArrayList<String> cities = new ArrayList<String>();
        cities.add("Gaziantep");
        cities.add("istanbul");
        cities.add("Ankara");
        cities.add("Diyarbakır");

        cities.remove("Gaziantep");
        Collections.sort(cities);


        for (String city : cities){
            System.out.println(city);
        }
    }
}
