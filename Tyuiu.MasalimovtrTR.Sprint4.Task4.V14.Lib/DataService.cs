using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task4.V14.Lib
{
    public class DataService : ISprint4Task4V14
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
    public class DataService2 
    {
            public static bool Ress(int[,] wait, int[,] res)
            {
                if (wait == null || res == null) return wait == res;

                if (wait.GetLength(0) != res.GetLength(0) || wait.GetLength(1) != res.GetLength(1)) return false;

                for (int i = 0; i < wait.GetLength(0); i++)
                {
                    for (int j = 0; j < wait.GetLength(1); j++)
                    {
                        if (wait[i, j] != res[i, j]) return false;
                    }
                }
                return true;
            }
    }
}
