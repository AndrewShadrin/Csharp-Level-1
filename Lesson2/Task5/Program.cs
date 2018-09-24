using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LessonsClassLibrary.Useful;

/// <summary>
/// 5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
///     б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
/// </summary>
namespace Task5
{
    class Program
    {
        static void Main()
        {
            int height;
            double weight, index, weightNormLow, weightNormHigh;

            height = ReadInt("Введите рост в сантиметрах ");
            weight = ReadDouble("Введите вес в килограммах ");

            index = weight * 10000 / (height * height);
            Print($"Ваш индекс массы тела = {index:f2}");

            weightNormLow = 18.5 * (height * height) / 10000;
            weightNormHigh = 24.99 * (height * height) / 10000;

            #region Description of index
            //Индекс массы тела Соответствие между массой человека и его ростом
            //16 и менее  Выраженный дефицит массы тела
            //16—18,5 Недостаточная(дефицит) масса тела
            //18,5—24,99  Норма
            //25—30   Избыточная масса тела(предожирение)
            //30—35   Ожирение
            //35—40   Ожирение резкое
            //40 и более  Очень резкое ожирение        
            #endregion

            if (index >= 40)
            {
                Print("У Вас очень резкое ожирение");
                Print($"Вам нужно похудеть как минимум на {weight - weightNormHigh:f2} кг");
            }
            else if (index >= 35)
            {
                Print("У Вас резкое ожирение");
                Print($"Вам нужно похудеть как минимум на {weight - weightNormHigh:f2} кг");
            }
            else if (index >= 30)
            {
                Print("У Вас ожирение");
                Print($"Вам нужно похудеть как минимум на {weight - weightNormHigh:f2} кг");
            }
            else if (index >= 25)
            {
                Print("У Вас избыточная масса тела(предожирение)");
                Print($"Вам нужно похудеть как минимум на {weight - weightNormHigh:f2} кг");
            }
            else if (index >= 18.5)
            {
                Print("У Вас нормальная масса тела");
            }
            else if (index >= 16)
            {
                Print("У Вас недостаточная(дефицит) масса тела");
                Print($"Вам нужно набрать как минимум {weightNormLow - weight:f2} кг");
            }
            else if (index < 16)
            {
                Print("У Вас выраженный дефицит массы тела");
                Print($"Вам нужно набрать как минимум {weightNormLow - weight:f2} кг");
            }
            Pause();
        }
    }
}
