using System;
using System.IO;

namespace Task4
{
    class Array2D
    {
        int[,] a;

        public Array2D(int x, int y, int min, int max)
        {
            a = new int[x, y];
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    a[i, j] = rnd.Next(min, max);
        }

        public int Min
        {
            get
            {
                int min = a[0, 0];
                
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                return max;
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    sum += a[i, j];
            return sum;
        }

        public int SumH(int x)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > x)
                    {
                        sum += a[i, j];
                    }
                }
            return sum;
        }

        public void MaxPos(out int posX, out int posY)
        {
            int max = Max;
            bool br = false;
            posX = -1;
            posY = -1;
            for (int i = 0; i < a.GetLength(0); i++)
            {   for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        posX = i;
                        posY = j;
                        br = true;
                        break;
                    }
                }
                if (br) break;
            }
        }

        /// <summary>
        /// Создает массив, считывая его данные из файла
        /// </summary>
        /// <param name="fileName">полное имя файла</param>
        public Array2D(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            // Считываем количество элементов массива
            int X = int.Parse(sr.ReadLine());
            int Y = int.Parse(sr.ReadLine());
            a = new int[X,Y];
            // Считываем массив
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                    a[X,Y] = int.Parse(sr.ReadLine());
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
            sw.WriteLine(a.GetLength(0));
            sw.WriteLine(a.GetLength(1));
            // Записываем элементы массива
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sw.WriteLine(a[i,j]);
                }
            sw.Close();
        }

        /// <summary>
        /// Производит чтение массива из файла
        /// </summary>
        /// <param name="fileName">полное имя файла</param>
        public void Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            // Считываем количество элементов массива
            int X = int.Parse(sr.ReadLine());
            int Y = int.Parse(sr.ReadLine());
            a = new int[X, Y];
            // Считываем массив
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                    a[i, j] = int.Parse(sr.ReadLine());
            }
            sr.Close();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; // Переход на новую строчку
            }
            return s;
        }
    }
}
