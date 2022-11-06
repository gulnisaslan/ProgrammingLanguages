import java.sql.*;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        Connection connection = null;
        DbHelper helper = new DbHelper();
        Statement statement = null;
        ResultSet resultSet;


        try {
            connection = helper.getConnection();
            statement = connection.createStatement();
            resultSet = statement.executeQuery("Insert Into Products(productName,quantityPerUnit,unitPrice) values (Laptop','50',50000)");

               System.out.println("kayıt Eklendi");


        } catch (SQLException exception) {
            helper.showErrorMessage(exception);
        } finally {
            try {
                connection.close();
                System.out.println("Baglantı kapatıldı...");
            } catch (SQLException exception) {
                System.out.println(exception.getMessage());
            }
        }

    }

    public static void selectDemo() throws SQLException {
        Connection connection = null;
        DbHelper helper = new DbHelper();
        Statement statement = null;
        ResultSet resultSet;


        try {
            connection = helper.getConnection();
            statement = connection.createStatement();
            resultSet = statement.executeQuery("select productName,quantityPerUnit,unitPrice from Products");
            ArrayList<Product> products = new ArrayList<Product>();
            while (resultSet.next()) {
                products.add(new Product(resultSet.getString("productName"),
                        resultSet.getString("quantityPerUnit"),
                        resultSet.getDouble("unitPrice")));
                System.out.println(products.size());
                //  System.out.println(resultSet.getString("productName"));
            }
        } catch (SQLException exception) {
            helper.showErrorMessage(exception);
        } finally {
            try {
                connection.close();
                System.out.println("Baglantı kapatıldı...");
            } catch (SQLException exception) {
                System.out.println(exception.getMessage());
            }
        }
    }
}

