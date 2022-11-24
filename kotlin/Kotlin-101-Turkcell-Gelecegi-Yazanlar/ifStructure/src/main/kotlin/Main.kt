fun main(args: Array<String>) {
    println("if structure->\n" +
            "if(){}\n" +
            "else structure->\n else{}")
    var yas = 50
    if(yas<20){
        println("<20>")
    }else if (yas>20&&yas<50){
        println("20-60")
    }else{
        println(">=20")
    }
}