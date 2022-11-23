fun main(args: Array<String>) {
  // + - /  *
    //Toplam
    var d1 = 5
    var d2 : Int = 10

    var d3= d1 +d2
    println(d3)

    //Bolum
    var bol = d2 /d1

    println(bol)

    // Mod Alma
    var kalan = 5 % 2
    println(kalan)

    //Mantıksal Operatörler
    /*
    * <
    * >
    * <=
    * >=
    * ==
    * !=
    * &&
    * ||
    * !
    *  */

    var d4:Boolean = 3<5
    var d5:Boolean = 3<=5
    var d6 = 5 <= 5
    var d7 = 5 != 5

    println(d4)
    println(d5)
    println(d6)
    println(d7)

    //&&
    println("\n \n \n&&")
    var d8 = true && true
    println(d8)
    var d9 = true && false
    println(d9)
    var d10 = false && false
    println(d10)
    var d11 = false && false
    println(d11)

    var d12= true

    var veSonuc = 2>1 && d10

    // ||
    println("\n \n||")
    var d13 = true || true
    var d14 =  true || false
    var d15 =  false || false
    var d16 =   false|| true

    var veyaSonuc =2<1 ||d12
    println(veyaSonuc)
}