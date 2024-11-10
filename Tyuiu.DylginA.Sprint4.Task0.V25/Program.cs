using Tyuiu.DylginA.Sprint4.Task0.V25.Lib;
namespace Tyuiu.DylginA.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4");
            Console.WriteLine("* Тема: Одномернные массивы");
            Console.WriteLine("* Задание #0");
            Console.WriteLine("* Вариант #25");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан одномерный целочисленный массив на 10 элементов заполненный статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[] { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumEvenArrEl(array));
        }
    }
}
