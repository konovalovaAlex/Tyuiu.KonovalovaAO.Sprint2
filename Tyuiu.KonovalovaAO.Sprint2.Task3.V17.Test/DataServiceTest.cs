using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint2.Task3.V17.Lib;
namespace Tyuiu.KonovalovaAO.Sprint2.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            var wait = 6565;
            Assert.AreEqual(wait, res);
        }
        
    }
}
