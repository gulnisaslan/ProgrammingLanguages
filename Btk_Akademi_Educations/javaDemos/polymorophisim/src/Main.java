public class Main {

    public static void main(String[] args) {
      /* EmailLogger emailLogger = new EmailLogger();
        emailLogger.Log("Log Mesajı");*/
//        BaseLooger[] loogers = new BaseLooger[]{new EmailLogger(),new DatabaseLogger(),new EmailLogger(),new BaseLooger(),
//        new ConsoleLogger()};
//        for (BaseLooger looger: loogers){
//            looger.Log("Log Mesajı");
        //}
        CustomerManager customerManager = new CustomerManager(new FileLogger());
        customerManager.add();
    }
}
//loglama yazılım hazırlarken kullanılır
//overriding: