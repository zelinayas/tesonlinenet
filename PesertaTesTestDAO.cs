using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Online;

namespace Test_OnlineTES
{
    [TestClass]
    public class PesertaTesTestDAO
    {
        Peserta_TesDAO pes_tes = new Peserta_TesDAO() ;

        [TestMethod]
        public void TestMethodPesertaTes()
        {

        }

        [TestMethod]
        public void TestMethodDetailPesertaTes()
        {
            int id = 0;
            PESERTA_TES expectedResult = null; //nama model //bisa pakai .isNull
            PESERTA_TES result = pes_tes.detail(id);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenarPesertaTes()
        {

            int id = 1;
            PESERTA_TES result = pes_tes.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        [TestMethod]
        public void TestMethodGetallPesertaTes()
        {

            Assert.IsNotNull(pes_tes.getAll());

        }


        [TestMethod] //passTambah
        public void TestMethodTambahPesertaTes()
        {

            PESERTA_TES p = new PESERTA_TES();
            int x = pes_tes.add(p);
            Assert.AreEqual(1, x);


        }

        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahPesertaTes()
        {
            PESERTA_TES p = new PESERTA_TES();
            int x = pes_tes.add(p);
            Assert.AreEqual(1, x);
        }

        [TestMethod] //passDelete 3
        public void TestMethodDeletePesertaTesBenar()
        {


            PESERTA_TES pt = pes_tes.detail(3);
            Assert.IsNotNull(pes_tes);
            int a = pes_tes.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethodTess()
        {
            PESERTA_TES p = new PESERTA_TES();
            int x = pes_tes.add(p);
            Assert.AreEqual(-1, x);  //1 itu row affected

        }

        

        [TestMethod] //passEdit
        public void TestMethodEditPesertaTes()
        {
            int ID = 3;
            PESERTA_TES cekDetail = pes_tes.detail(ID);
            cekDetail.ID_PESERTA_TEST = ID;
            int x = pes_tes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditTess()
        {
            int ID = 10;
            PESERTA_TES cekDetail = pes_tes.detail(ID);
            cekDetail.ID_PESERTA_TEST = ID;
            int x = pes_tes.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }


        [TestMethod]
        public void TestMethodTesq()
        {
            int id = 0;
            PESERTA_TES result = pes_tes.detail(id);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestMethodTesqq()
        {
            int id = 1;
            PESERTA_TES result = pes_tes.detail(id);
            Assert.IsNull(result); //jika sudah diisi akan ceklist
        }

        [TestMethod]
        public void TestMethodTesf()
        {
            PESERTA_TES pes = new PESERTA_TES();
            pes.ID_PESERTA_TEST = 1;
            int x = pes_tes.add(pes);
            Assert.AreEqual(-1, x);
        }
    }
}
