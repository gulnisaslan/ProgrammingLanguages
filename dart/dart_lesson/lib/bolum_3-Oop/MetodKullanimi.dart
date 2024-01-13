void main(){

  void selamla(){
    String sonuc = "Merhaba ahmet";
    print(sonuc);
  }

  selamla();

  String selamla1(){
    String sonuc = "Merhaba ahmet";
    return sonuc;
  }

  String gelenSonuc = selamla1();
  print(gelenSonuc);

  void selamla2(String isim){
    String sonuc = "Merhaba $isim";
    print(sonuc);
  }

  selamla2("Zeynep");

  void toplama(){
    int toplam = 30 + 40;
    print("Toplama : $toplam");
  }

  toplama();

  int toplama1(){
    int toplam = 30 + 90;
    return toplam;
  }

  int t1 = toplama1();
  print("Toplama1 : $t1");

  int toplama2(int sayi1,int sayi2) {
    int toplam = sayi1 + sayi2;
    return toplam;
  }

  int t2 = toplama2(100,200);
  print("Toplama2 : $t2");

}