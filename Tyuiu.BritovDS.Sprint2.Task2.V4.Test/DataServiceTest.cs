using Tyuiu.BritovDS.Sprint2.Task2.V4.Lib;

namespace Tyuiu.BritovDS.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(3, 3));
        }
    }
}