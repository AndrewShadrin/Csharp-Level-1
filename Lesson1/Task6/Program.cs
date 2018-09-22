using System;
using System.Threading;

namespace Lessons
{
    //  6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
    //  Выполнил Шадрин Андрей

    public static class Useful
    {
        public static void Print(string message, int cursX=0, int cursY=0)
        {
            Console.SetCursorPosition(cursX, cursY);
            Console.WriteLine(message);
        }

        public static void Pause(int delay=0)
        {
            if (delay==0)
            {
                Console.ReadKey();
            }
            else
            {
                Thread.Sleep(delay);
            }
        }

    }

    class Program
    {
        static void Main()
        {
            Useful.Print("Hello word!");
            Useful.Pause(3000);
        }
    }
}
