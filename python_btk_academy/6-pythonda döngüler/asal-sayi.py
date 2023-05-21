# sayi=int(input('sayıyı giriniz: '))
# asalmi=True
# if sayi==1:
#     asalmi=False

# for i in range(2,sayi):
#     if (sayi%i==0):
#         asalmi=False
#         break
        
# if asalmi:
#     print('sayı asaldır')
# else:
#     print('sayı asal değildir')

number=int(input("enter number:  "))
isPrimeNumber=True
if number==1:
    isPrimeNumber=False

for i in range(2,number):
    if number%i==0:
        isPrimeNumber=False
        break

if isPrimeNumber:
    print("number is prime")

else:
    print("number isn't prime")







