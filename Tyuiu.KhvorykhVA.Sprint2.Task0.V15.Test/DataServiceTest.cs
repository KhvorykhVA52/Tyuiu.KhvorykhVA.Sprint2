using Tyuiu.KhvorykhVA.Sprint2.Task0.V15.Lib;

namespace Tyuiu.KhvorykhVA.Sprint2.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 275;
            bool[] expected = new bool[6] { false, false, true, true, false, false };

            bool[] result = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}