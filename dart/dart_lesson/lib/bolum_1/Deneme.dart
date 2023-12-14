
class Deneme {
  int x = 10; //Global Değişkenler
  int y = 20; //Global Değişkenler

  void topla(){
    int x = 40;//Local değişken Global değişkene baskın gelir.

    x = x + y; // 40 + 20 = 60
    print(x);
  }

  void carpma(){
    x = x * y; // 10 * 20 = 200
    print(x);
  }

}

