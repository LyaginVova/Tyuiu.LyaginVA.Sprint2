using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint2.Task4.V19.Lib;

namespace Tyuiu.LyaginVA.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 36.754;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 16;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 2.357;
            Assert.AreEqual(wait, res);

        }
    }
}
