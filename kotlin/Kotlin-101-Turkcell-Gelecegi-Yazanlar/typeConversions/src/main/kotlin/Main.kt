fun main(args: Array<String>) {
    println("Type Conversions")
    var d1:Int=10
    var d2:Int=3
    var sum = d1/d2
    println(sum)

    var sumResult :Float = d1.toFloat()/d2
    println(sumResult)

    var d4 = "14"
    var d5 = d4.toInt()
    println(d5)

    var d6 ="hello"  // throws NumberFormatException
    var d7 = d6.toInt()
    println(d7)

   
}