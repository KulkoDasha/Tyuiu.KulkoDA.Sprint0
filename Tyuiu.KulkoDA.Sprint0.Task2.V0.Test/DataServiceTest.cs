using Tyuiu.KulkoDA.Sprint0.Task2.V0.Lib;
using System;
namespace Tyuiu.KulkoDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дарья";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Дарья", res);
        }
    }
}