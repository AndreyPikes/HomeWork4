using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Task2
{
    public static class StatiClass
    {
        public static int[] ReadTextFile(string name)
        {
            if (File.Exists(name))
            {
                int stringsCounter = 0;

                using (StreamReader reader = new StreamReader(name))
                {
                    while (!reader.EndOfStream)
                    {
                        reader.ReadLine();
                        stringsCounter++;
                    }
                }

                int[] result = new int[stringsCounter];

                using (StreamReader reader2 = new StreamReader(name))
                {
                    int counter = 0;

                    while (!reader2.EndOfStream)
                    {
                        result[counter] = int.Parse(reader2.ReadLine());
                        counter++;
                    }
                }
                return result;
            }
            else
            {
                Console.WriteLine($"Файл по адресу: {name} отстутвует. Возвращаю пустой массив.");
                return new int[0];
            }
        }

        /// <summary>
        /// Создание массива с заданным количеством элементов раномного характера в заданном диапазоне
        /// </summary>
        /// <param name="min">диапазон мин</param>
        /// <param name="max">диапазон макс</param>
        /// <param name="count">количество элементов</param>
        /// <returns></returns>
        public static int[] CreateRandomArray(int min, int max, int count)
        {
            int[] result = new int[count];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                result[i] = random.Next(min, max + 1);
            }
            return result;
        }
        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            Console.WriteLine($"Вывожу массив: ");
            foreach (var e in array)
            {
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// Подсчет чисел соглсно заданию
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Counter(int[] array)
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
