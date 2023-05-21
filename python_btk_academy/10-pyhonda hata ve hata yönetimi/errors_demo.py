liste = ["1","2","5a","10b","abc","10","50"]

# 1: Liste elemanları içindeki sayısal değerleri bulunuz.
for x in liste:
     try:
          result=int(x)
          print(result)
     except ValueError:
          continue

# 2: Kullanıcı 'q' değerini girmedikçe aldığınız her inputun sayı 
# olduğundan emin olunuz aksi halde hata mesajı yazın.
while True:
     sayi=int(input("sayı giriniz: "))
     if sayi=="q":
          break

     try:
        result = float(sayi)
        print('girdiğiniz sayı: ', result)
        break
     except ValueError:
        print('geçersiz sayı')
        continue  


# 3: Girilen parola içinde türkçe karakter hatası veriniz.




def check_password(parola):
     turkce_karakterler='şçğöüıI'
     for i in parola:
          if i in turkce_karakterler:
             raise TypeError("parola türkçe karakter içermez.")
          else:
            pass
     print("geçerli parola")

parola=input("parola: ")
try:
     check_password(parola)
except TypeError as error:
     print(error)
     

# 4: Faktöriyel fonksiyonu oluşturup fonksiyona gelen değer için
# hata mesajları verin.

def faktoriyel(x):
     x=int(x)

     if x <0:
          raise  ValueError("negatif deger")
     result=1

     for i in range(1, x+1):
          result *=1
     return result

for x in [1,10 , 20,30,40,-3,"10g"]:
     try:
          y=faktoriyel(x)
     except ValueError as err:
          print(err)
          continue
     print(y)


