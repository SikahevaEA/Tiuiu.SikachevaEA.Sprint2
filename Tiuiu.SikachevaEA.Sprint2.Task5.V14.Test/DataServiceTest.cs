using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tiuiu.SikachevaEA.Sprint2.Task5.V14.Lib;

namespace Tiuiu.SikachevaEA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(246, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(170, 2));
            Assert.AreEqual("Среда", ds.FindDayName(38, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(95, 4));
            Assert.AreEqual("Пятница", ds.FindDayName(180, 5));
            Assert.AreEqual("Суббота", ds.FindDayName(216, 6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(287, 7));

        }
    }
}
