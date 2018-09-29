using System;
using System.Threading;

/// <summary>
/// Библиотека классов для использования на занятиях C# - 1 уровень
/// </summary>
namespace LessonsClassLibrary
{
    /// <summary>
    /// Класс представляет методы для быстрого оформления программы
    /// </summary>
    public static class Useful
    {
        /// <summary>
        /// Выводит сообщение по указанным координатам. Если не указано, то в текущую позицию курсора.
        /// </summary>
        /// <param name="message">строка выводимого сообщения</param>
        /// <param name="cursX">координата Х позиции курсора</param>
        /// <param name="cursY">координата Y позиции курсора</param>
        public static void Print(string message, int cursX = 0, int cursY = 0)
        {
            if (cursX!=0 && cursY!=0)
            {
                Console.SetCursorPosition(cursX, cursY);
            }
            Console.WriteLine(message);
        }

        /// <summary>
        /// Выводит сообщение по указанным координатам. Если не указано, то в текущую позицию курсора.
        /// </summary>
        /// <param name="message">Значение для вывода</param>
        /// <param name="cursX">координата Х позиции курсора</param>
        /// <param name="cursY">координата Y позиции курсора</param>
        public static void Print(int message, int cursX = 0, int cursY = 0)
        {
            if (cursX!=0 && cursY!=0)
            {
                Console.SetCursorPosition(cursX, cursY);
            }
            Console.WriteLine(message.ToString());
        }

        /// <summary>
        /// Осуществляет задержку работы программы, если указано время задержки, или ожидание нажатия клавиши пользователем
        /// </summary>
        /// <param name="delay">время задержки в миллисекундах</param>
        public static void Pause(int delay = 0)
        {
            if (delay == 0)
            {
                Console.ReadKey();
            }
            else
            {
                Thread.Sleep(delay);
            }
        }

        /// <summary>
        /// Запрашивает у пользователя значение типа Int
        /// </summary>
        /// <param name="message">сообщение для показа пользователю</param>
        /// <returns>значение типа int</returns>
        public static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Запрашивает у пользователя значение типа string
        /// </summary>
        /// <param name="message">сообщение для показа пользователю</param>
        /// <returns>значение типа string</returns>
        public static string ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        /// <summary>
        /// Запрашивает у пользователя значение типа double
        /// </summary>
        /// <param name="message">сообщение для показа пользователю</param>
        /// <returns>возвращает значение типа double</returns>
        public static double ReadDouble(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Возвращает наибольший общий делитель двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>число типа int</returns>
        public static int NOD(int a, int b)
        {
            if (b == 0)
                return a;

            return NOD(b, a % b);
        }
    }
}
