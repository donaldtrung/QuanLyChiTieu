using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace Project.Test
{
    [TestFixture]
    class TestDeafault
    {
        [Test]
        public void CheckMonthDefault()
        {
            String scurMonth = DateTime.Now.Month.ToString();
            scurMonth = "0" + scurMonth;
            //String sMonth = curMonth.ToString();
            MIB.Menux tmpForm = new MIB.Menux();
            Assert.AreEqual(scurMonth, tmpForm.GetCBBMonth().Items[tmpForm.GetCBBMonth().SelectedIndex]);
        }

        [Test]
        public void CheckYearDefault()
        {
            
            String scurYear = DateTime.Now.Year.ToString();
            //scurMonth = "0" + scurMonth;
            //String sMonth = curMonth.ToString();
            MIB.Menux tmpForm = new MIB.Menux();            
           Assert.AreEqual(scurYear, tmpForm.GetCBBYear().Items[tmpForm.GetCBBYear().SelectedIndex]);
        }
    }
}
