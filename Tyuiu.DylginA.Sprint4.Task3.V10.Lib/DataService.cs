using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DylginA.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int m = array[2, 0];

            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[2, i] > m)
                {
                    m = array[2, i];
                }
            }
            return m;
        }
    }
}
