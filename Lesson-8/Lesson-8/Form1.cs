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
            btnConvert.Enabled = true;
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            List<Student> list = StudentManager.CreateStudents(tBxFileName.Text);
            if (txtBoxPath.Text==String.Empty)
            {
                MessageBox.Show("Выберите каталог для сохранения", "Ошибка сохранения файлов");
                return;
            }
            string path = txtBoxPath.Text + "\\";
            if (checkBoxXML.Checked)
            {
                StudentManager.XMLSerialize(list, path + "students_6.xml");
            }
            if (checkBoxXMLSave.Checked)
            {
                StudentManager.SaveToXML(list, path + "students_6_1.xml");
            }
            if (checkBoxJSON.Checked)
            {
                StudentManager.SaveToJSON(list, path + "students_6_2.json");
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
