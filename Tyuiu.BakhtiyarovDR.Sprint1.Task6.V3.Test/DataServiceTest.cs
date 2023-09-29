using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task6.V3.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "бим бим бам бам";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "мммм";
            Assert.AreEqual(wait, res);
        }
    }
}
