using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int sum = 1;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum *= num;
                }
            }
            return sum;
        }
    }
}
