using System;
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

        //[TestMethod]
        //public void TestMethodDetail()
        //{

        //    int ID = 1;
        //    SUBTES subt = sub.detail(ID);
        //    Assert.AreEqual("ubah lagi", subt.DURASI_SUB);
            
        //}

        [TestMethod]
        public void TestMethodGetall()
        {

            Assert.IsNotNull(sub.getAll());

        }

        [TestMethod]
        public void TestMethodTambahSubtes()
        {


            SUBTES s = new SUBTES();
            s.ID_SUBTES = 3;
            s.DURASI_SUB = DateTime.Now;
            int x = sub.add(s);
            Assert.AreEqual(1,x);

        }

        //[TestMethod] //berhasil delete 3
        //public void TestMethodDeleteSubtesBenar()
        //{


        //    SUBTES ss = sub.detail(3);
        //    Assert.IsNotNull(sub);
        //    //ss.isPermanent = false;
        //    int a = sub.delete(3);
        //    Assert.AreEqual(1, a);

        //}

        [TestMethod]
        public void TestMethod6()
        {
           

            SUBTES s = new SUBTES();
            s.ID_SUBTES = 1;
            int x = sub.add(s);
            Assert.AreEqual(1, x);

        }

        [TestMethod]
        public void TestMethodEdit()
        {

            SUBTES cekDetail =  sub.detail(2);
            Assert.IsNotNull(cekDetail);
            //cekDetail.ID_SUBTES = 2;
            cekDetail.DURASI_SUB = DateTime.Now;
            int x = sub.edit(2, cekDetail);
            Assert.AreEqual(1,x);
            

        }

        //[TestMethod]
        //public void TestMethodDelete()
        //{

        //    //SUBTES subt = sub.detail(2);
        //   // subt.ID_SUBTES = 2;
        //    int x = sub.delete(2);
        //    Assert.(2);


        //}



    }

}
    

