class Odev3 {

  //3 - 3*2*1
  //3 - 3+2+1

  int faktoriyelHesaplama(int sayi){
    int sonuc = 1;

    for (var i=1;i<sayi+1;i++){//5 - 1,2,3,4,5
      sonuc = sonuc * i;
    }

    return sonuc;

  }

}

