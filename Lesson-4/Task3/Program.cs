using System;
using System.IO;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
/// </summary>
namespace Task3
{
    class Program
    {
        private static Account[] accounts;

        static Account[] Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            // Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            Account[] a = new Account[N];
            // Считываем массив
            for (int i = 0; i < N; i++)
            {
                string[] str = sr.ReadLine().Split(' ');
                a[i].login = str[0];
                a[i].password = str[1];
            }
            sr.Close();

            return a;
        }

        static bool Auth(string login, string password)
        {
            bool result = false;
            foreach (var account in accounts)
            {
                if (account.login==login && account.password==password)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private static void GetAnswer(int count, int tryCount, ref bool answer)
        {
            while (count < tryCount)
            {
                count++;
                string userLogin = ReadString("Введите логин: ");
                string userPassword = ReadString("Введите пароль: ");
                if (Auth(userLogin, userPassword))
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
        }

        static void Main(string[] args)
        {
            accounts = Load(@"c:\temp\acc.dat");
            //foreach (var account in accounts)
            //{
            //    Print($"Login: {account.login} Password: {account.password}");
            //}
            int count = 0;
            int tryCount = 3;
            bool answer = false;

            GetAnswer(count, tryCount, ref answer);

            if (answer)
            {
                Print("Welcome!!!");
                //do something
            }
            else
            {
                Print("Аутентификация не пройдена! Завершение работы...");
            }
            Pause();
        }

    }
}
