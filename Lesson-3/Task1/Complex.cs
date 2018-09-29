/// <summary>
/// 1.  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
///     б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
/// Выполнил Шадрин Андрей 
/// 1. сложение     add,(a, b)+(c, d)=(a+b,c+d);
/// 2. вычитание    ded,(a, b)-(c, d)=(a-b,c-d);
/// 3. умножение    mult,(a, b)x(c, d)=(ac-bd,ad+bc);
/// 4. деление      div,(a, b)/(c, d)=(ac+bd,bc-ad)/(c^2+d^2);
/// 5. сравнение    equ,(a, b)=(c, d),если(a= c) и(b= d);
/// </summary>
namespace Task1
{
    class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        /// <summary>
        /// Производит сложение 2-х комплексных чисел
        /// </summary>
        /// <param name="x2">слагаемое - комплексное число</param>
        /// <returns>Комплексное число, результат сложения 2-х комплексных чисел</returns>
        public Complex Add(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        /// <summary>
        /// Производит вычитание 2-х комплексных чисел
        /// </summary>
        /// <param name="x2">вычитаемое - комплексное число</param>
        /// <returns>Комплексное число, результат разности 2-х комплексных чисел</returns>
        public Complex Ded(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        /// <summary>
        /// Производит умножение 2-х комплексных чисел
        /// </summary>
        /// <param name="x2">множитель - комплексное число</param>
        /// <returns>Комплексное число, результат произведения 2-х комплексных чисел</returns>
        public Complex Mult(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im * x2.im - re * x2.re;
            x3.re = im * x2.re + re * x2.im;
            return x3;
        }

        /// <summary>
        /// Производит деление 2-х комплексных чисел
        /// </summary>
        /// <param name="x2">делитель - комплексное число</param>
        /// <returns>Комплексное число, результат деления 2-х комплексных чисел</returns>
        public Complex Div(Complex x2)
        {
            //div,(a, b) / (c, d) = (ac + bd, bc - ad) / (c ^ 2 + d ^ 2);
            Complex x3 = new Complex();
            x3.im = (im * x2.im + re * x2.re) / (im * im + x2.re * x2.re);
            x3.re = (re * x2.im - im * x2.re) / (im * im + x2.re * x2.re);
            return x3;
        }

        /// <summary>
        /// Проверяет на равенство 2 комплексных числа
        /// </summary>
        /// <param name="complex2">сравниваемое число</param>
        /// <returns>истина, если числа равны</returns>
        public bool Equals(Complex complex2)
        {
            return im == complex2.im && re == complex2.re;
        }

        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }

        public override string ToString()
        {
            return re + (im>=0?"+":"") + im + "i";
        }
    }
}
