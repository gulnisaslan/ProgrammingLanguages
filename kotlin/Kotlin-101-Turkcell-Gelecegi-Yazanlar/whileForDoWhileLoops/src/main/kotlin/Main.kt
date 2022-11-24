fun main(args: Array<String>) {
   println("While Döngüsü:\n" +
           "while()\n" +
           "{\n" +
           "}\n\n")

    var count:Int=0
    while (count<10){
        count++
        println(count)
    }
    println("--------------------------------------<\n")
    println("Do While Döngüsü:\n" +
            "do{\n" +
             "}\n"+
            "while()\n"
            )
    var count1:Int=0
    do {
        count1++
       println(count1)
    }while (count<5)
    println("--------------------------------------<\n")
    println("For Döngüsü:\n" +
            "For()\n" +
            "{\n" +
            "}\n\n")
    for (i in 1..10){
        println(i)
    }
    for (i:Int in 1..5){
        println(i)
    }
    println("--------------------------------------<\n")
    println("Continue: Kendiden sonraki işlem yapılmadan bir sonraki işlemini yapılmasını sağlar.")
    for (i in 1..10){
        if(i==5){
            continue
        }
        println(i)
    }
    println("--------------------------------------<\n")
    println("Break: İçinde bulunulan döngünün dışına çıkmanızı sağlar.")
    for (i in 1..10){
        if (i==5){
            break
        }
        println(i)
    }
    sda@for (i in 1..12){
            for (j in 1..12){
                if (j==8){
                    faa@break
                }
            }
    }
}