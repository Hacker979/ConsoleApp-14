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
            for (int x = 1; x <= 25; x++)
            {
                for (int a = 1; a <= 18; a++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
                
            }
            
        }
        /// <summary>
        /// Задание 4. С использованием цветового оформления консоли:
        /// а) вывести на экран горизонтальную строку из 18 символов;
        /// б) вывести на экран вертикальную строку из 25 символов.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (Console.CapsLock == true)
            { Console.WriteLine("The Caps Lock key is ON."); }
            else
            { Console.WriteLine("The Caps Lock key is OFF."); }
            if (Console.NumberLock == true)
            { Console.WriteLine("The Num Lock key is ON."); }
            else
            { Console.WriteLine("The Num Lock key is OFF."); }

            Console.Title = "Работа с консолью";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Gray;
            Func();
            Console.ReadLine();
        }
    }
}
