# """
# 'ogrenciler'={
#  '187':{
#      'ad':'Gülnisa'
#      'soyad':'Aslan'
#      'telefon':'5433121536
#  },
#  '1052':{

#      'ad':'Semih Sercan'
#      'soyad':'Aslan'
#      'telefon':'5433124524'
#  },
#  '721':{
#      'ad':'Ercan'
#      'soyad':'Aslan'
#      'telefon':'5234125463'
#  }
# } 
# """
ogrenciler={}

number=input('öğrenci no: ')
name=input('öğrenci adı: ')
surname=input('öğrenci soyad: ')
phone=input('telefon no: ')

ogrenciler.update({
    number:{
        'ad':name,
        'soyad':surname,
        'telefon':phone,
    }
})

ogrenciler={}

number=input('öğrenci no: ') 
name=input('öğrenci adı: ')
surname=input('öğrenci soyad: ')
phone=input('telefon no: ')

ogrenciler.update({
    number:{
        'ad':name,
        'soyad':surname,
        'telefon':phone
    }
})

ogrenciler={}

number=input('öğrenci no: ')
name=input('öğrenci adı: ')
surname=input('öğrenci soyad: ')
phone=input('telefon no: ')

ogrenciler.update({
    number:{
        'ad':name,
        'soyad':surname,
        'telefon':phone
    }
})

print('*'*50)


ogrNo = input('öğrenci no: ')
ogrenci = ogrenciler[ogrNo]
print(ogrenci)

print(f"Aradığınız {ogrNo} nolu ögrenci {ogrenci('ad')} {ogrenci('soyad')} ve telefon nosu ise{ogrenci('telefon')}")