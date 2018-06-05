namespace rgr
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calcbtn = new System.Windows.Forms.Button();
            this.ResultMinuteBox = new System.Windows.Forms.TextBox();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.FormulaLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YBox = new System.Windows.Forms.TextBox();
            this.XBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Calcbtn_2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.StatisticLabel = new System.Windows.Forms.Label();
            this.ArrayLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelSumm = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.Controls.Add(this.tabPage5);
            this.TabControl1.Location = new System.Drawing.Point(0, 1);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(495, 306);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Calcbtn);
            this.tabPage1.Controls.Add(this.ResultMinuteBox);
            this.tabPage1.Controls.Add(this.MinuteBox);
            this.tabPage1.Controls.Add(this.HourBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OOP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Всего минут";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество минут";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество часов";
            // 
            // Calcbtn
            // 
            this.Calcbtn.Location = new System.Drawing.Point(305, 70);
            this.Calcbtn.Name = "Calcbtn";
            this.Calcbtn.Size = new System.Drawing.Size(140, 93);
            this.Calcbtn.TabIndex = 3;
            this.Calcbtn.Text = "Расчитать";
            this.Calcbtn.UseVisualStyleBackColor = true;
            this.Calcbtn.Click += new System.EventHandler(this.Calcbtn_Click);
            // 
            // ResultMinuteBox
            // 
            this.ResultMinuteBox.Location = new System.Drawing.Point(24, 207);
            this.ResultMinuteBox.Name = "ResultMinuteBox";
            this.ResultMinuteBox.ReadOnly = true;
            this.ResultMinuteBox.Size = new System.Drawing.Size(139, 20);
            this.ResultMinuteBox.TabIndex = 2;
            // 
            // MinuteBox
            // 
            this.MinuteBox.Location = new System.Drawing.Point(24, 121);
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(139, 20);
            this.MinuteBox.TabIndex = 1;
            this.MinuteBox.Text = "0";
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(24, 41);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(139, 20);
            this.HourBox.TabIndex = 0;
            this.HourBox.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.FormulaLabel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.YBox);
            this.tabPage2.Controls.Add(this.XBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Calcbtn_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormulaLabel
            // 
            this.FormulaLabel.AutoSize = true;
            this.FormulaLabel.Location = new System.Drawing.Point(29, 196);
            this.FormulaLabel.Name = "FormulaLabel";
            this.FormulaLabel.Size = new System.Drawing.Size(0, 13);
            this.FormulaLabel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Использованная формула:";
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(32, 111);
            this.YBox.Name = "YBox";
            this.YBox.ReadOnly = true;
            this.YBox.Size = new System.Drawing.Size(100, 20);
            this.YBox.TabIndex = 4;
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(32, 53);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(100, 20);
            this.XBox.TabIndex = 3;
            this.XBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // Calcbtn_2
            // 
            this.Calcbtn_2.Location = new System.Drawing.Point(287, 53);
            this.Calcbtn_2.Name = "Calcbtn_2";
            this.Calcbtn_2.Size = new System.Drawing.Size(144, 121);
            this.Calcbtn_2.TabIndex = 0;
            this.Calcbtn_2.Text = "Расчитать";
            this.Calcbtn_2.UseVisualStyleBackColor = true;
            this.Calcbtn_2.Click += new System.EventHandler(this.Calcbtn_2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.StatisticLabel);
            this.tabPage3.Controls.Add(this.ArrayLabel);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(487, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Array";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // StatisticLabel
            // 
            this.StatisticLabel.AutoSize = true;
            this.StatisticLabel.Location = new System.Drawing.Point(58, 116);
            this.StatisticLabel.Name = "StatisticLabel";
            this.StatisticLabel.Size = new System.Drawing.Size(0, 13);
            this.StatisticLabel.TabIndex = 2;
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Location = new System.Drawing.Point(58, 62);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(0, 13);
            this.ArrayLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelSumm);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.table);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(487, 280);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Array 2D";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelSumm
            // 
            this.labelSumm.AutoSize = true;
            this.labelSumm.Location = new System.Drawing.Point(8, 237);
            this.labelSumm.Name = "labelSumm";
            this.labelSumm.Size = new System.Drawing.Size(89, 13);
            this.labelSumm.TabIndex = 2;
            this.labelSumm.Text = "Сумма колонок:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Расчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.table.Location = new System.Drawing.Point(8, 9);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(231, 225);
            this.table.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.Width = 30;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.InputBox);
            this.tabPage5.Controls.Add(this.OutputLabel);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(487, 280);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "String";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 92);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(30, 172);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 13);
            this.OutputLabel.TabIndex = 1;
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(33, 80);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Входная строка:";
            this.label8.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Выходная строка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(403, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "(Внимание, вводите без пробелов. В случае наличия, пробелы будут удалены)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 308);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcbtn;
        private System.Windows.Forms.TextBox ResultMinuteBox;
        private System.Windows.Forms.TextBox MinuteBox;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calcbtn_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FormulaLabel;
        private System.Windows.Forms.Label StatisticLabel;
        private System.Windows.Forms.Label ArrayLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labelSumm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

