using Tyuiu.KhvorykhVA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KhvorykhVA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2024, m = 8, n = 8;
            var res = ds.FindDateOfPreviousDay(g, m, n);

            Assert.AreEqual("07.08.2024", res);
        }
    }
}