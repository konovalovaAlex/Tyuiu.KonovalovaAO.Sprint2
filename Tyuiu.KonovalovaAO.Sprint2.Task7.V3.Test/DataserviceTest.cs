using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint2.Task7.V3.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
