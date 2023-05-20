fun main(args: Array<String>) {
 //Set yapısı içinde sadece aynı elemandan bir tane olması istenilen durumlarda kullanılır.

    var st = setOf(1,2,3,1,2,3)
    println(st.size)
    st.forEach{
        println(it)
    }
    //st.append-put gibi metodlar bulunmaz çünkü bu dizilere veri ekleyip cıkaramayız.

    var hst = hashSetOf<Int>()
    hst.add(1)
    hst.add(2)
    hst.add(1)
    println(hst.size)
    hst.forEach {
        println("------------------")
        println(it)
    }

}