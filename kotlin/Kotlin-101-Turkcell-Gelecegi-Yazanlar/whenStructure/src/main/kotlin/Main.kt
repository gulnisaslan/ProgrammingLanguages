fun main(args: Array<String>) {
    println("When-Else->\n" +
            "when(deger){\n" +
            "1->print( \"1\")\n" +
            "}else{}\n\n")

    var d1 = 4
    when(d1){
        1-> println("1")
        2-> println("2")
        3-> println("3")

        else-> println("Gecersiz deger girdiniz")
    }


}