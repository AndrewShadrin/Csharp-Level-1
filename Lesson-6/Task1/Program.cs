﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double). 
/// Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task1
{
    class Program
    {
        // Описываем делегат. В делегате описывается сигнатура методов, на
        // которые он сможет ссылаться в дальнейшем (хранить в себе)
        public delegate double Fun(double x);

        public delegate double Fun2(double a, double x);

        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static void Table2(Fun2 F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }
        public static double MyFunc2(double a, double x)
        {
            return a * x * x;
        }
        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2); // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
            //использование лямбда выражения
            Table(x=>x * x, 0, 3);
            Console.WriteLine("Таблица функции a*x^2:");
            Table2(MyFunc2, 2, -2, 2);
            Console.WriteLine("Таблица функции a*sin x:");
            Table2(delegate (double a, double x) { return a * Math.Sin(x); }, 2, -2, 2);
            Table2((a, x)=> a * Math.Sin(x), 2, -2, 2);
            Console.ReadKey();
        }
    }}
