using System;

namespace Arreys2
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
            Console.WriteLine("Введіть число елементів масиву: ");
            int[] arrey = new int[Convert.ToInt32(Console.ReadLine())];

            int max = 0, min = 0, sum = 0;




            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = i;
            }

            max = arrey[0];
            min = arrey[0];




            for (int i = 0; i < arrey.Length; i++)
            {
                if ((arrey[i] % 2) != 0)   
                {
                    Console.WriteLine("Число не парне {0}", arrey[i]); 
                }

                if (min > arrey[i]) 
                {
                    min = arrey[i];
                }

                if (max < arrey[i])
                {
                    max = arrey[i];
                }

                sum += arrey[i];


            }


            Console.WriteLine("Найбільше значення масива: {0}", max );
            Console.WriteLine("Найменше значенн масива: {0}", min );
            Console.WriteLine("Загальна сума всіх елементів: {0}", sum );
            Console.WriteLine("Середнє арифметичне {0}", sum / arrey.Length);



            Console.ReadKey();


        }
    }
}
