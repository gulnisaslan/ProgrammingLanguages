public class Main {

    public static void main(String[] args) {
	    CustomerManager customerManager = new CustomerManager();
	    customerManager.dataBaseManager = new OracleDatabaseManager();
       // customerManager.dataBaseManager = new SqlServerDatabaseManager();
        customerManager.dataBaseManager = new MySqlDataBaseManager();

	    customerManager.getCustomer();


    }
}
