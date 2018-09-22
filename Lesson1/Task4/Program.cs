﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c;
            #region SwapVariable
                Console.WriteLine("Обмен с помощью переменной");
                a = 1;
                b = 3;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
                c = a;
                a = b;
                b = c;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
            #endregion

            #region SwapMathematic
                Console.WriteLine("Обмен с помощью математики");
                a = 5;
                b = 3;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
            #endregion

            #region SwapXOR
                Console.WriteLine("Обмен с помощью XOR");
                a = 11;
                b = 22;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
                a = a ^ b;
                b = a ^ b;
                a = a ^ b;
                Console.WriteLine($"Переменная a = {a}, переменная b = {b}");
                Console.ReadKey();
            #endregion
        }
    }
}
