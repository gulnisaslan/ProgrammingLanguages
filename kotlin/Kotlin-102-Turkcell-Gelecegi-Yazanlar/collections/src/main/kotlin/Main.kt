

fun main(args: Array<String>) {
    /*  Diziler */
    var dizi = arrayOf("elaman1","eleman2")
    println(dizi[0]) // indeks' göre veri getirme
    println(dizi.get(1))//get metodu ile indeks'e göre veri getirme

    dizi[0] = "Değişen Eleman"
    dizi.reverse()
    println(dizi[0])

    var sayiDizisi = intArrayOf(1,2,3,4,5)
    var karisikDeger = arrayOf("metin",1,2,5)


}