using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
/// Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
/// Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. 
/// Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. 
/// Список вопросов ищите во вложении или воспользуйтесь интернетом.
/// </summary>
namespace Task5
{
    class Program
    {
        /// <summary>
        /// Конвертирует ответ пользователя в тип булево
        /// </summary>
        /// <param name="res">строка с ответом пользователя</param>
        /// <returns>true если ответ пользователя "Да" или "Yes"</returns>
        public static bool ConvertAnswer(string res)
        {
            if (res.ToUpper() == "ДА" || res.ToUpper() == "Д" || res.ToUpper() == "Y" || res.ToUpper() == "YES") return true;
            else return false;
        }

        static void Main()
        {
            int userRate = 0;
            Questions questions = new Questions("questions.dat");
            int maxCount = 5;
            Random rnd = new Random();
            for (int i = 0; i < maxCount; i++)
            {
                Question question = questions[rnd.Next(questions.Count)];
                string mes = $"Вопрос №{i+1}: {question}: ";
                string res = ReadString(mes);
                if ( ConvertAnswer(res) && question.Answer)
                {
                    userRate++;
                }
            }
            Print($"Вы ответили правильно на {userRate} вопроса(ов).");
            Pause();
        }
    }
}
