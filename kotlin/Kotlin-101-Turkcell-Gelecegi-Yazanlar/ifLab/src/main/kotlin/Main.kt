fun main(args: Array<String>) {
   println("1-Bankacılık işlemlerinden eft yapmak istiyouz.\n" +
           "2.İşlem yapılacak gün ve saat bilgisini, mesai günleri ve saatleri içinde olup olmaması" +
           "ve yapabileceği en yakın zamanının bilgilendirmesinin yapılması\n\n")

    var day :Int=5
    var hour:Int =24
    if (day>0 && day<=7) {
        if (day<=5){
            if (hour>=10&&hour<=17){
                println("Eft işleminiz gercekleştirildi")
            }else if(hour>18 &&hour<=24) {
                println("Eft işleminiz yarın saat 10'dan itibaren gercekleştirebileceksiniz.")
            }
            else if (hour>=0&&hour<9){
                println("Eft işleminiz sabah saat 10'dan itibaren gercekleştirebileceksiniz.")

            }else{
            println("Gecersiz saat dilimi girdiniz")
            }
        }
         else if(day==6){
            println("Eft işleminiz 2 gün sonra Pazartesi saat 10'dan itibaren gercekleştirebileceksiniz.")
        }
        else if (day==7) {
            println("Eft işleminiz yarın saat 10'dan itibaren gercekleştirebileceksiniz.")
        }
    }
    else{
        println("Gecersiz Gün Girdiniz.")
    }


}
