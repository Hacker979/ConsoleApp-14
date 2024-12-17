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
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a <= n);
        }
        /// <summary>
        /// Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
    }
}
