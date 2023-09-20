using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;

            int j = i++;

            int k = ++j;

            Console.Write("i=" + i + "\\");

            Console.Write("j=" + j);

            Console.Write("k=" + k);


        }
    }
}
