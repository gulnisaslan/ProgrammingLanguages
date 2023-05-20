fun main() {
    var notlar = arrayListOf<ArrayList<Float>>()
    var ortalamalar = arrayListOf<Float>()
    var durumlar = arrayListOf<String>()
    notlar.add(arrayListOf(50f,60f,10f,40f))
    notlar.add(arrayListOf(100f,100f,90f))
   for (i in 0..notlar.size-1){
       var ortalama = ortalamalar.get(i).reduce{
           baslangic,gecerli->baslangic+gecerli
        }


    }
    durumlar = ortalamalar.map {
        if(it<50){
            "Kaldı"
        }else{
            "Gecti"
        }
    } as ArrayList<String>

    ortalamalar.forEach { println(it) }
    durumlar.forEach { println(it) }
}


