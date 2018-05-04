using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class PesertaJawabanDetailTesDAO
    {
        PesertaJawabanDetailDAO pesertajwban = new PesertaJawabanDetailDAO();

        [TestMethod]
        public void TestMethodPesertajwbnDetail()
        {

        }

        [TestMethod]
        public void TestMethodDetailPesertajwbnDetail()
        {

            int id = 0;
            PESERTA_JAWABAN_DETAIL expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_JAWABAN_DETAIL result = pesertajwban.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarPesertajwbnDetail()
        {

            int id = 1;
            PESERTA_JAWABAN_DETAIL result = pesertajwban.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetallPesertajwbnDetail()
        {

            Assert.IsNotNull(pesertajwban.getAll());

        }


        [TestMethod] //passTambah
        public void TestMethodTambahPesertajwbnDetail()
        {

            PESERTA_JAWABAN_DETAIL tt = new PESERTA_JAWABAN_DETAIL();
            //t.ID_SUBTES = 10; 
            //t.ID_SUBTESSOAL = 3;
            int x = pesertajwban.add(tt);
            //Trace.WriteLine(t.ID_SOAL);
            Assert.AreEqual(1, x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahPesertajwbnDetail()
        {


            PESERTA_JAWABAN_DETAIL s = new PESERTA_JAWABAN_DETAIL();
            //s.ID_SUBTES = 5;
            //s.DURASI_SUB = DateTime.Now;
            int x = pesertajwban.add(s);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passDelete 3
        public void TestMethodDeletePesertajwbnDetailBenar()
        {


            PESERTA_JAWABAN_DETAIL ss = pesertajwban.detail(3);
            Assert.IsNotNull(pesertajwban);
            int a = pesertajwban.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodPesertajwbnDetails()
        {
            PESERTA_JAWABAN_DETAIL s = new PESERTA_JAWABAN_DETAIL();
            //s.ID_SUBTES = 1;
            int x = pesertajwban.add(s);
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
        public void TestMethodEditPesertajwbnDetail()
        {
            int ID = 3;
            PESERTA_JAWABAN_DETAIL cekDetail = pesertajwban.detail(ID);
            //Assert.IsNotNull(cekDetail);
            //cekDetail.i = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = pesertajwban.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditPesertajwbnDetailf()
        {
            int ID = 10;
            PESERTA_JAWABAN_DETAIL cekDetail = pesertajwban.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SOAL = ID;
            //cekDetail.DURASI_SUB = DateTime.Now;
            int x = pesertajwban.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodPesertajwbnDetaily()
        {

            int id = 0;
            //SOAL expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_JAWABAN_DETAIL result = pesertajwban.detail(id);
            Assert.IsNull(result);


        }

        [TestMethod]
        public void TestMethodPesertajwbnDetailq()
        {
            // SoalDAO soal = new SoalDAO(); //nama DAO
            int id = 1;
            //SOAL expectedResult = null; //nama model
            PESERTA_JAWABAN_DETAIL result = pesertajwban.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodPesertajwbnDetailas()
        {
            //SoalDAO soalDAO = new SoalDAO();   //nama DAO

            PESERTA_JAWABAN_DETAIL subtess = new PESERTA_JAWABAN_DETAIL();
            subtess.ID_PESERTA_TEST = 1;
            int x = pesertajwban.add(subtess);

            //SOAL result = soal.add(soal);
            //SOAL expectedResult = soal.detail(id);   //nama model //bisa pakai .isNull
            //SOAL result = soal.detail(id);
            Assert.AreEqual(1, x);



        }
    }
}
