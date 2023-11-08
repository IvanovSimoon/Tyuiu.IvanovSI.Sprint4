using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Task6.V17.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var lng = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(lng);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
