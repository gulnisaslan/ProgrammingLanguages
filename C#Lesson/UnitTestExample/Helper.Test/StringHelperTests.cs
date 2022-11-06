using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Test
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_Ifadedenin_basindaki_Fazla_Bosluklar_Silinmelidir()
        {
            //Arrange
            var ifade = "   Salih Demiroğ  ";
            var beklenenIfade = "Salih Demiroğ";
            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);
            //Assert 
            Assert.AreEqual(beklenenIfade, gerceklesen);
        }
        [TestMethod]
        public void Girilen_Ifadedeki_Fazla_Bosluklar_Silinmelidir()
        {
            //Arrange
            var ifade = "Salih   Demiroğ   Engin   Demiroğ   Ahmet          Sait        Duran ";
            var beklenenIfade = "Salih Demiroğ Engin Demiroğ Ahmet Sait Duran";
            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);
            //Assert 
            Assert.AreEqual(beklenenIfade, gerceklesen);
        }

    }
}
