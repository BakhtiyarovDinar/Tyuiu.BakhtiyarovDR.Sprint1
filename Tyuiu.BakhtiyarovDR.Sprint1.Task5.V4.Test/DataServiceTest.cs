using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 68500;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(10, res);
        }
    }
}
