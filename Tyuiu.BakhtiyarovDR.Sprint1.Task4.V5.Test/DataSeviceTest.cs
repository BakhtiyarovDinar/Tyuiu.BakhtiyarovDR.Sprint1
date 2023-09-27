using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task4.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task4.V5.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 16;
            double wait = 0.111111111111111;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
            
        }
    }
}
