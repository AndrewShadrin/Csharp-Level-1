using System;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
///    Выполнил Шадрин Андрей
/// </summary>
namespace Task3
{
    class Program
    {
        static void Main()
        {
            int number,sum = 0;

            while (true)
            {
                number = ReadInt("Введите целое число: ");
                if (number%2!=0 && number>0)
                {
                    sum += number;
                }
                else if (number == 0)
                {
                    break;
                }
            }
            Print($"Сумма всех нечетных чисел равна {sum}");
            Pause();
        }
    }
}
