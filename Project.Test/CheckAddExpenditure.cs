using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project.Test
{
    [TestFixture]
    class CheckAddExpenditure
    {
        public MIB.MyWallet TestWallet = new MIB.MyWallet();
        string startupPath = "";

        [SetUp]
        public void SetUp()
        {
            startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(TestWallet.data, startupPath);
        }
        [Test]
        public void Add5_thousand_VND_Expenditure()
        {
            MIB.DataType tmpData = new MIB.DataType();
            tmpData.type = "expenditure";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "5";
            tmpData.unit = "thousand VND";
            tmpData.describe = "uong cafee";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add9000VNDExpenditure()
        {
            MIB.DataType tmpData = new MIB.DataType();
            tmpData.type = "expenditure";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "9000";
            tmpData.unit = "VND";
            tmpData.describe = "mua chim hoa\nqua";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add7_Hundred_Thousand_VND_Expenditure()
        {
            MIB.DataType tmpData = new MIB.DataType();
            tmpData.type = "expenditure";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "7";
            tmpData.unit = "hundred thousand VND";
            tmpData.describe = "mua ca chim";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add30_Milion_VND_Expenditure()
        {
            MIB.DataType tmpData = new MIB.DataType();
            tmpData.type = "expenditure";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "30";
            tmpData.unit = "milion thousand VND";
            tmpData.describe = "mua xe ex";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }

        [Test]
        public void Add5_Bilion_VNDexpenditure()
        {
            MIB.DataType tmpData = new MIB.DataType();
            tmpData.type = "expenditure";
            if (DateTime.Now.Month >= 10)
                tmpData.date.month = DateTime.Now.Month.ToString();
            else
                tmpData.date.month = "0" + DateTime.Now.Month.ToString();
            tmpData.time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            tmpData.money = "5";
            tmpData.unit = "bilion thousand VND";
            tmpData.describe = "mua may bay";
            TestWallet.Add(tmpData);
            Assert.AreEqual(tmpData, TestWallet.data[TestWallet.data.Count() - 1]);
        }
    }
}
