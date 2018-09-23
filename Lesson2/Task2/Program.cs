using System;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 2. Написать метод подсчета количества цифр числа.
/// </summary>
namespace Task2
{

    class Program
     {
        /// <summary>
        /// Возвращает количество цифр в числе
        /// </summary>
        /// <param name="number">число</param>
        /// <returns></returns>
        public static int AmountNumbers(int number)
        {
            string amount = number.ToString();
            amount = amount.Replace("-", "");

            return amount.Length;
        }

        /// <summary>
        /// Возвращает количество цифр в числе
        /// </summary>
        /// <param name="number">число</param>
        /// <returns></returns>
        public static int AmountNumbers(double number)
        {
            string amount = Convert.ToString(number);
            amount = amount.Replace(",", "");
            amount = amount.Replace("-", "");

            return amount.Length;
        }

        static void Main()
        {
            Print(AmountNumbers(1234567890));
            Print(AmountNumbers(123456789034.123));
            Pause();
        }
    }
}
