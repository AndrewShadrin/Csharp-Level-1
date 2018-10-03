using System;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
/// Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
/// В данной задаче под парой подразумевается два подряд идущих элемента массива. 
/// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[20];
            Random rnd = new Random();

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-10000, 10000);
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < ar.Length-1; i++)
            {
                if (ar[i]%3==0 || ar[i+1]%3==0)
                {
                    count++;
                }
            }
            Print($"Количество пар элементов массива = {count}");
            Pause();
        }
    }
}
