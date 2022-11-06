public class AccountManager {
   private double balance ;

   public void deposit(double amount){
       balance = getBalance() + amount;
   }
   public void withdraw(double amount) throws BalanceInSufficentException {
       if (balance>=amount){
       balance = getBalance() - amount;}
       else throw new BalanceInSufficentException("bakiye yetersiz");
   }

    public double getBalance() {
        return balance;
    }
}
