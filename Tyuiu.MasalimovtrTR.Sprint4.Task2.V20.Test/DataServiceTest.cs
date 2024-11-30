using Tyuiu.MasalimovtrTR.Sprint4.Task2.V20.Lib;
namespace Tyuiu.MasalimovtrTR.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 4, 10 };
            int res = ds.Calculate(array);
            Assert.AreEqual(10, res);
        }
    }
}