#1-Girilen 2 sayıdan hangisi büyüktür?
a=int(input('1.sayı: '))
b=int(input('2.sayı: '))
result=(a>b)
print(f'a : {a} , b : {b} büyüktür : {result} ')

#2-kullanıcıdan 2 vize (%60) ve final (%40) notu alıp ortalama hesaplayın
#Eğer ortalam 50 ve üstündüyse geçti değilse kaldı yazdırın.

vize1=float(input('1.vize: '))
vize2=float(input('2.vize: '))
final=float(input('final: '))

ortalama = (((vize1 + vize2) /2)* 0.6) + (final * 0.4)
print(f' ortalamanız : {ortalama} ve dersten geçme durumunuz: {ortalama>=50}')

#3-Girilen bir sayının tek mi çift mi olduğunu yazdırın.

sayi =  int(input('sayı: '))
tekcift = (sayi % 2==0)
print(f' girilen sayının çift olma durumu : {tekcift}')

#4-Girilen bir sayının negatif pozitif durumunu yazdırın.

sayi = int(input('sayı: '))
pozitifmi = (sayi > 0)
print(f'girilen sayının pozitif olma durumu: {pozitifmi}')

#5- Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

email='gulnisa@gulnisaaslan.com'
password='123123'
girilenEmail=input('email: ')
girilenPassword=input('parola: ')

isEmail=(email==girilenEmail.lower().strip())
isPassword=(password==girilenPassword.lower())

print(f'Email bilgisi doğrumu: {isEmail} ve parola doğru mu:{isPassword}')

