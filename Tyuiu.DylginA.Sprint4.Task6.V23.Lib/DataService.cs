using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DylginA.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            int result = array.Count(array => array.Length == 6);
            return result;

        }
    }
}
