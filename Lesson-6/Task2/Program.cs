using System;
using System.IO;
using System.Collections.Generic;

/// <summary>
/// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
/// а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
/// б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
/// в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр.
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task2
{
    class Program
    {
        public delegate double Fun(double x);

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Fun f, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
            FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open,
            FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            List<double> table = new List<double>();
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                table.Add(d);
            }
            bw.Close();
            fs.Close();
            return table.ToArray();
        }

        static void Main(string[] args)
        {
            List<Fun> listFun = new List<Fun>();
            listFun.Add(Math.Cos);
            listFun.Add(Math.Sin);
            listFun.Add(Math.Tan);
            listFun.Add(F);
            for (int i = 0; i < listFun.Count; i++)
            {
                Console.WriteLine($"Функция {i+1}: {listFun[i].Method}");
            }
            Console.WriteLine("Выберите функцию");
            int numF = Convert.ToInt32(Console.ReadLine());
            SaveFunc("data.bin", listFun[numF-1], -100, 100, 0.5);
            double min;
            double[] table = Load("data.bin",out min);
            Console.WriteLine($"Минимум функции равен: {min}");
            Console.ReadKey();
        }
    }
}