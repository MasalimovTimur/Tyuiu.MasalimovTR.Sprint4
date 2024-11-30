using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task2.V20.Lib
{
    public class DataService : ISprint4Task2V20
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number >= 2 && number <= 7 && number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
