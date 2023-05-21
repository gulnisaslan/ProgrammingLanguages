html_doc="""
<div class="GRUP1">
          <h2>
               PROGRAMLAMA
          </h2>
          <ul>
               <li> MENÜ1</li>
               <li>MENÜ2 </li>
               <li>MENÜ3</li>
          </ul>
          <div class="grup 2">
               <h2>
                    modüller
               </h2>
               <ul>
                    <li> MENÜ1 </li>
                    <li> MENÜ2</li>
                    <li> MENÜ3 </li>
               </ul>
     
          </div>

      </div>
      <div class="grup 3">
          <h2>
              Django
          </h2>
          <ul>
               <li> MENÜ1 </li>
               <li> MENÜ2</li>
               <li> MENÜ3 </li>
          </ul>

     </div>
     <img src="unnamed.jpg" alt="">
     <a class="sister" href="http://example1.com/elsie" id="link1">Elsie</a>
     <a class="sister" href="http://example2.com/elsie" id="link1">Elsie</a>
     <a class="sister" href="http://example3.com/elsie" id="link1">Elsie</a>

"""




from bs4 import BeautifulSoup

soup=BeautifulSoup(html_doc,'html.parser')
# result=soup.prettify()
# result=soup.title
# result=soup.head
# result=soup.body
# result=soup.title.name
# result=soup.title.string
# result=soup.h1
# result=soup.h2.string

# result=soup.find_all('h2')
# result=soup.find_all('h2')[0]
# result=soup.find_all('h2')[1]
# result=soup.div
# result=soup.find_all('div')[1].ul.find_all('li')
# result=soup.div.findChildren()
# result=soup.div.findNextSibling().findPreviousSibling()
result=soup.find_all('a')
for link in result:
     print(link.get)

# print(result)

