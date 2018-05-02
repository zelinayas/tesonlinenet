using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SubtessoalTesDAO
    {
        SubtessoalDAO subtessoal = new SubtessoalDAO();

        [TestMethod]
        public void TestMethod7()
        {

            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            SUBTESSOAL result = subtessoal.detail(id);
            Assert.IsNull(result);


        }

        [TestMethod]
        public void TestMethod8()
        {
            // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            SUBTESSOAL result =  subtessoal.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethod9()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            SUBTESSOAL subtess = new SUBTESSOAL();
            subtess.ID_SUBTESSOAL = 1;
            int x = subtessoal.add(subtess);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(1, x);



        }

    }
}
