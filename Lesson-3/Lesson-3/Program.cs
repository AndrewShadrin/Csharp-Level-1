using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LessonsClassLibrary.Useful;

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

        public int Num
        {
            get => num;
            set => num = value;
        }

        public int Denum
        {
            get => denum;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                denum = value;
            }
        }

        public Fraction()
        {
            num = 0;
            denum = 1;
        }

        public Fraction(int num, int denum = 1)
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

            res.num = num * fraction.denum + fraction.num * denum;
            res.denum = denum * fraction.denum;

            return res.Simpl();
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

            return res.Simpl();
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

            return res.Simpl();
        }

        /// <summary>
        /// Производит деление дроби на дробь
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>результат деления дробей</returns>
        public Fraction Divide(Fraction fraction)
        {
            Fraction res = new Fraction();

            res.num = num * fraction.denum;
            res.denum = denum * fraction.num;

            return res.Simpl();
        }

        /// <summary>
        /// Производит упрощение дроби
        /// </summary>
        /// <returns>упрощенная дробь</returns>
        public Fraction Simpl()
        {
            Fraction res = new Fraction();

            int nod = NOD(num, denum);
            res.num = num / nod;
            res.denum = denum / nod;

            return res;
        }

        /// <summary>
        /// Возвращает строковое представление дроби
        /// </summary>
        /// <param name="fraction"></param>
        /// <returns>строка вида "числитель/знаменатель"</returns>
        public override string ToString()
        {
            if (denum==1)
            {
                return $"{this.num}";
            }
            else
            {
                return $"{this.num}/{this.denum})";
            }
        }
    }

        class Program
    {
        static void Main()
        {
            Fraction fraction1, fraction2, result;
            fraction1 = new Fraction(1,2);
            fraction2 = new Fraction(1,4);
            
            //сложение
            result = fraction1.Add(fraction2);
            Print($"{fraction1} + {fraction2} = {result}");
            
            //вычитание
            result = fraction1.Ded(fraction2);
            Print($"{fraction1} - {fraction2} = {result}");
            
            //умножение
            result = fraction1.Multiply(fraction2);
            Print($"{fraction1} * {fraction2} = {result}");
            
            //деление
            result = fraction1.Divide(fraction2);
            Print($"{fraction1} / {fraction2} = {result}");

            //fraction1.Denum = 0;
            Pause();
        }
    }
}
