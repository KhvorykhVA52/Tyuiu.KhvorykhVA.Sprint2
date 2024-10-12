using Tyuiu.KhvorykhVA.Sprint2.Task3.V30.Lib;

namespace Tyuiu.KhvorykhVA.Sprint2.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double expected = Math.Pow((x + 1) / (x - 1), x);
            Assert.AreEqual(expected, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double expected = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) - 3;
            Assert.AreEqual(expected, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -33;
            double res = ds.Calculate(x);
            double expected = (1 / x) - Math.Sin(Math.Pow(x, 2)) - 2;
            Assert.AreEqual(expected, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -34;
            double res = ds.Calculate(x);
            double expected = 1 + (1 / x);
            Assert.AreEqual(expected, res, 0.001);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();
            double x = -35;
            double res = ds.Calculate(x);
            double expected = x + 10 * x - (4.0 / 3.0);
            Assert.AreEqual(expected, res, 0.001);
        }
    }
}