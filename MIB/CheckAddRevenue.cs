using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MIB
{
    [TestFixture]
    public class CheckAddRevenue
    {
        public MyWallet TestWallet = new MyWallet();

        [SetUp]
        public void SetUp()
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(TestWallet.data, startupPath);
        }
        [Test]
        public void Add3kVNDRevenue()
        {
            DataType tmpData = new DataType();
            tmpData.type = "revenue";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "3";
            tmpData.unit = "thousand VND";
            tmpData.describe = "cafee";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add4000VNDRevenue()
        {
            DataType tmpData = new DataType();
            tmpData.type = "revenue";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "4000";
            tmpData.unit = "VND";
            tmpData.describe = "ban hoa\nqua";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add4_Hundred_Thousand_VNDRevenue()
        {
            DataType tmpData = new DataType();
            tmpData.type = "revenue";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "4";
            tmpData.unit = "hundred thousand VND";
            tmpData.describe = "ban chim";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add50_Milion_VNDRevenue()
        {
            DataType tmpData = new DataType();
            tmpData.type = "revenue";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "50";
            tmpData.unit = "milion thousand VND";
            tmpData.describe = "bán gỗ hương";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add6_Bilion_VNDRevenue()
        {
            DataType tmpData = new DataType();
            tmpData.type = "revenue";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "6";
            tmpData.unit = "bilion thousand VND";
            tmpData.describe = "bán nhà nguyễn kim";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }
    }
}
