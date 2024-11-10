using Tyuiu.DylginA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.DylginA.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4");
            Console.WriteLine("* Тема: двумернные массивы");
            Console.WriteLine("* Задание #3");
            Console.WriteLine("* Вариант #10");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 4 до 8. Найдите максимальный элемент в третьей строке массива.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[,] array = {
            { 5, 7, 6, 6, 5 },
            { 5, 5, 5, 4, 6 },
            { 8, 5, 7, 4, 7 },
            { 7, 6, 7, 4, 7 },
            { 5, 8, 7, 8, 8 }
            };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}
