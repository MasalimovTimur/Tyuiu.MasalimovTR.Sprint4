using System.Diagnostics;
using Tyuiu.MasalimovtrTR.Sprint4.Task6.V30.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task6.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* КАРТИНКА                                                                *");
            string executablePath = AppContext.BaseDirectory;
            string imagePath = Path.Combine(executablePath, "Task6v30.png"); ;
            Process.Start(new ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            }
            );
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");            
            DataService ds = new DataService();
            var array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] trees = ds.Calculate(array);
            foreach (string let in trees)
            {
                Console.Write(let);
            };
        }
    }
}
