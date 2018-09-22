using System;

namespace Task5
{
    // 5.
    //  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //  б) Сделать задание, только вывод организуйте в центре экрана
    //  в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
    //  Выполнил Шадрин Андрей

    class Program
    {
        static void Print(string message, int cursX, int cursY)
        {
            Console.SetCursorPosition(cursX, cursY);
            Console.WriteLine(message);
        }

        static void Main()
        {
            //Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight / 2);
            //Console.WriteLine("Андрей Шадрин, Санкт-Петербург");
            Print("Андрей Шадрин, Санкт-Петербург", Console.WindowWidth / 2 - 15, Console.WindowHeight / 2);
            Console.ReadKey();
        }
    }
}
