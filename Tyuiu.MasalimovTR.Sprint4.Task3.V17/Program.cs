using System.Diagnostics;
using Tyuiu.MasalimovtrTR.Sprint4.Task3.V17.Lib;
namespace Tyuiu.MasalimovtrTR.Sprint4.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory;
            string imagePath = Path.Combine(executablePath, "Task3v17.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");            
            DataService ds = new DataService();
            int[,] Array = {
            {6, 4, 2, 2, 1},
            {3, 6, 5, 4, 1},
            {5, 2, 3, 1, 6},
            {8, 8, 4, 5, 3},
            {7, 4, 5, 1, 6}
        };
            int res = ds.Calculate(Array);
            Console.WriteLine(res);
        }
    }
}
