using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = CreateRandomArray(-10000, 10000, 20);

            //PrintArray(myArray);

            Console.WriteLine(Counter(new int[4] { 6, 2, 9, -3 }));

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
            foreach (var e in array)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
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
