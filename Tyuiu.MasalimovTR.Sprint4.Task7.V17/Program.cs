using System.Diagnostics;
using Tyuiu.MasalimovtrTR.Sprint4.Task7.V17.Lib;

namespace Tyuiu.MasalimovTR.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Масалимов Т.Р. | РППб-24-1";
            int m = 0;
            int n = 0;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory;
            string imagePath = Path.Combine(executablePath, "Task7v17.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            string value = "753159864";
            int[] oneDimensionalArray = value.Select(c => int.Parse(c.ToString())).ToArray();

            Console.WriteLine(string.Join(", ", oneDimensionalArray));
            int[,] twoDimensionalArray = new int[3, 3];
            int k = 0;

            for (n = 0; n < 3; n++)
            {
                for (m = 0; m < 3; m++)
                {
                    twoDimensionalArray[n, m] = oneDimensionalArray[k++];
                }
            }
            int evenCount = 0;
            for (n = 0; n < 3; n++)
            {
                for (m = 0; m < 3; m++)
                {
                    if (twoDimensionalArray[n, m] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
            }            

            PrintMatrix(twoDimensionalArray);


            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("EvenCount:"+evenCount);
        }
    }
}
