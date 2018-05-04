using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class TesTesDAO
    {
        TesDAO tes = new TesDAO();

        [TestMethod]
        public void TestMethodTes()
        {

        }

        [TestMethod]
        public void TestMethodDetailTes()
        {

            int id = 0;
            TES expectedResult = null; //nama model //bisa pakai .isNull
            TES result = tes.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarTes()
        {

            int id = 1;
            TES result = tes.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        //[TestMethod]
        //public void TestMethodGetallTes()
        //{

        //    Assert.IsNotNull(tes.getAll());

        //}


        [TestMethod] //passTambah
        public void TestMethodTambahTes()
        {

            TES t = new TES();
            //t.ID_SUBTES = 10; 
            //t.ID_SUBTESSOAL = 3;
            int x = tes.add(t);
            //Trace.WriteLine(t.ID_SOAL);
            Assert.AreEqual(1,x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahTes()
        {


            TES s = new TES();
            //s.ID_SUBTES = 5;
            //s.DURASI_SUB = DateTime.Now;
            int x = tes.add(s);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passDelete 3
        public void TestMethodDeleteTesBenar()
        {


            TES ss = tes.detail(3);
            Assert.IsNotNull(tes);
            int a = tes.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodTess()
        {
            TES s = new TES();
            //s.ID_SUBTES = 1;
            int x = tes.add(s);
            Assert.AreEqual(1, x);  //1 itu row affected

        }

        //[TestMethod] //passCekDurasi
        //public void TestMethodDurasiTes()
        //{
        //    TES ss = tes.detail(3);
        //    Assert.AreNotEqual("2018-05-02 14:15:10.687", ss.DURASI_SUB);

        //}

        //[TestMethod] //passGagalCekDurasi
        //public void TestMethodDurasi()
        //{
        //    SUBTES ss = sub.detail(3);
        //    Assert.AreNotEqual("5/2/2018 2:15:10", ss.DURASI_SUB);

        //}

        [TestMethod] //passEdit
        public void TestMethodEditTes()
        {
            int ID = 3;
            TES cekDetail = tes.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SUBTES = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = tes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditTess()
        {
            int ID = 10;
            TES cekDetail = tes.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SUBTES = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = tes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodTesq()
        {

            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            TES result = tes.detail(id);
            Assert.IsNull(result);


        }

        [TestMethod]
        public void TestMethodTesqq()
        {
            // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            TES result = tes.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        

        [TestMethod]
        public void TestMethodTesf()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            TES subtess = new TES();
            subtess.ID_SUBTES  = 1;
            int x = tes.add(subtess);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(1, x);
        }
       
    }

}

