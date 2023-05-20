fun main(args: Array<String>) {
    var meyveler = arrayOf("Elma","Armut")
    var kaloriler = arrayOf(100,200)

    println("meyve: ${meyveler[0]},kalori : ${kaloriler[0]}")

    println("*************************************************")

    var hashMap = hashMapOf<String,Int>()
    hashMap.put("Elma",100)
    hashMap.put("Armut",400)
    println(hashMap["Elma"])

    hashMap["Elma"] = 1500
    println(hashMap["Elma"])

    println("****************************************************")
    var hashMap2 = hashMapOf<String,Int>("Elma" to 100,"Armut" to 500)
    hashMap2.forEach {
        println(it)
    }

    hashMap2.forEach {
        println("${it.key} : ${it.value}")
    }

    println("\n \n \n ")

    var filtrele = hashMap2.filter { it.value>100 }

    hashMap2.forEach {
        println("${it.key} : ${it.value}")
    }
}