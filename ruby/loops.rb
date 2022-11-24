i=0
while i<=10
    puts "i'nin degeri: "+i.to_s
    i+=1
    
end

langs=["Python","C++","Java","C#"]

for i in langs
    puts "lang: "+i.to_s
end

langs.each do |lang|
    puts "lang: "+lang.to_s
end

array = [1,2,3,4,5,6,7,8,9,10]
for value in array 
    puts value
end

for value in 1..10
    puts "value: "+value.to_s
end

4.times do|number|
    puts "number: "+number.to_s
end