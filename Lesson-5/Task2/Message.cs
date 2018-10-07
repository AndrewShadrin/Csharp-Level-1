using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Message
    {
        /// <summary>
        /// Возвращает строку, состоящую из слов длиной меньше n
        /// </summary>
        /// <param name="mess">исходное сообщение</param>
        /// <param name="n">длина слова</param>
        /// <returns>строка из слов длиной меньше n</returns>
        public static string GetWordsBelowN(string mess, int n)
        {
            StringBuilder res = new StringBuilder();
            string[] str = PrepareString(mess);
            foreach (string word in str)
            {
                if (word.Length < n)
                {
                    res.Insert(res.Length, word + " ");
                }
            }
            return res.ToString();
        }

        /// <summary>
        /// Подготавливает строку удаляя из нее символы пунктуации и переноса строк
        /// </summary>
        /// <param name="mess">исходное сообщение</param>
        /// <returns>массив слов из сообщения</returns>
        private static string[] PrepareString(string mess)
        {
            char[] separator = new char[] { ' ' };
            StringBuilder temp = new StringBuilder(mess.Replace("\r\n", " "));
            for (int i = 0; i < temp.Length;)
                if (char.IsPunctuation(temp[i])) temp.Remove(i, 1);
                else ++i;
            temp.Replace("  ", " ");
            string[] str = temp.ToString().TrimStart().TrimEnd().Split(separator);
            return str;
        }

        /// <summary>
        /// Возвращает строку, состоящую из слов не оканчивающихся на указанный символ
        /// </summary>
        /// <param name="mess">исходное сообщение</param>
        /// <param name="sym">искомый символ</param>
        /// <returns>строка из слов не оканчивающихся на искомый символ</returns>
        public static string GetWordsWithoutSym(string mess, char sym)
        {
            StringBuilder res = new StringBuilder();
            string[] str = PrepareString(mess);
            foreach (string word in str)
            {
                if (word[word.Length-1] != sym)
                {
                    res.Insert(res.Length, word+" ");
                }
            }
            return res.ToString();
        }

        /// <summary>
        /// Возвращает максимальную длину слова из сообщения
        /// </summary>
        /// <param name="mess">строка сообщения</param>
        /// <returns>число</returns>
        public static int GetWordMaxLength(string mess)
        {
            string[] str = PrepareString(mess);
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > max)
                {
                    max = str[i].Length;
                }
            }
            return max;
        }

        /// <summary>
        /// Возвращает строку, состоящую из самых длинных слов сообщения
        /// </summary>
        /// <param name="mess">исходное сообщение</param>
        /// <returns>строка из самых длинных слов сообщения</returns>
        public static string GetStringFromMaxWords(string mess)
        {
            StringBuilder res = new StringBuilder();
            int max = GetWordMaxLength(mess);
            string[] str = PrepareString(mess);
            foreach (string word in str)
            {
                if (word.Length == max)
                {
                    res.Insert(res.Length, word + " ");
                }
            }
            return res.ToString();
        }
    }
}
