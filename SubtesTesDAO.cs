using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesOnline;

namespace TesOnlineTes
{
    [TestClass]
    public class SubtesTesDAO
    {
        SubtesDAO sub = new SubtesDAO(); //nama DAO
        

        //[TestMethod]
        //public void TestMethod4()
        //{

        //    int id = 0;
        //    //SOAL expectedResult = null; //nama model //bisa pakai .isNull
        //    SUBTES result = subtes.detail(id);
        //    Assert.IsNull(result);


        //}

        [TestMethod]
        public void TestMethod5()
        {
            
            int id = 1;
            SUBTES result = sub.detail(id);
            Assert.IsNotNull(result); //jika sudah diisi akan ceklist

        }

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

            SUBTES cekDetail =  sub.detail(1);
            Assert.IsNotNull(cekDetail);
            //SUBTES sub = new SUBTES();
            //sub.ID_SUBTES = 1;
            //cekDetail.ID_SUBTES = 1;
            cekDetail.DURASI_SUB = DateTime.Now;
            int x = sub.edit(1, cekDetail);
            Assert.AreEqual(1,x);
            //jancuk

        }

    }

}
    

