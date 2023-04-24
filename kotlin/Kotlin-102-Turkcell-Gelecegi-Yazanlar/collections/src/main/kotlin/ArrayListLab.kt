//Elimizdeki meyveler listesinin tum elemanlarının teker teker ekrana yazdırılması
//adı yazılan meyvenin indeks degerinin ekran yazdırılması


fun main(args: Array<String>) {
    var meyveler = arrayListOf<String>()
    meyveler.add("Elma")
    meyveler.add("Armut")
    meyveler.add("Portakal")

    for (index in 0..meyveler.size-1){
        println("${index} degerindeki meyveninin adı ${meyveler[index]}")
    }

    var istenenMeyve = "Armut"
    for (meyve in meyveler){
        if (meyve == istenenMeyve){
            println(meyveler.indexOf(meyve))
        }
    }

    for (index in 0..meyveler.size-1){
        if (meyveler[index] == istenenMeyve){
            println(meyveler[index])
        }
    }


}