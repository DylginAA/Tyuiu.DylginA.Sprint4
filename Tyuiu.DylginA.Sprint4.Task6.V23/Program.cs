
using System;
using Tyuiu.DylginA.Sprint4.Task6.V23.Lib;
namespace Tyuiu.DylginA.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Дылгин А. | ИБКСБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4");
            Console.WriteLine("* Тема: Array");
            Console.WriteLine("* Задание #6");
            Console.WriteLine("* Вариант #23");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан строковый массив данных [Microsoft, Google, Apple, Amazon, Facebook, Tesla, Netflix] используя класс Array подсчитайте количество элементов, " +
                "длина которых равна 6.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string[] array = ["Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix"];
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine($"Количество элементов длиной 6 символов: {res}");
        }
    }
}
