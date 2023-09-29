using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task3.V15.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 40;
            double v2 = 60;
            double S = 800;
            double T = 5;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(300, res);
        }
    }
}
