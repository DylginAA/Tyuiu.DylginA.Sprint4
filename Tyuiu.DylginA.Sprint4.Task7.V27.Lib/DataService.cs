using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DylginA.Sprint4.Task7.V27.Lib
{
    public class DataService : ISprint4Task7V27
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[4, 3];
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int array = int.Parse(value[i * 3 + j].ToString());
                    matrix[i, j] = array;
                    if (array % 2 == 0)
                    {
                       count++;
                    }
                }
            }

            return count;
        }
    }
}
