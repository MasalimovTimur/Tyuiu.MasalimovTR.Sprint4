using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MasalimovtrTR.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            string[] trees = Array.FindAll(array, x => x.Length > 5);
            return trees;
        }
    }
}
