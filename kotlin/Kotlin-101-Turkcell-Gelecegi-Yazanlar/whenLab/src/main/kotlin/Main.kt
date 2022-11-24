fun main(args: Array<String>) {
    println("1-Bankacılık işlemlerinden eft yapmak istiyouz.\n" +
            "2.İşlem yapılacak gün ve saat bilgisini, mesai günleri ve saatleri içinde olup olmaması" +
            "ve yapabileceği en yakın zamanının bilgilendirmesinin yapılması\n\n")

    var day :Int=8
    var hour:Int =11

    when(day){
        in 1..5->
            when(hour){
                in 9..17->println("Eft İşleminiz gercekleştirildi.")
                in 18..24-> println("Eft İşleminiz yarın sabah saat 9'dan yapabilirsiniz")
                in 0..8-> println("Eft İşleminiz sabah saat 9'dan yapabilirsiniz")
                else-> println("Gecersiz saat aralığı girdiniz")
            }
        6-> println("Eft işleminiz pazartesi günü sabah saat 9'dan itibaren gercekleştirebilirsiniz.")
        7->println("Eft işleminiz yarın sabah saat 9'dan itibaren gercekleştirebilirsiniz.")
        else-> println("Geçersiz Gün aralığı girdiniz.")

    }


}