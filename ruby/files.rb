file = File.open("mezun.txt")
puts file.read()
puts file.read(10)

file.close

File.open("mezun.txt","r") do |file|
   # puts file.read()
    puts file.readlines()
    puts "-------------------------"
    
end
File.open("mezun.txt","a") do |file|
    # puts file.read()
     puts file.write("kamil,Gazi\n")
     puts file.write("Gülnisa,Anadolu\n")
     puts "-------------------------"
     
 end