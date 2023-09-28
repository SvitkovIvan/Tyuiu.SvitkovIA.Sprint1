using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint1.Task7.V24.Lib;

namespace Tyuiu.SvitkovIA.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 8;
            double wait = 1.617;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
