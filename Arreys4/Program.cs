using System;

namespace Arreys4
{
    class Program
    {


       
        //Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент. Элементы массива, должны сохранить свое значение и порядок индексов.


        //4
        static void Increase( int[] arrey)
        {
            //5
            int[] Arrey1 = new int[arrey.Length + 1];

            //6
            for (int i = 0; i < arrey.Length; i++)
            {
                //7
                if (i <= arrey.Length + 1)
                {
                    Arrey1[i] = arrey[i];
                }
                //8
                else
                {
                    Arrey1[i] = 0;
                }
            }
            //9
            arrey = Arrey1;

        }
         
        static void Main()
        {
            //1
            int[] array = new int[3];

            //2
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            //3
            Increase( array);
           
            Console.ReadKey();



        }
    }
}
