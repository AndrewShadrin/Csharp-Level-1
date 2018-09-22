using System;

namespace Task1
{
    // 1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
    //  а) используя склеивание;
    //  б) используя форматированный вывод;
    //  в) * используя вывод со знаком $.
    //  Выполнил Шадрин Андрей

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
}


