using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

/// <summary>
/// 3. *Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
/// Выполнил Шадрин Андрей
/// </summary>
namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tBxFileName.Text = openFileDialog1.FileName;
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            List<Student> list = StudentManager.CreateStudents(tBxFileName.Text);
            StudentManager.XMLSerialize(list, "students_6.xml");
            StudentManager.SaveToXML(list, "students_6_1.xml");
            StudentManager.SaveToJSON(list, "students_6_2.json");
        }

    }
}
