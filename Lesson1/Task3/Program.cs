using System;

namespace Task3
{
    // 3.
    //  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //  б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
    //  Выполнил Шадрин Андрей

    public class Program
    {
        public static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void Main()
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            double distance = 0;

            Console.WriteLine("Введите данные первой точки");
            Console.WriteLine("Введите координату х точки");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y точки");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите данные второй точки");
            Console.WriteLine("Введите координату х точки");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y точки");
            y2 = Convert.ToInt32(Console.ReadLine());

            // 3 задание
            distance = Distance(x1,y1,x2,y2);
            Console.WriteLine($"Расстояние между точками = {distance,3:f2}");
            Console.ReadKey();
        }
    }

}
