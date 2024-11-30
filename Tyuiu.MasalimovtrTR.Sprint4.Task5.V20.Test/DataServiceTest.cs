using Tyuiu.MasalimovtrTR.Sprint4.Task5.V20.Lib;
namespace Tyuiu.MasalimovtrTR.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] Array = {
            {1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1},
            {1, 1, 1, 1, 1}
        };
            int res = ds.Calculate(Array);
            Assert.AreEqual(25, res);
        }
    }
}