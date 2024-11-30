using Tyuiu.MasalimovtrTR.Sprint4.Task3.V17.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] Array = {
            {6, 4, 2, 2, 1},
            {3, 6, 5, 4, 1},
            {5, 2, 3, 1, 6},
            {8, 8, 4, 5, 3},
            {7, 4, 5, 1, 6}
        };
            int res = ds.Calculate(Array);
            Assert.AreEqual(13, res);
        }
    }
}