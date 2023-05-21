#1- Girilen bir sayının 0-100 arasında olup olmadığını kontrol ediniz.
sayi = float(input('sayı: '))

if (sayi > 0) and (sayi <= 100):
      print(f'sayı 0-100 arasında ')
else:
    print(f'sayı 0-100 arasında değil.')

#2- Girilen bir sayının pozitif çift sayı olup olmadığını kontrol ediniz.
sayi = int(input('sayı: '))
if (sayi>0):
     if(sayi%2==0):
         print(f'sayı pozitif çift sayıdır')
     else:
         print(f'girilen sayı pozitif ama tek sayıdır.')
else:
    
    print(f'girilen sayı negatif sayıdır')

#3- Email ve parola bilgileri ile giriş kontrolü yapınız.
email = 'gulnisa@gulnisa.com'
password = '123123'

enterEmail = input('email: ')
enterPassword = input('password: ')

if (enterEmail==email):
     if (enterPassword==password):
         print(f'giriş başarlı')
     else :
             print(f'parolanız yanlış')
else:
    print(f'email adresiniz yanlış')

#4- Girilen 3 sayıyı büyüklük olarak karşılaştırınız.
a = float(input('a: '))
b = float(input('b: '))
c = float(input('c: '))

if (a>b) and (a>c):
     print(f'a en büyük sayıdır.')
elif (b>a) and (b>c):
      print(f'b en büyük sayıdır')
elif (c>a) and (c>b):
    print(f'c en b üyük sayıdır')

# 5 Kullanıcıdan 2 vize (%60) ve final (%40) notunu alıp ortalama hesaplayınız.
#    Eğer ortalama 50 ve üstündeyse geçti değilse kaldı yazdırın.
#    a-) Ortamalama 50 olsa bile final notu en az 50 olmalıdır.
#    b-) Finalden 70 alındığında ortalamanın önemi olmasın.

vize1 = float(input('1.vize :'))
vize2 = float(input('2.vize : '))
final = float(input('final : '))

ortalama = ((vize1+vize2)/2)*0.6 + (final * 0.4)

result = (ortalama >= 50) and (final >=50)
result = (ortalama >= 50) or (final >=70)
"""
if (ortalama >= 50):
    if(final >= 50):
        print(f'öğrencinin ortalaması: {ortalama} ve geçme durumu:başarılı')
    else:
        print(f' öğrencinin ortalaması: {ortalama} ve geçme durumu : başarılı geçmeniz için finalden en az 50 almanız gerekiyor.')
else:
    print(f'öğrencinin not ortalaması:{ortalama} ve geçme durumu : başarısız')
"""
if (ortalama >= 50):
        print(f'öğrencinin ortalaması: {ortalama} ve geçme durumu:başarılı')
else:
    if(final >= 70): 
          print(f' öğrencinin ortalaması: {ortalama} ve geçme durumu : başarılı geçmeniz için finalden en az 70 aldığınız için geçtiniz.')
    else:
          print(f'öğrencinin not ortalaması:{ortalama} ve geçme durumu : başarısız')





# 6- Kişinin ad, kilo ve boy bilgilerini alıp kilo indekslerini hesaplayınız.
#    Formül: (Kilo / boy uzunluğunun karesi)
#    Aşağıdaki tabloya göre kişi hangi gruba girmektedir.
#    0-18.4    => Zayıf 
#    18.5-24.9 => Normal  
#    25.0-29.9 => Fazla Kilolu
#    30.0-34.9 => Şişman (Obez)
isim = input('isim: ')
kilo = float(input('kilo: '))
boy = float(input('boy: '))

index = (kilo) / (boy ** 2)

if (index>=0) and (index <=18.4):
   print(f'{isim} kilo indeksiniz : {index} ve kilo degerlendirmeniz zayıf.')
elif (index>18.5) and (index <=24.9):
   print(f'{isim} kilo indeksiniz : {index} ve kilo degerlendirmeniz normal.')
elif (index>25) and (index <=29.9):
   print(f'{isim} kilo indeksiniz : {index} ve kilo degerlendirmeniz kilolu.')
elif (index>30) and (index <=34.9):
   print(f'{isim} kilo indeksiniz : {index} ve kilo degerlendirmeniz obez.')
elif (index>35)  and (index<=44.9):
    print(f'{isim} kilo indeksiniz : {index} ve kilo degerlendirmeniz morfit obez.')   
else:
    print(f'bilgileri yanlış girdiniz.')