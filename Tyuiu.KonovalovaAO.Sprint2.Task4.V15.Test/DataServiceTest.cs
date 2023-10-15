using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint2.Task4.V15.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            double wait = 10.383;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 66;
            double wait = 729.67;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
