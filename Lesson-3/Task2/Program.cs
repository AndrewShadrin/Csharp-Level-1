using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 2.  а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
///        Требуется подсчитать сумму всех нечетных положительных чисел. 
///        Сами числа и сумму вывести на экран, используя tryParse;
///     б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
///        При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task2
{
    class Program
    {
        static int GetValue(string message)
        {
            int x;
            string s;
            bool flag; 
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
            }
            while (!flag); 
            return x;
        }
        static void Main()
        {
            int number, sum = 0;

            while (true)
            {
                number = GetValue("Введите число: ");
                if (number%2 != 0 && number > 0)
                {
                    sum += number;
                }
                else if (number == 0)
                {
                    break;
                }
            }
            Print($"Сумма нечетных положительных чисел = {sum}");
            Pause();
        }
    }
}
