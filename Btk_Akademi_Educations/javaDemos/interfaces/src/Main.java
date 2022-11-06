public class Main {

    public static void main(String[] args) {
     /*  ICustomerDal customerDal = new MysqlCustomerDal();
       customerDal.add();*/
        CustomerManager customerManager = new CustomerManager(new OracleCustomerDal());
       customerManager.add();
//        customerManager.customerDal = new SqlCustomerDal();




    }
}
