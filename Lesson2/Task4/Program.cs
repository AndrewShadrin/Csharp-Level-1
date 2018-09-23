using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
/// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
/// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
/// С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>
namespace Task4
{
    class Program
    {
        /// <summary>
        /// Проверяет логин и пароль, которые вводит пользователь. Целевой логин и пароль передается в параметрах.
        /// </summary>
        /// <param name="login">логин для проверки</param>
        /// <param name="password">пароль для проверки</param>
        /// <returns>возвращается истина, если логин и пароль совпадают</returns>
        static public bool CheckPassw(string login, string password, int tryCount=3)
        {
            bool answer = false;
            int count = 0;
            while (count < tryCount)
            {
                count++;
                string userLogin = ReadString("Введите логин: ");
                string userPassword = ReadString("Введите пароль: ");
                if (userLogin == login && userPassword == password)
                {
                    answer = true;
                    break;
                }
                else
                {
                    Print("Неправильный логин или пароль.");
                    if (count < tryCount)
                    {
                        Print("Попробуйте еще раз.");
                    }
                }
            }
            return answer;
        }

        static void Main()
        {
            Print("Пройдите проверку:");
            if (CheckPassw("root","GeekBrains"))
            {
                Print("Добро пожаловать!");
                //дальше что-то делаем...

                Pause();
            }
            else
            {
                Print("Авторизация не пройдена! Для выхода нажмите любую клавишу.");
                Pause();
            }
        }
    }
}
