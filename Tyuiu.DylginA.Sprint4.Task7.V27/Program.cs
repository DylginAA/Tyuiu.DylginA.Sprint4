using Tyuiu.DylginA.Sprint4.Task7.V27.Lib;
namespace Tyuiu.DylginA.Sprint4.Task7.V27
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
            Console.WriteLine("* Задание #7");
            Console.WriteLine("* Вариант #27");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дана строка из одноразрядных цифр '583197256891'. Преобразуйте ее в матрицу 4 на 3 " +
                "и подсчитайте количество четных чисел.");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            string value = "583197256891";
            int m = 4;
            int n = 3;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n,m,value);
            Console.WriteLine($"Количество элементов длиной 6 символов: {res}");
        }
    }
}
