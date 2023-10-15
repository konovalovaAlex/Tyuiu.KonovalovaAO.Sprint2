using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonovalovaAO.Sprint2.Task0.V3.Lib;

namespace Tyuiu.KonovalovaAO.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareoOperations()
        {
            DataService ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] rez = ds.GetCompareOperations(x, y);
            bool[] wait = { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, rez);
        }
    }
}
