  //-----------ALERT()/WINDOW.ALERT()--------------------
     //alert:Sayfa içerisinde uyarı penceresi açar. Belirtilen uyarıyı ekranda gösterir.
     //window.alert():Sayfa içerisinde uyarı penceresi açar. Belirtilen uyarıyı ekranda gösterir.Nesnel bir işlemdir.(bom->Browser Object method)
     alert("Merhaba");
     debugger;
     window.alert("Merhaba javascript");
     debugger;
     //-------------------------DOCUMENT.WRITE/WRITELN----------------------
     //document.write():dökümana cıktı yapar.(DOM->Document Object Model)
     //document.write():dökümana cıktı yapar.(DOM->Document Object Model)-(Satır başı yapar)

     document.write("hello ");
     debugger;
     document.write("Javascript");
     debugger;

     document.writeln("\nhello");
     debugger;
     document.writeln("Javascript");
     debugger;
     
     
     //------------------------CONSOLE.LOG------------------
     //console.log():web tarayıcısının console'una değer ataması yapar veya kayıt yapar.
     console.log("merhaba javascript. seni öğreneceğim.")
     debugger;
     
     //------------------INNER.HTML------------
     //   inner.HTML:html dökümanı içerisinde bulunan HTMl elemanı/elementine etki ederek veri gönderir 
     //veri değişimi yapar

     document.getElementById("hello").innerHTML="Merhaba Gülnisa Aslan";
     debugger;
     //---------DEBUGGER ---
     //DEBUGGER;