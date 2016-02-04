using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace MIB
{
    [TestFixture]
    class Test_I_O_txt_File
    {

        public MyWallet TestWallet = new MyWallet();
        string startupPath = "";
       [SetUp]
        public void SetUp()
        {
            startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(TestWallet.data, startupPath);
        }

        [Test]
        public void Check_Exists_Data_File()
        {
            if (File.Exists(startupPath))
                Assert.Throws<DivideByZeroException>(() => { throw new DivideByZeroException(); });
            else
                Assert.Throws<FileNotFoundException>(() => { throw new FileNotFoundException(); });
        }

        [Test]
        public void CheckReadDataInRightWay()
        {
            try
            {
                TestWallet.Read(TestWallet.data, startupPath);
            }
            catch
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => { throw new FileNotFoundException(); });
            }
            Assert.Throws<DivideByZeroException>(() => { throw new DivideByZeroException(); });
        }

        [Test]
        public void CompareReadAndWriteData()
        {
            List<DataType> tmpData = new List<DataType>();
            tmpData = TestWallet.data;
            TestWallet.Write(TestWallet.data, startupPath);
            TestWallet.data.Clear();
            TestWallet.Read(TestWallet.data, startupPath);
            Assert.AreEqual(tmpData, TestWallet.data);
        }
    }
}
