#Dosya açmak ive olusturmak için open() fonksiyonu kullanılır.
# Kullanımı : open(dosya_adi,dosya_erisme_modu)
# dosya_erisme_modu=> dosyayı hangi amamçla açtığımızı belirtir.

# "w":(write) yazma modu. dosyayı konumda oluşturur.
# ** dosyayı komuda oluşturur.
# **dosya içeriğini siler ve yeniden ekleme yapar
# file=open("c:/Users/Admin/Desktop/new.text","w")
# file=open("newfile.txt","w",encoding="utf-8")
# file.write("Gülnisa aslan\n")
# file.close()
# print(file)


# "a":(append) ekleme dosya konumda yoksa oluşturur.
# file=open("newfile.txt","a",encoding="utf-8")
# file.write("muhammet haşim aslan\n")
# file.close()
# print(file)

# "x": (create) oluşturma.dosya zaten varsa hata verir.
#file=open("newfile2.txt","x",encoding="utf-8")

# "r":(read) okuma.varsayılan. dosya konumda yoksa hata verir.

file=open("newfile2.text","w",encoding="utf-8")
file.write("qwrtyuıopğüasdfgjhbhklşzxcvbnmöç123456789")
