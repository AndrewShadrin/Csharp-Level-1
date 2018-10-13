using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lesson_7
{
    public class Doubler : INotifyPropertyChanged
    {
        private int target;
        private int gross;
        public int StepCount{ get; private set; }
        public int Gross { get { return gross; } }
        public int Target{ get { return target; } }
        delegate void @delegate (bool b);
        private Stack<@delegate> st;

        // событие необходимо для уведомлений о том, что изменились значения свойств 
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private void Changed(string name)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public Doubler()
        {
            gross = 0;
            StepCount = 0;
            st = new Stack<@delegate>();
        }

        /// <summary>
        /// Сбрасывает количество ходов и накопленную сумму
        /// </summary>
        public void ResetGrossCount()
        {
            gross = 0;
            StepCount = 0;
            st = new Stack<@delegate>();
            Changed("Gross");
        }

        /// <summary>
        /// Сравнивает целевое значение и собираемое значение
        /// </summary>
        /// <returns>1 - если цель больше, -1 - если цель меньше, 0 - равно</returns>
        public int CheckTarget()
        {
            int res;
            if (target - gross > 0)
            {
                res = 1;
            }
            else if (target - gross < 0)
            {
                res = -1;
            }
            else res = 0;

            return res;
        }

        /// <summary>
        /// Устанавливает новое целевое значение
        /// </summary>
        public void NewTarget()
        {
            Random rnd = new Random();
            target = rnd.Next(100);
            StepCount = 0;
            gross = 0;
            Changed("Gross");
            Changed("StepCount");
            Changed("Target");
        }

        /// <summary>
        /// Добавляет единицу к собираемому значению
        /// </summary>
        public void Add(bool b=true)
        {
            if (b)
            {
                gross++;
                StepCount++;
                st.Push(Add);
            }
            else
            {
                gross--;
                StepCount--;
            }
            Changed("Gross");
            Changed("StepCount");
        }

        /// <summary>
        /// Удваивает собираемое значение
        /// </summary>
        public void X2(bool b = true)
        {
            if (b)
            {
                gross *= 2;
                StepCount++;
                st.Push(X2);
            }
            else
            {
                gross /= 2;
                StepCount--;
            }
            Changed("Gross");
            Changed("StepCount");
        }

        public void Back()
        {
            if (st.Count != 0)
            {
                st.Pop()(false);
            }
            Changed("Gross");
            Changed("StepCount");
        }

    }
}
