using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SoalTesDAO
    {
        SoalDAO soal = new SoalDAO(); //nama DAO

        [TestMethod]
        public void TestMethod1()
        {
            
            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            SOAL result = soal.detail(id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
           // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            SOAL result = soal.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }
        
        [TestMethod]
        public void TestMethod3()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            SOAL s = new SOAL();
            s.ID_SOAL = 1;
            int x = soal.add(s);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(1, x);

        }

    }
}
