using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task2
{
    class MyArray
    {
        int[] a;
        
        // Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        // Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Создание массива и заполнение его значениями, начиная с е1 с шагом dx
        /// </summary>
        /// <param name="n">размерность массива</param>
        /// <param name="el">значение первого элемента</param>
        /// <param name="dx">шаг изменения значения элементов</param>
        public MyArray(int n, int el, int dx=1, bool d=true)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el + dx * i;
        }

        /// <summary>
        /// Создает массив, считывая его данные из файла
        /// </summary>
        /// <param name="fileName">полное имя файла</param>
        public MyArray(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            // Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            // Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        /// <summary>
        /// Возвращает количество элементов массива
        /// </summary>
        public int Length { get { return a.Length; } }

        /// <summary>
        /// Возвращает сумму всех элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (var item in a)
                {
                    sum += item;
                }
                return sum;
            }
        }

        /// <summary>
        /// Возвращает количество максимальных элементов
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                int m = Max;
                foreach (var item in a)
                {
                    if (item == m)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        /// <summary>
        /// Производит инверсию массива меняя знаки всех элементов
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
            }
        }

        /// <summary>
        /// Производит умножение каждого элемента массива на число в параметре
        /// </summary>
        /// <param name="m">число для умножения</param>
        public void Multi(int m)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i]*m;
            }
        }

        /// <summary>
        /// Производит чтение массива из файла
        /// </summary>
        /// <param name="fileName">полное имя файла</param>
        public void Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            // Считываем количество элементов массива
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            // Считываем массив
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }

        /// <summary>
        /// Производит запись данных массива в файл
        /// </summary>
        /// <param name="fileName"></param>
        public void Save(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            // Записываем количество элементов массива
            sw.WriteLine(a.Length);
            // Записываем элементы массива
            for (int i = 0; i < a.Length; i++)
            {
                sw.WriteLine(a[i]);
            }
            sw.Close();
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
