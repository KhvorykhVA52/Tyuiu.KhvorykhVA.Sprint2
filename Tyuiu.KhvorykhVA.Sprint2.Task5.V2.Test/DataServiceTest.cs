
using Tyuiu.KhvorykhVA.Sprint2.Task5.V2.Lib;

namespace Tyuiu.KhvorykhVA.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Зима", ds.FindMonthSeason(12));
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Зима", ds.FindMonthSeason(2));

            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Весна", ds.FindMonthSeason(4));
            Assert.AreEqual("Весна", ds.FindMonthSeason(5));

            Assert.AreEqual("Лето", ds.FindMonthSeason(6));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Лето", ds.FindMonthSeason(8));

            Assert.AreEqual("осень", ds.FindMonthSeason(9));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
            Assert.AreEqual("осень", ds.FindMonthSeason(11));

            Assert.AreEqual("Invalid month", ds.FindMonthSeason(13));
        }
    }
}
