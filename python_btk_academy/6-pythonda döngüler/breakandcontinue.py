# name = 'gülnisa aslan'

# for letter in name:
#     if letter == 'a':
#        #break
#        continue
#     print(letter)


name=input("ad giriniz: ")

for letter in name:
    if letter=="a":
        break
    print(name)
# x=0

# while x < 5:
#     x+=1
#     if x==2:
#       #break
#       continue
#     print(x)
#     x+=1

# 1-100'e kadar tek sayıların toplamı

# x = 0
# result = 0

# while x <= 100:
#     x+=1
#     if x % 2==0:
#         continue
#     result += x
#     x+=1
# print(f"toplam: {result}")
y=0
result=0
while(y<=100):
    y-=1
    if(y%2==0):
        continue
    result-=y
    y-=1
print(f"Eksiltme:{result}")






name=input("ad giriniz: ")

for letter in name:
    if letter=="a":
        break
    print(name)