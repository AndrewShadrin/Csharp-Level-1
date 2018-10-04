using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
/// а) с использованием методов C#;
/// б) * разработав собственный алгоритм.
/// Например:
/// badc являются перестановкой abcd.
/// </summary>
namespace Task3
{
    class Program
    {

        static void Main()
        {
            string s1 = ReadString("Введите 1-ю строку: ");
            string s2 = ReadString("Введите 2-ю строку: ");
            Print(""+s1.OrderBy(x => x).SequenceEqual(s2.OrderBy(x => x)));
            Pause();
        }
    }
}
