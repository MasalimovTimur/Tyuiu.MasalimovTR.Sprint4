using System.Diagnostics;
using Tyuiu.MasalimovtrTR.Sprint4.Task4.V14.Lib;


namespace Tyuiu.MasalimovtrTR.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory;
            string imagePath = Path.Combine(executablePath, "Task4v14.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы массива 5x5 (значения от 1 до 8):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (true)
                    {
                        Console.Write($"[{i}, {j}]: ");
                        if (int.TryParse(Console.ReadLine(), out int value) && value >= 1 && value <= 8)
                        {
                            matrix[i, j] = value;
                            break;
                        }
                    }
                }
            }
                DataService dataService = new DataService();
                int[,] res = dataService.Calculate(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    if ( j== 4) 
                    {
                        Console.WriteLine();
                     };
                }
                

            }
        }
    }
}
