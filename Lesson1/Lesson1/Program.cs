1 задание
using System;

public class Program
{
    public static void Main()
    {
        string name, surname, age, height, weight;

        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        surname = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        age = Console.ReadLine();
        Console.WriteLine("Введите рост");
        height = Console.ReadLine();
        Console.WriteLine("Введите вес");
        weight = Console.ReadLine();

        Console.WriteLine(name + " " + surname + ", " + age + " лет, рост " + height + ", вес " + weight);
        Console.WriteLine("{0} {1}, {2} лет, рост {3}, вес {4}", name, surname, age, height, weight);
        Console.WriteLine($"{name} {surname}, {age} лет, рост {height}, вес {weight}");
    }
}

2 задание

using System;

public class Program
{
    public static void Main()
    {
        string name, surname;
        int age, height;
        double weight, index;

        Console.WriteLine("Введите имя");
        name = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        surname = Console.ReadLine();
        Console.WriteLine("Введите возраст в годах");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите рост в сантиметрах");
        height = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вес в килограммах");
        weight = Convert.ToDouble(Console.ReadLine());

        // 1 задание
        Console.WriteLine(name + " " + surname + ", " + age + " лет, рост " + height + ", вес " + weight);
        Console.WriteLine("{0} {1}, {2} лет, рост {3}, вес {4}", name, surname, age, height, weight);
        Console.WriteLine($"{name} {surname}, {age} лет, рост {height}, вес {weight}");

        // 2 задание
        index = weight * 10000 / (height * height);
        Console.WriteLine($"Индекс массы тела = {index}");
    }
}


3 задание
using System;

public class Program
{
    public struct point
    {
        public int x;
        public int y;
    }

    public void ReadPoint(point dest)
    {
        Console.WriteLine("Введите координату х точки");
        dest.x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координату y точки");
        dest.y = Convert.ToInt32(Console.ReadLine());
    }

    public static void Main()
    {
        point a, b = new point();

        Console.WriteLine("Введите данные первой точки");
        ReadPoint(a);
        Console.WriteLine("Введите данные второй точки");
        ReadPoint(b);

        // 2 задание
        index = weight * 10000 / (height * height);
        Console.WriteLine($"Индекс массы тела = {index}");
    }
}

