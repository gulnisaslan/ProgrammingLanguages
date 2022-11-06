public class Main {

    public static void main(String[] args) {
       Product product = new Product(1,"laptop","asus",5500,5,"black");
       /* Product product = new Product();
       product.setName("Laptop");
        product.setId(1);
        product.setDescription("HP LAPTOP");
        product.setPrice(5000);
        product.setStockAmount(50);
      // product.getId();
        System.out.println(product.getName());
        product.setId(1);*/



       ProductManager productManager = new ProductManager();
       productManager.Add(product);
       System.out.println(product.getCode());



    }

}
// bir classın tek bir görevi olur.
//encapsulation
     /*  productManager.Add2(1,"","",2,40);
       productManager.Add2(1,"","",2,40);
       productManager.Add2(1,"","",2,40);
       productManager.Add2(1,"","",2,40);
       productManager.Add2(1,"","",2,40);*/
//yukardaki işlem hatalı.