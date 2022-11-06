public class Main {

    public static void main(String[] args) {
        String ogrenci1 ="Gülnisa";
        String ogrenci2 ="derin";
        String ogrenci3 ="hale";
        System.out.println(ogrenci1);
        System.out.println(ogrenci2);
        System.out.println(ogrenci3);

        System.out.println("**********************");
        String[] ogrenciler=new String[4];
        ogrenciler[0]="Gülnisa";
        ogrenciler[1]="Hale";
        ogrenciler[2]="jale";
        ogrenciler[3]="Kübra";
        //ogrenciler[4]="nisa";//dize sınırları

        for (int i=0;
        i< ogrenciler.length;i++){
            System.out.println(ogrenciler[i]);
        }
        System.out.println("**********************");
        for (String ogrenci:ogrenciler){
            System.out.println(ogrenci);
        }




    }
}
