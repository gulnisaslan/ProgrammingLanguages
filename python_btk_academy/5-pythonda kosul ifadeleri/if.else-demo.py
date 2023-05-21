# 1- Kullanıcıdan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme 
#    durumunu kontrol ediniz. Ehliyet alma koşulu en az 18 ve  eğitim durumu 
#    lise ya da üniversite olmalıdır.

# name = input('İsim: ')
# age = int(input('yas: '))
# egitim = input('eğitim: ')

# if (age>=18):
#     if (egitim == 'lise' or egitim == 'üniversite'):
#      print(f'{name} ehliyetiniz almaya hak kazandınız')
#     else  :
#      print(f'{name} ehliyetiniz almak için eğitiminiz yetersiz')
# else :
#           print(f'{name} ehliyetiniz almaya yaşınız tutmuyor')
# 2- Bir öğrencinin 2 yazılı bir sözlü notunu alıp hesaplanan ortalamaya göre
#    not aralığına karşılık gelen not bilgisini yazdırınız.
#    0 -24  => 0
#    25-44  => 1
#    45-54  => 2
#    55-69  => 3
#    70-84  => 4
#    85-100 => 5

# yazili1 = float(input('1.yazılı: '))
# yazili2 = float(input('2.yazılı: '))
# sozlu = float(input('sözlü: '))

# ortalama = (yazili1 + yazili2 + sozlu) / 3

# if (ortalama >= 0) and (ortalama < 25):
#   print(f'ortalama notunuz {ortalama}: 0')
# elif (ortalama >= 25) and (ortalama < 44):
#   print(f'ortalama notunuz {ortalama}: 1')
# elif (ortalama >= 45) and (ortalama < 54):
#    print(f'ortalama notunuz {ortalama}: 2')
# elif (ortalama >= 55) and (ortalama < 69):
#    print(f'ortalama notunuz {ortalama}: 3')
# elif (ortalama >= 70) and (ortalama < 84):
#     print(f'ortalama notunuz {ortalama}: 4')
# elif (ortalama >= 85) and (ortalama <=100):
#     print(f'ortalama notunuz {ortalama}: 5')
# else:
#     print(f'yanlış bilgi girdiniz')

# 3- Trafiğe çıkış tarihi alınan bir aracın servis zamanını aşağıdaki bilgilere
#    göre hesaplayınız.
#    1. Bakım => 1. yıl     
#    2. Bakım => 2. yıl      
#    3. Bakım => 3. yıl     
#    ** Süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız..
#    *** datetime modülünü kullanmanız gerekiyor.  
#    (simdi) - (2018/8/1) => gün
#days = int(input('aracınız kaç gündür trafikte:'))
import datetime
tarih = input('aracınızın trafige çıkış tarihi (2020/4/1): ')
tarih = tarih.split('/')
trafigeCikis = datetime.datetime(int(tarih[0]),int(tarih[1]),int(tarih[2]))
simdi = datetime.datetime.now()
fark = simdi - trafigeCikis
days = fark.days

if days<=365:
  print(f'1.servis aralığı')
elif days>365 and days<=365*2:
     print(f'2.servis aralığı ')
elif days>365*2 and days<=365*3:
     print(f'3.servis aralığı ')
else:
    print(f'hatalı sure')