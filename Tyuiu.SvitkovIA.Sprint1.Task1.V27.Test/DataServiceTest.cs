﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint1.Task1.V27.Lib;

namespace Tyuiu.SvitkovIA.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.0, res);
        }
    }
}
