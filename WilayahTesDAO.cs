using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Online;

namespace Test_OnlineTES
{
    [TestClass]
    public class WilayahTesDAO
    {
        WilayahDAO wil = new WilayahDAO();

        [TestMethod]
        public void TestMethodWilayah()
        {

        }

        [TestMethod]
        public void TestMethodDetailWilayah()
        {

            int id = 0;
            WILAYAH expectedResult = null; //nama model //bisa pakai .isNull
            WILAYAH result = wil.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarTes()
        {

            int id = 1;
            WILAYAH result = wil.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetallWilayah()
        {

            Assert.IsNotNull(wil.getAll());

        }


        [TestMethod] //passTambah
        public void TestMethodTambahWilayah()
        {

            WILAYAH w = new WILAYAH();
            //t.ID_SUBTES = 10; 
            //t.ID_SUBTESSOAL = 3;
            int x = wil.add(w);
            //Trace.WriteLine(t.ID_SOAL);
            Assert.AreEqual(1, x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahWilayah()
        {


            WILAYAH w = new WILAYAH();
            //s.ID_SUBTES = 5;
            //s.DURASI_SUB = DateTime.Now;
            int x = wil.add(w);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passDelete 3
        public void TestMethodDeleteWilayahBenar()
        {


            WILAYAH ss = wil.detail(3);
            Assert.IsNotNull(wil);
            int a = wil.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodTess()
        {
            WILAYAH w = new WILAYAH();
            //s.ID_SUBTES = 1;
            int x = wil.add(w);
            Assert.AreEqual(-1, x);  //1 itu row affected

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
        public void TestMethodEditWilayah()
        {
            int ID = 3;
            WILAYAH cekDetail = wil.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_PROFIL = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = wil.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditTess()
        {
            int ID = 10;
            WILAYAH cekDetail = wil.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_PROFIL = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = wil.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodTesq()
        {

            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            WILAYAH result = wil.detail(id);
            Assert.IsNull(result);


        }

        [TestMethod]
        public void TestMethodTesqq()
        {
            // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            WILAYAH result = wil.detail(id);
            Assert.IsNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodTesf()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            WILAYAH wilayah = new WILAYAH();
            wilayah.ID_PROFIL = 1;
            int x = wil.add(wilayah);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(-1, x);



        }

    }
}
