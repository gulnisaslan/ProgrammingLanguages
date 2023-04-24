fun main(args: Array<String>) {
    var dizi = intArrayOf(1,2,3,4,5)
    var d1 = dizi[0]
    dizi[4]= 45
    println(dizi[4])

    var arrayList =  arrayListOf<String>()
    arrayList.add("eleman1")
    arrayList.add("eleman 2")

    println(arrayList.get(0))

    arrayList.add(1,"yeni eleman")
    println(arrayList.get(1))

    var filtreliListe = arrayList.filter { it.length>8 }
    println(filtreliListe.size)



}