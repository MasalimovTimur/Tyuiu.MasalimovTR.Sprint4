using System.Diagnostics;
using Tyuiu.MasalimovtrTR.Sprint4.Task2.V20.Lib;
namespace Tyuiu.MasalimovtrTR.Sprint4.Task2.V20
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
            string imagePath = Path.Combine(executablePath, "Task2v20.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            Random random = new Random();
            int[] array = new int[16];
            for (int i = 0; i < 16; i++)
            {
                array[i] = random.Next(2, 8);
                Console.Write(array[i] + " ");
            }            
            int res = ds.Calculate(array);
            Console.WriteLine("Cymma:" + res);
        }
    }
}
