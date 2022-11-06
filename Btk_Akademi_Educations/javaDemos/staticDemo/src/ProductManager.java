import javax.swing.*;

public class ProductManager {
    public void add(Product product){
        //ProductValidator validator= new ProductValidator();
        if(ProductValidator.isValid(product)) {
            System.out.println("Eklendi");
        }
        else{
            System.out.println("ürün bilgileri eklenemedi");
        }
//         ProductValidator productValidator = new ProductValidator();
//        productValidator.bisey();

    }
}
//Manager sınıfları  hiçbir zaman static olmaz.
//static yaptıgımız yer program kapanan kadar bellekte kalır.
//kullan bırak araçları static yazarız.