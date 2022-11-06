import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DbHelper {
    private   String userName="root";
    private String password = "30011971";
    private  String dbUrl="jdbc:mysql://localhost:3306/northwind?useSSl=false&useUnicode=true&useJDBCCompliantTimezoneShift=true&useLegacyDatetimeCode=false&serverTimezone=UTC";
    public Connection getConnection() throws SQLException {
        return  DriverManager.getConnection(dbUrl,userName,password);
    }
    public void showErrorMessage(SQLException exception){
      System.out.println("Error : " + exception.getMessage());
      System.out.println("Error Code : " + exception.getErrorCode());
    }
}
