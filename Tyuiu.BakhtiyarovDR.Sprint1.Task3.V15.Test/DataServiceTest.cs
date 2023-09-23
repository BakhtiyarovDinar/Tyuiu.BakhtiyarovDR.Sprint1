using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BakhtiyarovDR.Sprint1.Task3.V15.Lib;

// s=s0-t*(v1+v2)
// s=5-2*(50+80)=390

namespace Tyuiu.BakhtiyarovDR.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 2;
            double s = 2;
            double t = 2;
            double wait = 10;
            var res = ds.DistanceOverTime(v1, v2, s, t);
            Assert.AreEqual(wait, res);
        }
    }
}
