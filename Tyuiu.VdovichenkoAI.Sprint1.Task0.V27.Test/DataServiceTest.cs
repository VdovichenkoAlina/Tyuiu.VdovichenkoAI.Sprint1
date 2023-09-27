﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task0.V27.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);

        }
    }
}
