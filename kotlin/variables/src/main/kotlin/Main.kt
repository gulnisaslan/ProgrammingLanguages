import java.math.BigDecimal

fun main(args: Array<String>) {
   //Bellekte tuttugumuz değerler için kullanılan kavrama değişken denir.
   //Değişken tiplerine göre yer kaplar
    //Kotlin tip güvenli bir dildir.
    //Değişkenleri tanımlarken belli  bir isimlendirme standardı vardı.

    /*
    * var     degiskenAdi = 5
    degişken  degisken
    tanimi     adi
    * */

    //Sayısal Tanımlama

    var degiskenAdi = 5
    println(degiskenAdi)

    //Integer
    var d1 :Int = 5
    var d2 : Double = 5000.00
    var d3 : Number =244.00F
    println(d1)
    println(d2)
    println(d3)

    //Metinsel
    var d5 :String = "Merhaba "
    var d6 :String = "Kotlin"

    var d7 :String = d5+d6

    println(d7)

    //Mantıksal
    var d8:Boolean =true

    println(d8)

    //Kaçıs Satırları ve Yorum satırları

// -> tek satırlık yorumlar için kullanılır
    /* çoklu yorum satırı*/

    var ad = "Ad : "+"Ahmet"+"\n Ahmet"

    println(ad)


}