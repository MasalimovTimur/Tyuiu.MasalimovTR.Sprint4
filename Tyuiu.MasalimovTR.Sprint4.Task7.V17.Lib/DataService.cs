using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task7.V17.Lib
{
    public class DataService : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int[] oneDimensionalArray = value.Select(c => int.Parse(c.ToString())).ToArray();

            Console.WriteLine(string.Join(", ", oneDimensionalArray));
            int[,] twoDimensionalArray = new int[3, 3];
            int k = 0;

            for ( n = 0; n < 3; n++)
            {
                for ( m = 0; m < 3; m++)
                {
                    twoDimensionalArray[n, m] = oneDimensionalArray[k++];
                }
            }            
            int evenCount = 0;
            for ( n = 0; n < 3; n++)
            {
                for ( m = 0; m < 3; m++)
                {
                    if (twoDimensionalArray[n, m] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }
            return evenCount;
        }
    }
}
