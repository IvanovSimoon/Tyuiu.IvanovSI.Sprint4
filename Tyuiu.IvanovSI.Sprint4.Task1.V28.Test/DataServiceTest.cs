using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task1.V28.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 1875;

            Assert.AreEqual(wait, res);
        }
    }
}
