import 'package:dart_lesson/bolum_3-Oop/Renkler.dart';

void main(){

  var renk = Renkler.Beyaz;

  switch(renk){
    case Renkler.Beyaz:{
      print("#FFFFFFF");
    }
    break;

    case Renkler.Siyah:{
      print("#000000");
    }
    break;
  }


}