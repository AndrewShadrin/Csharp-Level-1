using System;
using System.Windows.Forms;

namespace Lesson_7
{
    public partial class MainForm : Form
    {
        public Doubler doubler;

        public MainForm()
        {
            InitializeComponent();
            doubler = new Doubler();
            doublerBindingSource.DataSource = doubler;
        }

        #region Обработчики выбора пунктов меню

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void игратьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doubler.NewTarget();
            RefreshData();
            lblGameOverNot.Visible = false;
            SwitchButtons(true);
        }

        #endregion

        /// <summary>
        /// Переключает доступность кнопок
        /// </summary>
        /// <param name="tf">Истина для включения, ложь для выключения</param>
        private void SwitchButtons(bool tf)
        {
            btnAdd1.Enabled = tf;
            btnX2.Enabled = tf;
            btnReset.Enabled = tf;
            btnCancel.Enabled = tf;
        }

        /// <summary>
        /// Обновляет надписи на форме
        /// </summary>
        private void RefreshData()
        {
            // можно убрать. реализовано через привязку!
            //lblTarget.Text = doubler.Target.ToString();
            //lblGross.Text = doubler.Gross.ToString();
            //lblSteps.Text = doubler.StepCount.ToString();

            CheckGameOver();
        }

        /// <summary>
        /// Проверяет окончание игры
        /// </summary>
        private void CheckGameOver()
        {
            int res = doubler.CheckTarget();
            if (res < 0)
            {
                lblGameOverNot.Text = "Вы проиграли...";
                lblGameOverNot.Visible = true;
                SwitchButtons(false);
            }
            else if (res == 0)
            {
                lblGameOverNot.Text = "Вы победили!!!";
                lblGameOverNot.Visible = true;
                SwitchButtons(false);
            }
        }

        #region Обработчики нажатия кнопок

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            doubler.Add();
            RefreshData();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            doubler.X2();
            RefreshData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.ResetGrossCount();
            RefreshData();
        }

        private void btnTopList_Click(object sender, EventArgs e)
        {
            doubler.Back();
            RefreshData();
        }

        #endregion
    }
}
