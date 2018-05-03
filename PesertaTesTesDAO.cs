using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class PesertaTesTesDAO
    {
        PesertaTesDAO pesertates = new PesertaTesDAO();

        [TestMethod]
        public void TestMethodPesertaTes()
        {

        }

        [TestMethod]
        public void TestMethodDetailPesertaTes()
        {

            int id = 0;
            PESERTA_TES expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_TES result = pesertates.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarpesertates()
        {

            int id = 1;
            PESERTA_TES result = pesertates.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetallpesertates()
        {

            Assert.IsNotNull(pesertates.getAll());

        }


        [TestMethod] //passTambah
        public void TestMethodTambahpesertates()
        {

            PESERTA_TES tt = new PESERTA_TES();
            //t.ID_SUBTES = 10; 
            //t.ID_SUBTESSOAL = 3;
            int x = pesertates.add(tt);
            //Trace.WriteLine(t.ID_SOAL);
            Assert.AreEqual(1, x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahpesertates()
        {


            PESERTA_TES s = new PESERTA_TES();
            //s.ID_SUBTES = 5;
            //s.DURASI_SUB = DateTime.Now;
            int x = pesertates.add(s);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passDelete 3
        public void TestMethodDeletepesertatesBenar()
        {


            PESERTA_TES ss = pesertates.detail(3);
            Assert.IsNotNull(pesertates);
            int a = pesertates.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodpesertates()
        {
            PESERTA_TES s = new PESERTA_TES();
            //s.ID_SUBTES = 1;
            int x = pesertates.add(s);
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
        public void TestMethodEditpesertates()
        {
            int ID = 3;
            PESERTA_TES cekDetail = pesertates.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_PESERTA = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = pesertates.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditpesertatess()
        {
            int ID = 10;
            PESERTA_TES cekDetail = pesertates.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SUBTES = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = pesertates.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodpesertates()
        {

            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_TES result = pesertates.detail(id);
            Assert.IsNull(result);


        }

        [TestMethod]
        public void TestMethodpesertatessq()
        {
            // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            PESERTA_TES result = pesertates.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodpesertatesf()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            PESERTA_TES subtess = new PESERTA_TES();
            subtess.ID_PESERTA = 1;
            int x = pesertates.add(subtess);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(1, x);



        }

    }
}
