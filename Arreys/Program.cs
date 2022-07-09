using System;

namespace Arreys
{
    class Program
    {


//        Задание 2
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:
//Создать массив размера N элементов, заполнить его произвольными целыми значениями(размер массива задает пользователь).
//Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения.



        static void Main(string[] args)
        {
            int[] Arreys = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(Arreys[Arreys.Length - 1]);
            Console.WriteLine(Arreys[Arreys.Length - 2]);
            Console.WriteLine(Arreys[^3]);
            Console.WriteLine(Arreys[^4]);
            Console.WriteLine(Arreys[^5]);
            Console.WriteLine(Arreys[^6]);
            Console.WriteLine(Arreys[^7]);
            Console.WriteLine(Arreys[^8]);
            Console.WriteLine(Arreys[^9]);
            Console.WriteLine(Arreys[^10]);

        }
    }
}
