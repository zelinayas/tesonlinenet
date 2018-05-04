using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SubtesTesDAO
    {
        SubtesDAO sub = new SubtesDAO(); //nama DAO
        
        
        [TestMethod]
        public void TestMethodDetail()
        {
            
            int id = 0;
            SOAL expectedResult = null; //nama model //bisa pakai .isNull
            SUBTES result = sub.detail(id);
            //Assert.IsNull(result);
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethodTampilDataBenar()
        {
            
            int id = 1;
            SUBTES result = sub.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

        //[Timeout(1000)]
        //[TestMethod]
        //public void TestMethodGetall()
        //{
            
        //    Assert.IsNotNull(sub.getAll());
        //    //Thread.Sleep(2000);
        //}


        [TestMethod] //passTambah
        public void TestMethodTambahSubtes()
        {

            SUBTES ss = new SUBTES();
            //ss.ID_SUBTES = 10;
            ss.DURASI_SUB = DateTime.Now;
            int x = sub.add(ss);
            Trace.WriteLine(ss.ID_SUBTES); //kepake di transdetail
            //Assert.AreEqual(1,x);


        }

       
        [TestMethod] //passGagalTambah
        public void TestMethodGagalTambahSubtes()
        {

           
            SUBTES s = new SUBTES();
            //s.ID_SUBTES = 5;
            s.DURASI_SUB = DateTime.Now;
            int x = sub.add(s);
            Assert.AreEqual(1,x);

        }

        [TestMethod] //passDelete 3
        public void TestMethodDeleteSubtesBenar()
        {


            SUBTES ss = sub.detail(3);
            Assert.IsNotNull(sub);
            int a = sub.delete(3);
            Assert.AreEqual(1, a);

        }

        [TestMethod]
        public void TestMethod6()
        {
            SUBTES s = new SUBTES();
            s.ID_SUBTES = 1;
            int x = sub.add(s);
            Assert.AreEqual(1, x);  //1 itu row affected

        }

        [TestMethod] //passCekDurasi
        public void TestMethodDurasiG()
        {
            SUBTES ss = sub.detail(3);
            Assert.AreNotEqual("2018-05-02 14:15:10.687", ss.DURASI_SUB);

        }

        [TestMethod] //passGagalCekDurasi
        public void TestMethodDurasi()
        {
            SUBTES ss = sub.detail(3);
            Assert.AreNotEqual("5/2/2018 2:15:10", ss.DURASI_SUB);

        }


        //[TestMethod] //passCekDurasi
        //public void TestMethodSearchbyNumber()
        //{
        //    SUBTES search = new SUBTES();
        //    //var ss = sub.search;
        //    var q = from x in sub.search
        //            where x.Durasi.StartsWith("2")
        //            select x;
        //    q.ToList().ForEach(bawahan => Console.WriteLine(bawahan.Nama));
        //    SUBTES ss = sub.detail(3);
        //    Assert.AreNotEqual("2018-05-02 14:15:10.687", ss.DURASI_SUB);

        //}

        [TestMethod] //passEdit
        public void TestMethodEdit()
        {
            int ID = 2;
            SUBTES cekDetail =  sub.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SUBTES = ID;
            cekDetail.DURASI_SUB = DateTime.Now;
            cekDetail.Modified_by = "bibi";
            int x = sub.edit(ID, cekDetail);
            Assert.AreEqual(1,x);
 
        }

        [TestMethod] //passGagalEdit
        public void TestMethodEditG()
        {
            int ID = 10;
            SUBTES cekDetail = sub.detail(ID);
            //Assert.IsNotNull(cekDetail);
            cekDetail.ID_SUBTES = ID;
            cekDetail.DURASI_SUB = DateTime.Now;
            int x = sub.edit(ID, cekDetail);
            Assert.AreEqual(1, x);

        }






    }

}
    

