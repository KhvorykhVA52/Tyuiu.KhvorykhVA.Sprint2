using Tyuiu.KhvorykhVA.Sprint2.Task1.V16.Lib;
namespace Tyuiu.KhvorykhVA.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;

            bool[] expected = new bool[] { true, true, true, false, true, false };
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}