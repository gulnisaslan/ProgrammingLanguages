void main(){

  for(var i=0;i<5;i++){

    print(i);

  }

  var dizi = [10,20,30];

  for (var deger in dizi) {

    print("Sonuç : $deger");

  }

  //3,4,5

  for ( var i=3;i<6;i++){
    print("a : $i");
  }

  //10 ile 20 arasında 5 er

  for (var i=10;i<21;i+=5){
    print("b : $i");
  }

  //20 ile 10  2 şer

  for (var i=20;i>9;i-=2){
    print("c : $i");
  }

  //While 1,2,3

  var sayac = 1;

  while (sayac < 4){
    print("Sonuç : $sayac");
    sayac += 1; //sayac = sayac + 1
  }

}