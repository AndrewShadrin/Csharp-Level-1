using System;

//2 задание
namespace Task2
{
// 2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
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