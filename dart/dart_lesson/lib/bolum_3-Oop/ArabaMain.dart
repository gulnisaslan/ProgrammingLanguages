import 'package:dart_lesson/bolum_3-Oop/Araba.dart';

void main(){

  var bmw = Araba();

  //Değer atama
  bmw.renk = "Mavi";
  bmw.hiz = 200;
  bmw.calisiyormu = true;

  //Değer Okuma
  print(bmw.renk);//Mavi
  print(bmw.hiz);//200
  print(bmw.calisiyormu);//true

  bmw.durdur();
  bmw.bilgiAl();

  bmw.calistir();
  bmw.bilgiAl();

  bmw.hizlan(50);
  bmw.bilgiAl();

  bmw.yavasla(20);
  bmw.bilgiAl();

  var limuzin = Araba();

  //Değer atama
  limuzin.renk = "Siyah";
  limuzin.hiz = 0;
  limuzin.calisiyormu = false;

  //Değer Okuma
  print(limuzin.renk);//Siyah
  print(limuzin.hiz);//0
  print(limuzin.calisiyormu);//false

  limuzin.calistir();
  limuzin.bilgiAl();


}