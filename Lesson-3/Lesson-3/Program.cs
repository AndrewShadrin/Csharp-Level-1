using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3.  *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
///     Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
///     Написать программу, демонстрирующую все разработанные элементы класса. 
///     ** Добавить проверку, чтобы знаменатель не равнялся 0. 
///     Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
///     Добавить упрощение дробей.
/// </summary>
namespace Lesson_3
{
    /// <summary>
    /// Класс реализует дробь - рациональное число, являющееся отношением двух целых чисел.
    /// </summary>
    public class Fraction
    {
        // numerator
        private int num;
        // denumerator
        private int denum;

        public int Num { get; set; }
        public int Denum { get; set; }

        public Fraction()
        {
            num = 0;
            denum = 1;
        }

        public Fraction(int num, int denum)
        {
            this.num = num;
            this.denum = denum;
        }

        /// <summary>
        /// Производит сложение дроби и текущей дроби
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>результат сложения дробей</returns>
        public Fraction Add(Fraction fraction)
        {
            Fraction res = new Fraction();

            res.Num = num * fraction.Denum + fraction.Num * denum;
            res.Denum = denum * fraction.Denum;

            return res;
        }

        /// <summary>
        /// Производит вычитание дроби из текущей дроби
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>результат вычитания дроби</returns>
        public Fraction Ded(Fraction fraction)
        {
            Fraction res = new Fraction();

            res.Num = num * fraction.Denum - fraction.Num * denum;
            res.Denum = denum * fraction.Denum;

            return res;
        }
        
        /// <summary>
        /// Производит умножение дроби на текущую дробь
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>результат умножения дробей</returns>
        public Fraction Multiply(Fraction fraction)
        {
            Fraction res = new Fraction();

            res.Num = num * fraction.Num;
            res.Denum = denum * fraction.Denum;

            return res;
        }

        /// <summary>
        /// Производит деление дроби на дробь
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>результат деления дробей</returns>
        public Fraction Divide(Fraction fraction)
        {
            Fraction res = new Fraction();

            res.Num = num * fraction.Denum;
            res.Denum = denum * fraction.Num;

            return res;
        }

        /// <summary>
        /// Производит упрощение дроби
        /// </summary>
        /// <returns>упрощенная дробь</returns>
        public Fraction Simpl()
        {
            Fraction res = new Fraction();

            res.Num = num;
            res.Denum = denum;

            return res;
        }
    }

        class Program
    {
        static void Main()
        {
        }
    }
}
