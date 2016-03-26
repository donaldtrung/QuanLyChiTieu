using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project.Test
{
    //this unit test test sum of revenue, expenditure and calbalance
    //in month and year have been given

    [TestFixture]
    class TestSum_Revenue_Expenditure
    {
        public MIB.MyWallet TestWallet;
        string startupPath = "";
        double sumrev;
        double sumex;
        [SetUp]
        public void SetUp()
        {
            TestWallet = new MIB.MyWallet();
            startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(startupPath);
            TestWallet.date.month = "02";
            TestWallet.date.year = "2016";
            sumrev = 0.0;
            sumex = 0.0;
        }

        //[Test]
        //public void TestSumRevenue()
        //{

        //    for (int i = 0; i < TestWallet.data.Count; i++)
        //    {
        //        if (TestWallet.data[i].type == "revenue" && TestWallet.data[i].date.month == date.month && TestWallet.data[i].date.year == date.year)
        //        {
        //            double tmp = double.Parse(TestWallet.data[i].money);
        //            switch (TestWallet.data[i].unit)
        //            {
        //                case "VND":
        //                    break;
        //                case "thousand VND":
        //                    tmp *= 1000;
        //                    break;
        //                case "hundred thousand VND":
        //                    tmp *= 100000;
        //                    break;
        //                case "million VND":
        //                    tmp *= 1000000;
        //                    break;
        //                case "billion VND":
        //                    tmp *= 1000000000;
        //                    break;
        //            }
        //            sumrev += tmp;
        //        }
        //    }

        //    double realSum = 0.0;
        //    TestWallet.GetStringData("revenue", ref realSum);
        //    Assert.AreEqual(sumrev, realSum);
        //}

        //[Test]
        //public void TestSumExpenditure()
        //{

        //    for (int i = 0; i < TestWallet.data.Count; i++)
        //    {
        //        if (TestWallet.data[i].type == "expenditure")
        //        {
        //            double tmp = double.Parse(TestWallet.data[i].money);
        //            switch (TestWallet.data[i].unit)
        //            {
        //                case "VND":
        //                    break;
        //                case "thousand VND":
        //                    tmp *= 1000;
        //                    break;
        //                case "hundred thousand VND":
        //                    tmp *= 100000;
        //                    break;
        //                case "million VND":
        //                    tmp *= 1000000;
        //                    break;
        //                case "billion VND":
        //                    tmp *= 1000000000;
        //                    break;
        //            }
        //            sumex += tmp;
        //        }
        //    }

        //    double realSum = 0.0;
        //    TestWallet.GetStringData("expenditure", ref realSum);
        //    Assert.AreEqual(sumex, realSum);
        //}


        [Test]
        public void TestCalBalance()
        {
            double sumrev = 0.0;
            double sumex = 0.0;
            TestWallet.GetStringData("revenue", ref sumrev);
            TestWallet.GetStringData("expenditure", ref sumex);
            double balance = sumrev - sumex;
            double realBalan = 0.0;
            TestWallet.Statistic();
            realBalan = TestWallet.balance;
            Assert.AreEqual(balance, realBalan);
        }
    }
}
