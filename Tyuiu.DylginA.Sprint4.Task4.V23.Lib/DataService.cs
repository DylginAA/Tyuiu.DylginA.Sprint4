﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DylginA.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] matrix)
        {
            int sumArray = 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sumArray += matrix[i, j];
                    }
                }
            }
            return sumArray;
        }
    }
}