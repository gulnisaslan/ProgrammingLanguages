#1-100'e kadar

# x = 0

# # while True :
# #     print(x)


# while x <= 100:
#     if (x % 2 == 1):
#         print(f'tek sayı: {x}')
#     else :
#         print(f'çift sayı: {x}')
#     x+=1

# print('bitti')


# name = '' # false
# while not name.strip():
#     name = input('isminizi girirniz: ')

# print(f'merhaba,{name}')   



# sayilar = [1,3,5,7,9,12,19,21,23]

# i=0
# while(i<len(sayilar)):
#     print(sayilar[i])
#     i+=1

# baslangıc=int(input('başlangıç sayısı:  '))
# bitis=int(input('bitiş sayısı:  '))

# i= baslangıc
# while i<bitis:
#      i+=1
#      if(i%2==1):
#          print(i)

# i=100
# while i>0:
#     print(i)
#     i-=1

numbers=[]
i=0
while i<5:
    sayi=int(input('sayı: '))
    numbers.append(sayi)
    i+=1
numbers.sort()

urunler=[]

adet=int(input('sayı giriniz:  '))
i=0
while(i<adet):
    name=input('isim giriniz: ')
    price=input('fiyat giriniz: ')
    urunler.append({
        'name':name,
        'price':price
    }) 
    i+=1
for urun in urunler:
    print(f"ürün adı:{urun['name']} ürünün fiyatı:{urun['price']}")

