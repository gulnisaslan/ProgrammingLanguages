public class Product {

    public Product(int id,String name,String description,double price,int stockAmount,String colour){
        System.out.println("yapıcı blok Çalıştı");
        this.id=id;
        this.name=name;
        this.description=description;
        this.stockAmount=stockAmount;
        this.price=price;
        this.colour=colour;

    }//overloading aşırı yükleme
    public  Product(){

    }
     //parametresiz constructortır.

    //attribue|field
    private int id;
    private String name;
    private String description;
    private double price;
    private int stockAmount;
    private String colour;
    String code;
//getter
  public int getId(){
      return id;
  }
  //setter
  public void setId(int id){
      this.id = id;
  }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getStockAmount() {
        return stockAmount;
    }

    public void setStockAmount(int stockAmount) {
        this.stockAmount = stockAmount;
    }

    public String getColour() {
        return colour;
    }

    public void setColour(String colour) {
        this.colour = colour;
    }

    public String getCode() {
        return this.name.substring(0,1)+id ;
    }

    public void setCode(String code) {
        this.code = code;
    }
}
//urun nesnesi özellik tutuyor .
//bu publictir... herkes tarafında kulllanılır
//private tanımlandığı blokta geçerlidir.
//this product id's
// kolay yoldan encapsulation yapabilmek için sağ tıklayıp refactore basıp encapsulation yaptıgında istediklerin yaptıktan sonra getter ve setter kullanabilirsin.