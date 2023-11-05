using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task2.V28.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 };
            int res = ds.Calculate(numsArray);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
