using System.Text.RegularExpressions;
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
        /// <summary>
        /// Проверяет, является ли передаваемый символ цифрой
        /// </summary>
        /// <param name="sym">символ для проверки</param>
        /// <returns>возвращает значение true, если символ является цифрой</returns>
        static bool IsDigit(char sym)
        {
            return sym >= '0' && sym <= '9';
        }

        /// <summary>
        /// Проверяет, является ли передаваемый символ буквой латинского алфавита
        /// </summary>
        /// <param name="sym">символ для проверки</param>
        /// <returns>возвращает значение true, если символ является буквой</returns>
        static bool IsLetter(char sym)
        {
            return sym >= 'a' && sym <= 'z' || sym >= 'A' && sym <= 'Z'; ;
        }

        /// <summary>
        /// Проверяет правильность формата логина
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="message">возвращаемое сообщение о корректности логина</param>
        /// <returns>истина, если логин соответствует условиям</returns>
        static bool LoginIsGood(string login, ref string message)
        {
            if (login.Length == 0)
            {
                message = "Логин не может быть пустым.";
                return false;
            }
            if (IsDigit(login[0]))
            {
                message = "Логин не может начинаться с цифры. Попробуйте еще.";
                return false;
            }
            for (int i = 0; i < login.Length; i++)
            {
                if (!IsLetter(login[i]) && !IsDigit(login[i]))
                {
                    message = "Логин должен содержать только латинские буквы и цифры!";
                    return false;
                }
            }
            message = "Хороший пароль!";
            return true;
        }

        /// <summary>
        /// Проверяет правильность формата логина с помощью регулярных выражений
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="message">возвращаемое сообщение о корректности логина</param>
        /// <returns>истина, если логин соответствует условиям</returns>
        static bool LoginIsGoodRegE(string login, ref string message)
        {
            if (login.Length == 0)
            {
                message = "Логин не может быть пустым.";
                return false;
            }
            Regex regex = new Regex(@"^\d");
            if (regex.IsMatch(login))
            {
                message = "Логин не может начинаться с цифры. Попробуйте еще.";
                return false;
            }
            regex = new Regex(@"[a-zA-Z0-9]",RegexOptions.IgnoreCase);
            if (regex.Matches(login).Count!=login.Length)
            {
                message = "Логин должен содержать только латинские буквы и цифры!";
                return false;
            }
            message = "Хороший пароль!";
            return true;
        }

        static void Main()
        {
            bool res;
            while (true)
            {
                string message = string.Empty;
                string login = ReadString("Введите логин: ");
                res = LoginIsGoodRegE(login, ref message);
                Print(message);
                if (res)
                {
                    break;
                }
            }
            Pause();
        }
    }
}
