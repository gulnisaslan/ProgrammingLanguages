void main(){

  int gun = 3;
  switch ( gun ){
    case 1 : {
      print("Pazartesi");
    }
    break;

    case 2 : {
      print("Salı");
    }
    break;

    case 3 : {
      print("Çarşamba");
    }
    break;

    case 4 : {
      print("Perşembe");
    }
    break;

    case 5 : {
      print("Cuma");
    }
    break;

    case 6 : {
      print("Cumartesi");
    }
    break;

    default: { print("Böyle bir gün yok"); }
    break;
  }

  int x = 5;
  switch ( x ){
    case 1 : {
      print("x 1'e eşittir");
    }
    break;

    case 2 : {
      print("x 2'e eşittir");
    }
    break;

    default: { print("x 1 ve 2'e eşit değildir"); }
    break;
  }



}