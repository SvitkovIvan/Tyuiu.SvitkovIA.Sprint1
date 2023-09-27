using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.SvitkovIA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService dataService = new DataService();
            string value = "afffcav";
            bool res = dataService.CheckeFirstLetterRepetition(value);
            Assert.IsTrue(res);
        }
    }
}
