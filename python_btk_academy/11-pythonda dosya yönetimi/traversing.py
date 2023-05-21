with open("newfile2.text","r",encoding="utf-8")as file:
    content=file.read(10)
    print(content)
    print(file.tell())
    file.seek(0)
    content2=file.read()
    print(content2)
    





