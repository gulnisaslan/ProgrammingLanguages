array =[1,2,3,4,5]
#puts array["Murat"]

begin
    a = 5/0
    puts "Naber"

rescue => ZeroDivisionError
    puts exception.message+"Hatayla Karşılaşıldı."
end