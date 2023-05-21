

# 5- Kullanıcıdan 2 vize (%60) ve final(%40) notunu alıp ortalama hesaplayınız 
# Eğer ortalama 50 ve üstündeyse geçti değilse kaldı.
vize1 = int(input('vize1: '))
vize2 = int(input('vize2: '))
final = int(input('final: '))

ortalama = (((vize1 + vize2) / 2)*0.6) + (final * 0.4)
result = (ortalama>=50) and (final>=50)
result = (ortalama>=50) or (final>=70)
print(f'öğrencini not ortalaması: {ortalama} ve geçme durumu : {result}')

# a-)ortalama 50 bile olsa bile en az final notu 50 olmalıdır. 
# b-)finalden 70 alındığında ortalamanın bir önemi olmasın.


# 6- Kişinin  ad kilo ve boy bilgilerin alıp kilo indekslerini hesaplayın.
# formul : (kilo / boy uzunlugunun karesi)
# Aşağındaki tabloya göre kişi hangi gruba girmektedir.
# 0-18.4 => zayıf
# 18.4-24-9=> normal
# 25-29.9=>fazla kilolu
# 30-34.9=>şişman(obez) 
name = input('isim: ')
weight = float(input('kilo: '))
height = float(input('boy: '))
formul = (weight )/ (height **2)
zayif = (formul>=0) and (formul<=18.4)
normal = (formul>18.4) and (formul<=24.9)
kilolu = (formul>25) and (formul<=29,9)
sismam = (formul>=29.9) and (formul<=34.9)

print(f'{name} kilo indeksiniz {formul} ve kilo degerlendirmeniz zayıf:{zayif}')
print(f'{name} kilo indeksiniz {formul} ve kilo degerlendirmeniz normal:{normal}')
print(f'{name} kilo indeksiniz {formul} ve kilo degerlendirmeniz kilolu:{kilolu}')
print(f'{name} kilo indeksiniz {formul} ve kilo degerlendirmeniz sisman:{sismam}')

