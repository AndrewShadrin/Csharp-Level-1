using System;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
///     Хорошим называется число, которое делится на сумму своих цифр. 
///     Реализовать подсчет времени выполнения программы, используя структуру DateTime.
///     Выполнил Шадрин Андрей
///     Хороших чисел - 61574509
///     Время работы составило 00:02:14.1830808
/// </summary>
namespace Task6
{
    class Program
    {
        static int SumDigit(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool GoodNumber(int number)
        {
            bool result = false;
            result = number % SumDigit(number) == 0;
            return result;
        }

        static void Main()
        {
            int gn = 0;
            bool res = false;
            DateTime dateTime = DateTime.Now;
            for (int i = 1; i < 1000000000; i++)
            {
                res = GoodNumber(i);
                gn+= res? 1:0;
                //Print(res ? $"{i} хорошее число" : $"{i} не хорошее число");
            }
            Print($"Хороших чисел - {gn}");
            Print($"Время работы составило {DateTime.Now - dateTime}");
            Pause();
        }
    }
}
