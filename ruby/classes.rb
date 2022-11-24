class Film 
    attr_accessor :title, :director, :stars,
    def def initialize(title,director,stars)
        @title = title
        @director = director
        @stars = stars

    end
    def isActorIncluded(actorName)
        isIncluded=false
        for value in stars
           if (actorName == value)
              isIncluded=true
           end
        end
          if isIncluded
            puts "aradığınız actor bulunmuştur"
       
          else
            puts "aradığınız actor bulunmuyor"
          end
    end
    
    
end

film1 = Film.new() 
film2 = Film.new() 

film3 = Film.new("Sözün özü","Bilmiyorum",["000000","11111","22222"])

film1.title ="Masumiyet"
film1.director = "Zeki DemirKubuz"
film1.stars=["Haluk Bilginer","Derya Alabora","Guven kırac"]

film2.title ="Yüzüklerin Efendisi"
film2.director = "Peter Jackson"
film2.stars=["Ellijah Wood","Ian Mckellen","Orlando bloom"]

puts film1.title
puts film2.title
puts film1.director
puts film2.director
film1.isActorIncluded("Haluk Bilginer")