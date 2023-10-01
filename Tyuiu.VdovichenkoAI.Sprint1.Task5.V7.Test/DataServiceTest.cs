﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VdovichenkoAI.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 180;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(6, res);

        }
    }
}
