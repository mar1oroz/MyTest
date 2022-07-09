using System;

namespace Arreys5
{
    class Program
    {
        //        Задание 3
        //1) Создать метод MyReverse(int[] array), который принимает в качестве аргумента массив целочисленных элементов и возвращает инвертированный массив(элементы массива в обратном порядке).


        static int[] Arrey2(int[] Arrey1)
        {
            int a = 0;
            int b = Arrey1.Length;
            int c = b - 1;

            for (int i = 0; i < c; i++)
            {
                a = Arrey1[i];
                Arrey1[i] = Arrey1[c];
                Arrey1[c] = a;
                c--;
            }
            return Arrey1;
        }


        static void Main()
        {
            int[] Arrey1 = new int[5];

            for (int i = 0; i < Arrey1.Length; i++)
            {
                Arrey1[i] = i;
            }

            Arrey1 = Arrey2(Arrey1);


            for (int i = 0; i < Arrey1.Length; i++)
            {
                Console.Write(" ");
                Console.Write(Arrey1[i]);
            }

            Console.ReadLine();
        }
    }
}
