
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

            Assert.AreEqual("Winter", ds.FindMonthSeason(12));
            Assert.AreEqual("Winter", ds.FindMonthSeason(1));
            Assert.AreEqual("Winter", ds.FindMonthSeason(2));

            Assert.AreEqual("Spring", ds.FindMonthSeason(3));
            Assert.AreEqual("Spring", ds.FindMonthSeason(4));
            Assert.AreEqual("Spring", ds.FindMonthSeason(5));

            Assert.AreEqual("Summer", ds.FindMonthSeason(6));
            Assert.AreEqual("Summer", ds.FindMonthSeason(7));
            Assert.AreEqual("Summer", ds.FindMonthSeason(8));

            Assert.AreEqual("Autumn", ds.FindMonthSeason(9));
            Assert.AreEqual("Autumn", ds.FindMonthSeason(10));
            Assert.AreEqual("Autumn", ds.FindMonthSeason(11));

            Assert.AreEqual("Invalid month", ds.FindMonthSeason(13));
        }
    }
}
