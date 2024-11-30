namespace _1123
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string count = "753159864";
            int[,] matrix = new int[3, 3];
            int k = 0;
            foreach (char num in count)
            {
                int digit = int.Parse(num.ToString());
                int row = k / 3;
                int col = k % 3;
                matrix[row, col] = digit;
                k++;
            }

            int evenCount = 0;
            foreach (int num in matrix)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine("Матрица: " + matrix);
            Console.WriteLine($"\nКоличество четных чисел: {evenCount}");
        }
    }
}


