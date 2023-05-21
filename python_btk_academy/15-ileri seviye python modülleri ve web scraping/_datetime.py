from datetime import datetime
from datetime import timedelta

# from datetime import date
# from datetime import time
#import datetime


result=datetime.now()
result=datetime.now()
#result=help(datetime)
simdi=datetime.now()
simdi=datetime.today()
result=simdi.year
result=simdi.month
result=simdi.day
result=simdi.minute
result=datetime.ctime(simdi)
result=datetime.strftime(simdi,"%A")#gün bilgisini verir.
result=datetime.strftime(simdi,"%X")#saat bilgisi
result=datetime.strftime(simdi,"%Y")#yılı verir
result=datetime.strftime(simdi,"%d")#gün bilgisini verir.
result=datetime.strftime(simdi,"%B")#ay bilgisini verir
result=datetime.strftime(simdi,"%A %B %Y")
t="01 April 1996 hour 10:30:30"
result=datetime.strptime(t,"%d %B %Y hour %H:%M:%S")
result=result.year
birthday=datetime(1996,4,1)

result=datetime.timestamp(birthday)#saniye
result=datetime.fromtimestamp(result)#saniye from datetime
result=datetime.fromtimestamp(0)

result=simdi-birthday #timedelta
#result=result.days
#result=result.seconds
result=result.microseconds

#result=simdi+timedelta(days=10)
result=simdi+timedelta(days=720,minutes=50)
result=simdi-timedelta(days=10)


print(result)



