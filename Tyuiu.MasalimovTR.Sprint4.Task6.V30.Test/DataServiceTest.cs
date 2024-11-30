using Tyuiu.MasalimovtrTR.Sprint4.Task6.V30.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var array = new string [] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(array);            
            Assert.AreEqual(1, 1);
        }
    }
}