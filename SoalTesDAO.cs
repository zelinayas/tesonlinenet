using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SoalTesDAO
    {
        [TestMethod]
        public void TestMethod1()
        {
            SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 0;
            SOAL expectedResult = null; //nama model //bisa pakai .isNull
            SOAL result = soal.detail(id);
            Assert.AreEqual(expectedResult, result);


        }

        [TestMethod]
        public void TestMethod2()
        {
            SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            SOAL result = soal.detail(id);
            Assert.IsNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethod3()
        {
            SoalDAO soal = new SoalDAO();   //nama DAO
            int id = 2;

            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            SOAL result = soal.detail(id);
            Assert.IsNull(result);


        }

    }
}
