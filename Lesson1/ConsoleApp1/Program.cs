using System;

//2 задание
namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            int height;
            double weight, index;

            Console.WriteLine("Введите рост в сантиметрах");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес в килограммах");
            weight = Convert.ToDouble(Console.ReadLine());

            // 2 задание
            index = weight * 10000 / (height * height);
            Console.WriteLine($"Индекс массы тела = {index}");
        }
    }
}