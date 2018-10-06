using System.Linq;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
/// а) с использованием методов C#;
/// б) * разработав собственный алгоритм.
/// Например:
/// badc являются перестановкой abcd.
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task3
{
    class Program
    {
        static bool IsSwap(string s1, string s2)
        {
            bool res = true;

            if (s1.Length!=s2.Length)
            {
                return false;
            }
            s1 = s1.OrderBy(x => x).ToString();
            s2 = s2.OrderBy(x => x).ToString();
            res = s1 == s2;
            return res;
        }
        static void Main()
        {
            string s1 = ReadString("Введите 1-ю строку: ");
            string s2 = ReadString("Введите 2-ю строку: ");
            Print($"Результат сравнения - {s1.OrderBy(x => x).SequenceEqual(s2.OrderBy(x => x))}");
            Print($"IsSwap = {IsSwap(s1, s2)}");
            Pause();
        }
    }
}
