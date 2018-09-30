using System;
using System.Text;
using System.Threading.Tasks;
using static LessonsClassLibrary.Useful;

namespace Lesson_4
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
