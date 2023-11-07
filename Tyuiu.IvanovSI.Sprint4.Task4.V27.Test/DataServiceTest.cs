﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task4.V27.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { {4, 3, 9, 2, 2},
                                         {8, 4, 1, 4, 3},
                                         {3, 9, 2, 2, 5},
                                         {4, 6, 8, 5, 6},
                                         {1, 5, 2, 2, 5} };
            int res = ds.Calculate(mas);
            int wait = 49;

            Assert.AreEqual(wait, res);
        }
    }
}
