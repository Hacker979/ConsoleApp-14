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
            for(int a = 1; a<=5; a++)
            {
                Console.WriteLine("Привет!");
            }
        }
        /// <summary>
        /// Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadLine();
        }
    }
}
