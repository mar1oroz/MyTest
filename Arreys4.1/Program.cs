using System;

namespace Arreys4._1
{
    class Program
    {
        //Создайте метод, который принимает два аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value.
        //В теле метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
        //при этом длина нового массива, должна увеличиться на 1 элемент,
        //а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.


        static int[] ChangeArrey(int[]arrey,int value)
        {
            int[] Arrey3 = new int[arrey.Length + 1];

            for (int i = 0; i < arrey.Length+1; i++)
            {
                if (i<=0)
                {
                    Arrey3[i] = value;
                }
                if (i > 0 && i < Arrey3.Length)
                {
                    Arrey3[i] = arrey[i - 1];
                }
            }
            return Arrey3;
        }

        static void Calculation(int[] arrey)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write(arrey[i] + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] arrey = new int[4];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = i;
            }
            Console.Write("Кількість елементів до зміни: ");
            Calculation(arrey);

            int value = 10;
            int[] Arrey2 = ChangeArrey(arrey, value);

            Console.Write("Кількість елементів з додаванням аргумента: ");

            Calculation(Arrey2);

            Console.ReadLine();

        }
    }
}
