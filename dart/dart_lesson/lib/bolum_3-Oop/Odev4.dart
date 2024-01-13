class Odev4 {

  void kelimeAdeti(String kelime,String harf){//ankara , a

    var sonuc = 0;

    for(var i=0;i<kelime.length;i++){

      if(kelime[i] == harf){
        sonuc = sonuc + 1;
      }

    }

    print("Harf Adeti : $sonuc");

  }

}

