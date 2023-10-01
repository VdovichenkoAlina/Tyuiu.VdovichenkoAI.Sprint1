using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task7.V15.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            var res = ds.Calculate(x);
            Assert.AreEqual(166.006, res);
        }
    }
}
