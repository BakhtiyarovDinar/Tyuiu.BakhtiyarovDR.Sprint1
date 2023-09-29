using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint1.Task7.V27.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 0);
            Assert.AreEqual(-14.903, res);
        }
    }
}
