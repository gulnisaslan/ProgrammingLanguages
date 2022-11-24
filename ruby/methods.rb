def merhaba()
    puts "Merhaba"
end

merhaba()

def topla(a,b,c)
    puts (a+b+c).to_s
end

topla(2,3,4)

def salute(firstName="Bilgi Yok",lastName="Bilgi Yok")
    puts "İsim: "+firstName+" soy isim: "+ lastName
end
salute("Gülnisa","Aslan")
salute()

def square(x)
    return x **2
end
def cube(x)
    return x**3
end
a=square(cube(4))
puts a