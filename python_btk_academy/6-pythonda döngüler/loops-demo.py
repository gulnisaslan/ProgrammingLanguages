import random  #hak=5

sayi=random.randint(1,10)
can = int(input('kulanmak istediğiniz can sayısını giriniz: '))
hak=can
sayac=0

while hak>0:
    hak-=1
    sayac+=1
    tahmin=int(input('tahmin: '))
    
    if (sayi==tahmin):
        print(f'tebrikler {sayac}. defada bildiniz..toplam puanınız:{100-(100/can)*(sayac-1)}')
        break
    elif(sayi>tahmin):
        print('yukarı')
    else:
        print('aşağı')


if hak==0:
    print(f'hakkınız bitti.tutulan sayı:{sayi}')
 
