using Tyuiu.KhvorykhVA.Sprint2.Task4.V8.Lib;

namespace Tyuiu.KhvorykhVA.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 0.346;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;
            double res = ds.Calculate(x, y);
            double wait = 4.4;
            Assert.AreEqual(wait, res);
            {
            }
        }
    }
}