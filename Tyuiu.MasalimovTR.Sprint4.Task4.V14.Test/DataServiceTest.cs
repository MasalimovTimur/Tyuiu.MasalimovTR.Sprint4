using Tyuiu.MasalimovtrTR.Sprint4.Task4.V14.Lib;
namespace Tyuiu.MasalimovtrTR.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[,] matrix = {
            { 1, 3, 7, 7, 6 },

            { 4, 2, 6, 3, 3 },

            { 4, 5, 1, 4, 6 },

            { 7, 5, 2, 7, 7 },

            { 2, 4, 4, 4, 7 }};  
            int[,] res = dataService.Calculate(matrix);
            int[,] wait = {
            { 0, 0, 0, 0, 6 },

            { 4, 2, 6, 0, 0 },

            { 4, 5, 0, 4, 6 },

            { 0, 5, 2, 0, 0 },

            { 2, 4, 4, 4, 0 } };
            int count = 0;
            int rows = res.GetLength(0);
            int cols = res.GetLength(1);

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (res[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            Assert.AreEqual(10, count);
        }
    }
}