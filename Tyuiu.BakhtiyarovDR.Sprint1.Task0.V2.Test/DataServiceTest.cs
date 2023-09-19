using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task0.V2.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}
