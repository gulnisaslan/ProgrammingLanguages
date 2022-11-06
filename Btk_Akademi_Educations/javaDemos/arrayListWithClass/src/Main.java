import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        ArrayList<Customer> customers = new ArrayList<Customer>();
        Customer gulnisa = new Customer(1,"Gülnisa","Aslan");
        customers.add(gulnisa);
        customers.add(new Customer(1,"Haşim","Aslan"));
        customers.add(new Customer(1,"Gülten","Aslan"));
        customers.remove(gulnisa);
        for (Customer customer:customers) {
            System.out.println(customer.firstName);
        }
    }

}

