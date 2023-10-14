using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint2.Task4.V2.Lib;

namespace Tiuiu.SikachevaEA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 1.3;
            Assert.AreEqual(wait, res);
        }
    }
}
