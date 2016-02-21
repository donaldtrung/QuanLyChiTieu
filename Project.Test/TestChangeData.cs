using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project.Test
{
    [TestFixture]
    class TestChangeData
    {
        MIB.MyWallet TestWallet;  
        
        [SetUp]
        public void Setup()
        {
            TestWallet = new MIB.MyWallet();
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(startupPath);
        }

        [Test]
        public void TestDeteleRowWithLastElementInData()
        {
            MIB.DataType lastElement = TestWallet.data[TestWallet.data.Count() - 1];
            TestWallet.DeleteRow(TestWallet.data[TestWallet.data.Count() - 1].time);
            if(TestWallet.data.Count() == 0)
                Assert.AreNotEqual(null, lastElement);
            else
                Assert.AreNotEqual(TestWallet.data[TestWallet.data.Count() - 1], lastElement);
        }

        [Test]
        public void TestDeleteRowWithIndexInData()
        {
            int index = 1;
            if (index >= TestWallet.data.Count() || index < 0)
                return;
            MIB.DataType testElement = TestWallet.data[index];
            TestWallet.DeleteRow(TestWallet.data[index].time);
            if (TestWallet.data.Count() == 0)
                Assert.AreNotEqual(null, testElement);
            else
                Assert.AreNotEqual(TestWallet.data[index], testElement);
        }

        [Test]
        public void TestDeleteFirstElementInData()
        {
            if (TestWallet.data.Count() == 0)
                return;
            MIB.DataType firstElement = TestWallet.data[0];
            TestWallet.DeleteRow(TestWallet.data[0].time);
            if (TestWallet.data.Count() == 0)
                Assert.AreNotEqual(null, firstElement);
            else
                Assert.AreNotEqual(TestWallet.data[0], firstElement);
        }

        [Test]
        public void TestChangeElementInforAction_money()
        {
            int index = 2;
            MIB.DataType testData = TestWallet.data[index];
            testData.money = "2";
            TestWallet.UpdateData(testData);
            Assert.AreEqual(testData, TestWallet.data[index]);
        }

        [Test]
        public void TestChangeElementInforAction_unit()
        {
            int index = 2;
            MIB.DataType testData = TestWallet.data[index];
            testData.unit = "hundred thousand VND";
            TestWallet.UpdateData(testData);
            Assert.AreEqual(testData, TestWallet.data[index]);
        }

        [Test]
        public void TestChangeElementInforAction_describe()
        {
            int index = 2;
            MIB.DataType testData = TestWallet.data[index];
            testData.describe = "tiền mắm";
            TestWallet.UpdateData(testData);
            Assert.AreEqual(testData, TestWallet.data[index]);
        }
    }
}
