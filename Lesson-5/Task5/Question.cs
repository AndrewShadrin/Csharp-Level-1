using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Представляет вопрос с текстом, правильным ответом и стоимостью ответа
    /// </summary>
    class Question
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Правильный ответ да/нет (значение типа bool)
        /// </summary>
        public bool Answer { get; set; }
        /// <summary>
        /// Количество очков за правильный ответ
        /// </summary>
        public int Rate { get; set; }

        /// <summary>
        /// Представляет вопрос с текстом
        /// </summary>
        /// <param name="text">текст вопроса</param>
        /// <param name="answer">правильный ответ</param>
        /// <param name="rate">стоимость ответа</param>
        public Question(string text,bool answer,int rate=1)
        {
            Text = text;
            Answer = answer;
            Rate = rate;
        }

        /// <summary>
        /// Конструктор по умолчанию. Создает пустой вопрос.
        /// </summary>
        public Question()
        { }

        /// <summary>
        /// Возвращает строковое представление вопроса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Text} (да/нет)";
        }
    }
}
