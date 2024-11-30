using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += array[i, 3]; 
            }
            return sum;
        }
    }
}
