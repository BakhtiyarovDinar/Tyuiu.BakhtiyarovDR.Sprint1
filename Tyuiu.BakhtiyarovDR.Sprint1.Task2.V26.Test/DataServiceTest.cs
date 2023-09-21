using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task2.V26.Lib;

//ISprint1Task2V26.CalculateMinutesSinceStart(int, int)

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 21;
            int valueTwo = 50;
            var res = ds.CalculateMinutesSinceStart(value, valueTwo);
            Assert.AreEqual(1310, res);
        }
    }
}
