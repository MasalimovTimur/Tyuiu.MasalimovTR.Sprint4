using Tyuiu.MasalimovtrTR.Sprint4.Task7.V17.Lib;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digits = "753159864";
            int[] intArray = digits.Select(c => int.Parse(c.ToString())).ToArray();

            Console.WriteLine(string.Join(", ", intArray));
        }

    }
    
}
