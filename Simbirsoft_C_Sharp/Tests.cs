using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Simbirsoft_C_Sharp
{
    [TestClass]
    public class Simbirsoft_C_Sharp_Tests
    {
        [TestMethod]
        public void TestObjectCreation()
        {
            FormMain FM = new FormMain();
        }

        [TestMethod]
        public void TestNameOfTheFormCorrect()
        {
            FormMain FM = new FormMain();
            Assert.AreEqual(FM.Text, "Simbirsoft_Test");
        }

        [TestMethod]
        public void TestButtonCreateHTMLDisabledOnStartup()
        {
            FormMain FM = new FormMain();
            Assert.AreEqual(FM.btnCreateHTML.Enabled, false);
        }

        [TestMethod]
        public void TestMaximumLinesTextBoxClear()
        {
            FormMain FM = new FormMain();
            Assert.AreEqual(FM.tbMaximumLines.Text, "");
        }
    }	
}
