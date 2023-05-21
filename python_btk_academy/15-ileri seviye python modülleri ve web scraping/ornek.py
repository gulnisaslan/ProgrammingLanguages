import requests
from bs4 import BeautifulSoup

url="https://www.hepsiburada.com/apple/laptop-notebook-dizustu-bilgisayarlar"
html = requests.get(url).content
soup = BeautifulSoup(html,"html.parser")

    