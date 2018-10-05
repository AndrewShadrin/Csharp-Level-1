using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task5
{
    /// <summary>
    /// Список вопросов
    /// </summary>
    class Questions
    {
        private List<Question> questions;

        /// <summary>
        /// Выполняет загрузку вопросов из файла
        /// </summary>
        /// <param name="path">Полное имя файла для загрузки</param>
        public Questions(string path)
        {
            questions = new List<Question>();
            StreamReader sr = new StreamReader(path,Encoding.GetEncoding(1251));
            int count = 0;
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split(';');
                count++;
                if (str.Length < 2)
                {
                    throw new Exception($"Ошибка при чтении файла вопросов в {count} строке. Неправильный формат строки.");
                }
                questions.Add(new Question(str[0], str[1].ToUpper() == "ДА" ? true : false));
            }
        }

        /// <summary>
        /// Возвращает вопрос из списка по его индексу
        /// </summary>
        /// <param name="index">номер вопроса в списке</param>
        /// <returns>вопрос</returns>
        public Question this[int index]
        {
            get { return questions[index]; }
            set { questions[index] = value; }
        }

        /// <summary>
        /// Получает число вопросов в списке
        /// </summary>
        public int Count { get { return questions.Count; } }
    }
}
