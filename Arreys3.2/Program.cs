using System;

namespace Arreys6
{
    class Program
    {
        //        Задание 3
        //2) Создайте метод int[] SubArray(int[] array, int index, int count). Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
        //Если аргумент count содержит значение больше чем количество элементов, которые входят в выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента), то при формировании нового массива размерностью в count, заполните единицами те элементы, которые не были скопированы из исходного массива.

        //Зрозумів, але це було складно (p.s.Мар'ян).

        static void Main()
        {

            //1
            int[] arrey = new int[10];

            //2
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = i;
            }

            //3
            Console.WriteLine("Введіть індеск масиву");
            int index = Convert.ToInt32(Console.ReadLine());

            //4
            Console.WriteLine("Введіть кількість елементів");
            int count = Convert.ToInt32(Console.ReadLine());

            //5
            arrey = SubArray(arrey, index, count);

            //13
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.WriteLine(arrey[i]);
            }

            //14
            Console.ReadLine();



        }

        //6
        static int[] SubArray(int[] arrey, int index, int count)
        {
            //7
            int[] SubArray = new int[count];
            int m = 0;

            //8
            for (int i = 0; i < arrey.Length; i++)
            {
                //9
                if (arrey.Length > index)
                {
                    SubArray[m] = arrey[index];
                }
                //10
                else
                {
                    SubArray[m] = 1;
                }
                //11
                index++;
                m++;
            }

            //12
            return SubArray;
        }
    }
}
