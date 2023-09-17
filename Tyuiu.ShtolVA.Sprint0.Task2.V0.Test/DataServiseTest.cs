using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShtolVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ChechGetMessageValid()
        {
            var name = "Виктория";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Виктория", res);
        }
    }
}
