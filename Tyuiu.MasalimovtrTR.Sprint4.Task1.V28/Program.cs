using Tyuiu.MasalimovtrTR.Sprint4.Task1.V28.Lib;
using System.Diagnostics;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory;
            string imagePath = Path.Combine(executablePath, "Task1v28.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            int[] numsArray = new int[13];
            for (int i = 0; i <= 13 ; i++)
            {
                numsArray[i] = Convert.ToInt32(Console.Read());
            }
            int res = ds.Calculate(numsArray);
            Console.WriteLine(res);
        }
    }
}
