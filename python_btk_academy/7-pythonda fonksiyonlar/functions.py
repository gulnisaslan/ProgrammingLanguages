def sayHello(name = 'user'):
      return 'hello' + name

msg=sayHello('gülnisa') 
msg=sayHello('çigdem')
print(msg)


def total(num1,num2):
    return num1 +num2

result=total(10,20)

print(result)

def yasHesapla(dogumYili):
    return 2019-dogumYili

ageGulnisa=yasHesapla(1996)
ageEce=yasHesapla(1995)
ageHuriye=yasHesapla(1945)

print(ageGulnisa,ageEce,ageHuriye)

def EmekliligeKacYiliKaldi(dogumYili,isim):
    '''
    DOCSTRING:Doğum yiliniza gore emekliliginize kac yil kaldi
    input:dogum yili
    output:hesaplanan yil bilgisi
    '''
    yas=yasHesapla(dogumYili)
    emeklilik=53-yas

    if emeklilik>0:
        print(f'emekliliğinize {emeklilik} yıl kaldı')
    else:
        print('emeklisiniz') 


EmekliligeKacYiliKaldi(1983,'Ali')
EmekliligeKacYiliKaldi(1966,'zeynep')
EmekliligeKacYiliKaldi(1971,'haşim')
EmekliligeKacYiliKaldi(1974,'gülten')

#print(help(EmekliligeKacYiliKaldi))

#print(help(list.append))