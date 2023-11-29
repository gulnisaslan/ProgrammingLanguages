// TypeOf = veri türünü geri döndürür.
name_ = "Gülnisa",surName="Aslan",sonuc = 50
var depo = typeof(surName)
var depo_ = typeof sonuc


//length => Değişken içeriğinin karakter sayısını geriye döndürür

var metin = "Volkan Alakent, Türkiye'de en çok kullanılan script dili javascripttir."
console.log(metin)
var islem = metin.length;
console.log(islem)

// Değişkenlerde slice(), eval(),trim(),substring(),substr()
//-*--------------*----------------*-*--------------------------*

/*eval()-> kendisine parametre olarak verilen değerleri javascript kodlamasına çevirerek
 komut gibi calıstırır ve oluşan değeri geri döndürür.*/
//-------------------------*-*-**-------------------*--*-*-*-*-**
var value1=10;
var value2=25;
var result1 = eval(value1+value2);
//-----------------------------------------------------------------------------

/*trim()->değişken içinde varsa başındaki ve sonundaki tüm boşlukları temizler ve geriye döndürür.*/
//-----*-*-*-*-------------------------**-*-*-*-*-----------------------------
var example = " javascript ";
var icerik = " egitim seti ";
var result2 = example + icerik;
console.log(result2.trim());


//-------------------------------------------------------------------------
/*slice() kendisine tanımlanmış parametreler ile tanımlanmış değişken içeriği aralığında bulunan değerlieri kopyalayarak
yeni bir içerik oluşturur ve oluşturduğu degeri geriye döndürür.*/
//-----------------------------------------------------------------------------------------------------------------------
var example = " Volkan Alakent javascript  egitim seti ";
console.log(metin);
var result3 = metin.substring(11,15);
console.log(result3);
//-----------------------------------------------------------------------------------------------------------------------
/*substring() =>Kendisine verilecek olan parametreler ile tanımlanmış değişken içeriği aralığında kopyalayarak
yeni bir içerik oluşturur ve oluşturduğu  değeri  geriye döndürür. */

/*substr -> metodu eksi değer alabilir. 
1.Parametre -> Başlangıç karakteri sıra numarası
2. kaç karakter alacağı
Dikkat : deprecated olmustur. kullanımı dan kalmıştır. kullanılması 
tavsiye edilmez
*/


/*Concat() -> üzerinden çalışılan değişkenler parametrik olarak verilwn verilen değişken ya da
değişkenleri dahil ederek yani yeni bir içerik oluşturur ve oluşturduğu nesneyi geri çevirir.*/
var one = "volkan";
var two = "alakent";
var result4 = one.concat(two);
console.log(result4)

var three = "javascript";
var four = "eğitim";
var five = "seti"
var result5 = one.trim(two,three,four,five);
console.log(result5)
/*
repeat() -> kendisine parametre olarak verilen değer doğrultusunda
değişken içeriğini tekrar edip kopyalayarak yeni bir içerik oluşturur ve
oluşturduğu degeri geri döndürür
*/
console.log("----------------------------------------------")
var islem = three.repeat(100)
console.log(islem)
/*
toString() -> Değişken içeriğini string(metin) veri türünde düz bir metne
dönüştürerek olusturduğu degeri geriye döndürür
*/
var result6 = value1.toString
console.log(result6)