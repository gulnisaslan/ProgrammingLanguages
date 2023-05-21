#bankamtik uygulaması
GulnisaHesap ={
    'ad' : 'Gülnisa Aslan',
    'hesapNo' : '123456789',
    'bakiye' : 4000,
    'ekHesap' : 2500,
    'yatırılanMiktar':2500,
    'toplammiktar':5250
    }

ErcanHesap = {
    'ad' : 'Ercan Aslan',
    'hesapNo' : '987654321',
    'bakiye' : 3000,
    'ekHesap' : 1500,
    'yatırılanMiktar':2500

}

def paraCek(hesap, miktar):
    print(f"merhaba {hesap['ad']}")
    if (hesap['bakiye'] >= miktar) :
        hesap['bakiye']-=miktar
        print('paranızı alabilirsiniz')
        bakiyeSorgula(hesap)
        
    else:
        toplam= hesap['bakiye']+ hesap['ekHesap']

        if (toplam >= miktar):
            paracekilsinMi=input("para çekilsin mi (e/h)")
            ekHesapKullnimi=input('ek hesap kullanılsın mı (e/h): ')
            paraYatirilsinmi=input("hesaba para yatırılısın mı?(e/h)")

            ekHesapKullanilacakMiktar = miktar-hesap['bakiye']
            yatirilanMiktar=miktar+hesap["bakiye"]
            hesap['bakiye']=0
            hesap['ekHesap']-=ekHesapKullanilacakMiktar
            hesap['bakiye']+=yatirilanMiktar
            bakiyeSorgula(ErcanHesap)
            
            if paracekilsinMi=="e":
                print("para çekildi.")

            elif paraYatirilsinmi=="e":
                print("paranız yatırlımıstır.")
            
            elif ekHesapKullnimi=='e':
                print('paranızı alabilirsiniz.')
            else:
                print(f"merhaba {hesap['hesapNo']} nolu hesabınızda {hesap['bakiye']} bulunmaktadır")
   
        else:
            
            print('Üzgünüz bakiye yetersiz')
            bakiyeSorgula(ErcanHesap)

def bakiyeSorgula(hesap):
    print(f"{hesap['hesapNo']} nolu hesabınızda {hesap['bakiye']} ₺ bulunmaktadır. ek hesap limitiniz ise {hesap['ekHesap']} yatırılan miktar {hesap['yatırılanMiktar']} bulunmaktadır")

def paraYatır(hesap,yatir):
    
    print(f"{hesap['hesapNo']} nolu hesabınızda {hesap['bakiye']} ₺ bulunmaktadır. ek heasp limitiniz ise {hesap['ekHesap']}  bulunmaktadır")

    


paraYatır(ErcanHesap,2500)
paraCek(ErcanHesap, 4000)
print('************')
paraCek(ErcanHesap, 500)
