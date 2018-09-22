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

    }
}
