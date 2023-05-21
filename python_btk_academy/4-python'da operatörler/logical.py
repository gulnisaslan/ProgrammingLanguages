x = 6
hak = 5
devam = 'e'
#result = 5 < x < 10
#print(result)

# and
#result = (x > 5 and x < 5) # True, True = True
#result = (hak > 0) and (devam == 'e')

# or 
#result = (x > 0) or (x % 2 ==0)  #true ,false =true . true , true =  true . false ,false =false olur

#not

#result = not(x > 0)
# x, 5-10 arasında olan bir çift sayı mı?
result = ((x > 5) or (x < 10)) and (x % 2 == 0)
print(result)