using System;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
///     б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
/// </summary>
namespace Task7
{
    class Program
    {
        static int SummNumbers(int a, int b)
        {
            int sum = a;
            if (a<b)
            {
                sum += SummNumbers(a + 1, b);
            }
            else
            {
                sum= b;
            }
            return sum;
        }

        static void Main()
        {
            int a, b;
            a = ReadInt("Введите число а ");
            b = ReadInt("Введите число b ");
            Print($"Сумма чисел от {a} до {b} равна {SummNumbers(a, b)}");
            Pause();
        }
    }
}
