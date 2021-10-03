using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_Task2
{
    /*Щукин Андрей
     * 2. Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)*Добавьте обработку ситуации отсутствия файла на диске.*/
    class Program
    {
        static void Main(string[] args)
        {
            //а) 
            int[] myArray = StatiClass.CreateRandomArray(-10000, 10000, 20);

            StatiClass.PrintArray(myArray);            
            
            Console.WriteLine("Количество пар элементов массива, в которых только одно число делится на 3");
            Console.WriteLine(StatiClass.Counter(myArray));

            //б) в)
            int[] array = StatiClass.ReadTextFile(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");

            Console.WriteLine("Прочитанный из файла массив");
            StatiClass.PrintArray(array);

            Console.ReadKey();
        }
    }
}
