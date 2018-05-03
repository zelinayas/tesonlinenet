using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Online;

namespace Test_OnlineTES
{
    [TestClass]
    public class PesertaJawabanDetailTesDAO
    {
        Peserta_Jawaban_DetailDAO pes = new Peserta_Jawaban_DetailDAO();

        [TestMethod]
        public void TestMethodPesertaJawabanDetail()
        {

        }

        [TestMethod]
        public void TestMethodDetailPesertaJawabanDetail()
        {
            int id = 0;
            PESERTA_JAWABAN_DETAIL expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_JAWABAN_DETAIL result = pes.detail(id);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarPesertaJawabanDetail()
        {

            int id = 1;
            PESERTA_JAWABAN_DETAIL result = pes.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetallPesertaJawabanDetail()
        {
             Assert.IsNotNull(pes.getAll());
        }


        [TestMethod] //passTambah
        public void TestMethodTambahPesertaJawabanDetail()
        {
            PESERTA_JAWABAN_DETAIL p = new PESERTA_JAWABAN_DETAIL();
            int x = pes.add(p);
            Assert.AreEqual(1, x);
        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahPesertaJawabanDetail()
        {
            PESERTA_JAWABAN_DETAIL p = new PESERTA_JAWABAN_DETAIL();
            int x = pes.add(p);
            Assert.AreEqual(1, x);
        }

        [TestMethod] //passDelete 3
        public void TestMethodDeletePesertaTesBenar()
        {


            PESERTA_JAWABAN_DETAIL pt = pes.detail(3);
            Assert.IsNotNull(pes);
            int a = pes.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodTess()
        {
            PESERTA_JAWABAN_DETAIL p = new PESERTA_JAWABAN_DETAIL();
            int x = pes.add(p);
            Assert.AreEqual(-1, x);  //1 itu row affected

        }



        [TestMethod] //passEdit
        public void TestMethodEditPesertaTes()
        {
            int ID = 3;
            PESERTA_JAWABAN_DETAIL cekDetail = pes.detail(ID);
            cekDetail.ID_JWBNPESERTA = ID;
            int x = pes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditTess()
        {
            int ID = 10;
            PESERTA_JAWABAN_DETAIL cekDetail = pes.detail(ID);
            cekDetail.ID_JWBNPESERTA = ID;
            int x = pes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodTesq()
        {
            int id = 0;
            PESERTA_JAWABAN_DETAIL result = pes.detail(id);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestMethodTesqq()
        {
            int id = 1;
            PESERTA_JAWABAN_DETAIL result = pes.detail(id);
            Assert.IsNull(result); //jika sudah diisi akan ceklist
        }

        [TestMethod]
        public void TestMethodTesf()
        {
            PESERTA_JAWABAN_DETAIL p = new PESERTA_JAWABAN_DETAIL();
            p.ID_JWBNPESERTA = 1;
            int x = this.pes.add(p);
            Assert.AreEqual(-1, x);
        }
    }
}
