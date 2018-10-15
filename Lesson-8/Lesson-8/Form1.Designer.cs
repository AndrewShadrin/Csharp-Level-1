namespace Task3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBxFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnFileName = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.checkBoxXML = new System.Windows.Forms.CheckBox();
            this.checkBoxJSON = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxXMLSave = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBxFileName
            // 
            this.tBxFileName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Lesson_8.Properties.Settings.Default, "FileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tBxFileName.Location = new System.Drawing.Point(211, 50);
            this.tBxFileName.Name = "tBxFileName";
            this.tBxFileName.ReadOnly = true;
            this.tBxFileName.Size = new System.Drawing.Size(400, 20);
            this.tBxFileName.TabIndex = 0;
            this.tBxFileName.Text = global::Lesson_8.Properties.Settings.Default.FileName;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(33, 53);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(172, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Имя файла для преобразования";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(618, 50);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(24, 19);
            this.btnFileName.TabIndex = 2;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.Filter = "Файлы csv|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(519, 106);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(92, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Ковертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // checkBoxXML
            // 
            this.checkBoxXML.AutoSize = true;
            this.checkBoxXML.Location = new System.Drawing.Point(211, 110);
            this.checkBoxXML.Name = "checkBoxXML";
            this.checkBoxXML.Size = new System.Drawing.Size(123, 17);
            this.checkBoxXML.TabIndex = 4;
            this.checkBoxXML.Text = "XML сериализация";
            this.checkBoxXML.UseVisualStyleBackColor = true;
            // 
            // checkBoxJSON
            // 
            this.checkBoxJSON.AutoSize = true;
            this.checkBoxJSON.Location = new System.Drawing.Point(394, 110);
            this.checkBoxJSON.Name = "checkBoxJSON";
            this.checkBoxJSON.Size = new System.Drawing.Size(54, 17);
            this.checkBoxJSON.TabIndex = 4;
            this.checkBoxJSON.Text = "JSON";
            this.checkBoxJSON.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Укажите формат преобразования";
            // 
            // checkBoxXMLSave
            // 
            this.checkBoxXMLSave.AutoSize = true;
            this.checkBoxXMLSave.Location = new System.Drawing.Point(340, 110);
            this.checkBoxXMLSave.Name = "checkBoxXMLSave";
            this.checkBoxXMLSave.Size = new System.Drawing.Size(48, 17);
            this.checkBoxXMLSave.TabIndex = 4;
            this.checkBoxXMLSave.Text = "XML";
            this.checkBoxXMLSave.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(91, 79);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(114, 13);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Путь для сохранения";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(211, 76);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.ReadOnly = true;
            this.txtBoxPath.Size = new System.Drawing.Size(400, 20);
            this.txtBoxPath.TabIndex = 7;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(619, 76);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(22, 19);
            this.btnPath.TabIndex = 8;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 161);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxJSON);
            this.Controls.Add(this.checkBoxXMLSave);
            this.Controls.Add(this.checkBoxXML);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.tBxFileName);
            this.Name = "Form1";
            this.Text = "CSV converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBxFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox checkBoxXML;
        private System.Windows.Forms.CheckBox checkBoxJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxXMLSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnPath;
    }
}

