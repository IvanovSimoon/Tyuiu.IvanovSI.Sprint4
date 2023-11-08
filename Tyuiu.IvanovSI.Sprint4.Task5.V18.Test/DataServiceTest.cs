using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task5.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { {4, 3, -6, 2, 2},
                                         {7, 4, -1, 4, 3},
                                         {3, 9, -2, 2, 5},
                                         {4, 6, -6, 5, 6},
                                         {1, 5, -2, 2, 5} };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { 4, 3, 0, 2, 2 }, { 7, 4, 0, 4, 3 }, { 3, 9, 0, 2, 5 }, { 4, 6, 0, 5, 6 }, { 1, 5, 0, 2, 5 } };





            CollectionAssert.AreEqual(wait, res);
        }
    }
}
