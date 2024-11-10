using Tyuiu.DylginA.Sprint4.Task1.V15.Lib;
namespace Tyuiu.DylginA.Sprint4.Task1.V15
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
            Console.WriteLine("* Задание #1");
            Console.WriteLine("* Вариант #15");
            Console.WriteLine("* Выполнил: Дылгин А. | ИБКСБ-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:Дан одномерный целочисленный массив на 14 элементов заполненный значениями с клавиатуры в диапазоне от 4 до 9 подсчитать произведение четных элементов массива. " +
                " С клавиатуры: 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5");
            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[14];
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("Введите значение" + i + "элемента массива");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]+ "\t");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
        }
    }
}
