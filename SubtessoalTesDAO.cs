using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SubtessoalTesDAO
    {
        SubtessoalDAO subtessoal = new SubtessoalDAO();

        [TestMethod]
        public void TestMethodDetail()
        {

            int id = 0;
            SUBTESSOAL expectedResult = null; //nama model //bisa pakai .isNull
            SUBTESSOAL result = subtessoal.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenar()
        {

            int id = 1;
            SUBTESSOAL result = subtessoal.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetall()
        {

            Assert.IsNotNull(subtessoal.getAll());

        }


        [TestMethod] //passTambah
        public void TestMethodTambahSub()
        {

            SUBTESSOAL ss = new SUBTESSOAL();
            //ss.ID_SUBTES = 10; 
            //ss.ID_SUBTESSOAL = 3;
            int x = subtessoal.add(ss);
            Trace.WriteLine(ss.ID_SOAL);
           // Assert.AreEqual(1,x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahSubtes()
        {


            SUBTESSOAL s = new SUBTESSOAL();
            //s.ID_SUBTES = 5;
            //s.DURASI_SUB = DateTime.Now;
            int x = subtessoal.add(s);
            Assert.AreEqual(1, x);

        }

        //[TestMethod] //passDelete 3
        //public void TestMethodDeleteSubtesBenar()
        //{


        //    SUBTESSOAL ss = subtessoal.detail(3);
        //    Assert.IsNotNull(subtessoal);
        //    int a = subtessoal.delete(3);
        //    Assert.AreEqual(1, a);

        //}

        [TestMethod]
        public void TestMethod6()
        {
            SUBTESSOAL s = new SUBTESSOAL();
            //s.ID_SUBTES = 1;
            int x = subtessoal.add(s);
            Assert.AreEqual(1, x);  //1 itu row affected

        }

        //[TestMethod] //passCekDurasi
        //public void TestMethodDurasiG()
        //{
        //    SUBTESSOAL ss = subtessoal.detail(3);
        //    Assert.AreNotEqual("2018-05-02 14:15:10.687", ss.DURASI_SUB);

        //}

        //[TestMethod] //passGagalCekDurasi
        //public void TestMethodDurasi()
        //{
        //    SUBTES ss = sub.detail(3);
        //    Assert.AreNotEqual("5/2/2018 2:15:10", ss.DURASI_SUB);

        //}

        //[TestMethod] //passEdit
        //public void TestMethodEdit()
        //{
        //    int ID = 3;
        //    SUBTESSOAL cekDetail = subtessoal.detail(ID);
        //    //Assert.IsNotNull(cekDetail);
        //    cekDetail.ID_SUBTES = ID;
        //    cekDetail.DURASI_SUB = DateTime.Now;
        //    int x = sub.edit(ID, cekDetail);
        //    Assert.AreEqual(1, x);

        //}

        //[TestMethod] //passGagalEdit
        //public void TestMethodEditG()
        //{
        //    int ID = 10;
        //    SUBTES cekDetail = sub.detail(ID);
        //    //Assert.IsNotNull(cekDetail);
        //    cekDetail.ID_SUBTES = ID;
        //    cekDetail.DURASI_SUB = DateTime.Now;
        //    int x = sub.edit(ID, cekDetail);
        //    Assert.AreEqual(1, x);

        //}


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
