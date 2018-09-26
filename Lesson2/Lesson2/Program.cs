using System;
using LessonsClassLibrary;

/// <summary>
/// 1. Написать метод, возвращающий минимальное из трех чисел.
///    Выполнил Шадрин Андрей
/// </summary>
namespace Task1
{

    class Program
    {
        /// <summary>
        /// метод возвращает минимальное из трех чисел
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <param name="c">int</param>
        /// <returns>int</returns>
        public static int Min3(int a, int b, int c)
        {
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }

            return min;
        }

        static void Main()
        {
            Useful.Print(Min3(3, 2, 1));
            Useful.Print(Min3(5, 6, 4));
            Useful.Print(Min3(7, 9, 8));
            Useful.Print(Min3(10, 11, 12));
            Useful.Pause(3000);
        }
    }
}
