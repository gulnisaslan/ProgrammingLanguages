import random

# result  =  help(random)
# result = dir(random)
result =random.random() # 0.0 -1.0
result =random.random()*100 # 0.0 -1.0
result=int(random.uniform(10,100))
result = random.randint(1,100)



greeting ="Hello there"
names = ["Nisa", "Beyza","Zehra","Cenk"]
result =names[random.randint(0,len(names)-1)]
result = random.choice(names)
result= random.choice(greeting)


liste = list(range(10))
random.shuffle(liste)
result = liste

liste =  range(100)
result = random.sample(liste,3)
result = random.sample(names,2)


print(result)

#['BPF', 'LOG4', 'NV_MAGICCONST', 'RECIP_BPF', 'Random', 'SG_MAGICCONST', 'SystemRandom', 'TWOPI', '_Sequence', '_Set', '__all__', '__builtins__', '__cached__', '__doc__', '__file__', '__loader__', '__name__', '__package__', '__spec__', '_accumulate', '_acos', '_bisect', '_ceil', '_cos', '_e', '_exp', '_inst', '_log', '_os', '_pi', '_random', '_repeat', '_sha512', '_sin', '_sqrt', '_test', '_test_generator', '_urandom', '_warn', 
#'betavariate', 'choice', 'choices', 'expovariate', 'gammavariate', 'gauss', 'getrandbits', 'getstate', 'lognormvariate', 'normalvariate', 'paretovariate', 'randint', 'random', 'randrange', 'sample', 'seed', 'setstate', 'shuffle', 'triangular', 'uniform', 'vonmisesvariate', 'weibullvariate']