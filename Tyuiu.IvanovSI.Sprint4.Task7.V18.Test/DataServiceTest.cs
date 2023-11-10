using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task7.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "145258749635789";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}
