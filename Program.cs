using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14
{
    class Program
    {
        static void Func()
        {
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a++;
            }
        }
        /// <summary>
        /// Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
    }
}
