using System;

namespace Arreys4._1
{
    class Program
    {

        //Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент.
		//Элементы массива, должны сохранить свое значение и порядок индексов.


        
        public static int Increase(int[] arrey)
        {
            
            int[] Arrey1 = new int[arrey.Length + 1];

            for (int i = 0; i < arrey.Length; i++)
            {
                if (i <= arrey.Length + 1)
                {
                    Arrey1[i] = arrey[i];
                }
                else
                {
                    Arrey1[i] = 0;
                }
            }
            return = Arrey1;


        }

        static void Main()
        {
            
            int[] array = new int[3];

            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine(array);

            
            int[] result = Increase(array);

            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
