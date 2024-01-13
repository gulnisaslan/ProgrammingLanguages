void main(){

  int yas = 17;
  String isim = "mehmet";

  //Örnek 1

  if ( yas >= 18){
    print("Reşitsiniz");
  }

  //Örnek 2 else

  if ( yas >= 18){
    print("Reşitsiniz");
  }else{
    print("Reşit değilsiniz");
  }

  //Örnek 3

  if (isim == "ahmet"){
    print("Merhaba ahmet");
  }else{
    print("Tanınmayan kişi");
  }

  //Örnek 4

  if (isim == "ahmet"){
    print("Merhaba ahmet");
  }else if ( isim == "mehmet"){
    print("Merhaba mehmet");
  }else{
    print("Tanınmayan kişi");
  }

  //Örnek 5 çoklu şart and

  String kullaniciAdi = "adminx";
  int sifre = 12345;

  if (sifre == 12345 && kullaniciAdi == "admin"){// true and true : true
    print("Hoşgeldiniz");
  }else{
    print("Hatalı giriş");
  }

  //Örnek 6 çoklu şart or

  int sinif = 10;

  if (sinif == 9 || sinif == 10 || sinif == 11 || sinif == 12){
    print("AYT sınavına hazırlanabilirsiniz");
  }

  //Örnek 7 kısaltma

  int a = 10;
  int b = 14;

  if ( a == b)  print("Eşit"); else  print("Eşit Değil");


}