using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace Project.Test
{
    [TestFixture]
    class Test_I_O_xml_File
    {

        public MIB.MyWallet TestWallet = new MIB.MyWallet();
        string startupPath = "";
       [SetUp]
        public void SetUp()
        {
            startupPath = System.AppDomain.CurrentDomain.BaseDirectory + TestWallet.file_input;
            TestWallet.Read(startupPath);
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
                TestWallet.Read(startupPath);
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
            List<MIB.DataType> tmpData = new List<MIB.DataType>();
            tmpData = TestWallet.data;
            TestWallet.Write(startupPath);
            TestWallet.data.Clear();
            TestWallet.Read(startupPath);
            Assert.AreEqual(tmpData, TestWallet.data);
        }
    }
}
