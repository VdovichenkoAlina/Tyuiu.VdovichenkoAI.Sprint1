using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task6.V1.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "1";
            int z = 49;
            DataService ds = new DataService();
            string res = ds.SymbolCode(value);
            Assert.AreEqual(z, res);

        }
    }
}
