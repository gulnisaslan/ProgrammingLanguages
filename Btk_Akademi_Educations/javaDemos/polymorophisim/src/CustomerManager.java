public class CustomerManager{
    private BaseLooger looger;

    public CustomerManager(BaseLooger looger){
        this.looger = looger;
    }
    public void add(){
        System.out.println("müsteri eklendi");
        this.looger.log("log mesajı");
    }
}
