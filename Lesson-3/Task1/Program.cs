using System;
using static LessonsClassLibrary.Useful;

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

    class Program
    {
        static void Main()
        {
            // Описали ссылку на объект.
            Complex complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new Complex(1, 1);
            // Описали объект и создали его.
            Complex complex2 = new Complex(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            Complex result;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            result = complex1.Add(complex2);
            Console.WriteLine(result.ToString());
            //вычитание чисел
            result = complex1.Ded(complex2);
            Print($"Результат вычитания = {result}");
            //умножение чисел
            result = complex1.Mult(complex2);
            Print($"Результат умножения = {result}");
            Pause();
        }
    }
}
