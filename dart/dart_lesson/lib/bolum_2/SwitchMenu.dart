import 'dart:io';

void main(){

  print("Sil (1)");
  print("Ekle (2)");

  int tercih = int.parse(stdin.readLineSync());

  switch (tercih){
    case 1 : {print("Veri silindi");}break;
    case 2 : {print("Veri eklendi");}break;
    default : {print("Böyle bir işlem yok");}break;
  }


}
