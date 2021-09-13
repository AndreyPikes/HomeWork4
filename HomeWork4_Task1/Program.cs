using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Task1
{
    /*Щукин Андрей
     * 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] myArray = CreateRandomArray(-10000, 10000, 20);
            PrintArray(myArray);
            Console.WriteLine("*************");

            //2
            int[] myArray2 = new int[4] { 6, 2, 9, -3 };
            PrintArray(myArray2);
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3");
            Console.WriteLine(Counter(myArray2));

            Console.ReadKey();
        }

        static int[] CreateRandomArray(int min, int max, int count)
        {
            int[] result = new int[count];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                result[i] = random.Next(min, max + 1);
            }
            return result;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"Вывожу массив: ");
            foreach (var e in array)
            {
                Console.WriteLine(e);
            }
        }

        static int Counter(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if ((array[i] % 3 == 0) && (array[i - 1] % 3 != 0)) counter++;
                if ((array[i] % 3 != 0) && (array[i - 1] % 3 == 0)) counter++;
            }

            return counter;
        }
    }
}
