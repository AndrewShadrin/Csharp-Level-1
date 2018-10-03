using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 1. Создать программу, которая будет проверять корректность ввода логина. 
///     Корректным логином будет строка от 2 до 10 символов, 
///     содержащая только буквы латинского алфавита или цифры, 
///     при этом цифра не может быть первой:
/// а) без использования регулярных выражений;
/// б) с использованием регулярных выражений.
/// Выполнил Шадрин Андрей
/// </summary>
namespace Lesson_5
{
    class Program
    {
        static bool IsDigit(char sym)
        {
            return sym >= '0' && sym <= '9';
        }

        static bool IsLetter(char sym)
        {
            return sym >= 'a' && sym <= 'z' || sym >= 'A' && sym <= 'Z'; ;
        }

        static void Main()
        {
            while (true)
            {
                string login = ReadString("Введите логин: ");
                if (login.Length == 0)
                {
                    Print("Логин не может быть пустым.");
                    continue;
                }
                if (IsDigit(login[0]))
                {
                    Print("Логин не может начинаться с цифры. Попробуйте еще.");
                    continue;
                }
                bool res = true;
                for (int i = 0; i < login.Length; i++)
                {
                    if (!IsLetter(login[i])&&!IsDigit(login[i]))
                    {
                        res = false;
                    }
                }
                if (!res)
                {
                    Print("Логин должен содержать только латинские буквы и цифры!");
                }
                else
                {
                    Print("Хороший пароль!");
                    break;
                }
            }
            Pause();
        }
    }
}
