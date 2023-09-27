using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task1.V1.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            double x = 3.0;
            double y = 1.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(13, res);
        }
    }
}
