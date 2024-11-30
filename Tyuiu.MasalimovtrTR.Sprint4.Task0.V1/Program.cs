using Tyuiu.MasalimovtrTR.Sprint4.Task0.V1.Lib;
using System.Diagnostics;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task0.V1
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
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");
            DataService ds = new DataService();
            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine(res);
        }
    }
}
