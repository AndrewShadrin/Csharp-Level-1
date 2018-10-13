namespace Lesson_7
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGross = new System.Windows.Forms.Label();
            this.doublerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSteps = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игратьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGrossText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblGameOverNot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doublerBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd1
            // 
            this.btnAdd1.Enabled = false;
            this.btnAdd1.Location = new System.Drawing.Point(290, 39);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 0;
            this.btnAdd1.Text = "+1";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnX2
            // 
            this.btnX2.Enabled = false;
            this.btnX2.Location = new System.Drawing.Point(290, 68);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(75, 23);
            this.btnX2.TabIndex = 0;
            this.btnX2.Text = "x2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(290, 97);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(290, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnTopList_Click);
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doublerBindingSource, "Gross", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.lblGross.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGross.Location = new System.Drawing.Point(208, 68);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(14, 20);
            this.lblGross.TabIndex = 1;
            this.lblGross.Text = "-";
            // 
            // doublerBindingSource
            // 
            this.doublerBindingSource.DataSource = typeof(Lesson_7.Doubler);
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doublerBindingSource, "StepCount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSteps.Location = new System.Drawing.Point(208, 97);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(14, 20);
            this.lblSteps.TabIndex = 1;
            this.lblSteps.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.игратьToolStripMenuItem.Text = "Игра";
            // 
            // игратьToolStripMenuItem1
            // 
            this.игратьToolStripMenuItem1.Name = "игратьToolStripMenuItem1";
            this.игратьToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.игратьToolStripMenuItem1.Text = "Играть";
            this.игратьToolStripMenuItem1.Click += new System.EventHandler(this.игратьToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // lblGrossText
            // 
            this.lblGrossText.AutoSize = true;
            this.lblGrossText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrossText.Location = new System.Drawing.Point(12, 68);
            this.lblGrossText.Name = "lblGrossText";
            this.lblGrossText.Size = new System.Drawing.Size(190, 20);
            this.lblGrossText.TabIndex = 1;
            this.lblGrossText.Text = "Накопленное значение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество ходов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Целевое значение:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doublerBindingSource, "Target", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTarget.Location = new System.Drawing.Point(208, 39);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(14, 20);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "-";
            // 
            // lblGameOverNot
            // 
            this.lblGameOverNot.AutoSize = true;
            this.lblGameOverNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOverNot.Location = new System.Drawing.Point(67, 126);
            this.lblGameOverNot.Name = "lblGameOverNot";
            this.lblGameOverNot.Size = new System.Drawing.Size(155, 24);
            this.lblGameOverNot.TabIndex = 3;
            this.lblGameOverNot.Text = "Игра окончена";
            this.lblGameOverNot.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 167);
            this.Controls.Add(this.lblGameOverNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGrossText);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Удвоитель\"";
            ((System.ComponentModel.ISupportInitialize)(this.doublerBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label lblGrossText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.BindingSource doublerBindingSource;
        private System.Windows.Forms.Label lblGameOverNot;
    }
}

