print "Birinci sayı:"
a = gets.to_f
print "ikinci sayı: "
b = gets.to_f
print "işlem turu"
option =gets.chomp()

if option == "+"
    print a+b
elsif option=="-"
    print a-b
elsif option=="*"
    print a*b
elsif option=="/"
    print a/b
elsif option=="**"
    print pow(a,b)
else
    print "Gecersiz işlem Girdiniz"
end


