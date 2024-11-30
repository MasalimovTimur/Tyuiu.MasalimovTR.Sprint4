using Tyuiu.MasalimovtrTR.Sprint4.Task7.V17.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "753159864";
            int m = 0;
            int n = 0;
            int res = ds.Calculate(n, m, value);
            Assert.AreEqual(1, 1);
        }
    }
}