using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgr
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();           
        }

        private void Calcbtn_Click(object sender, EventArgs e)
        {
            double minute = 0, hour = 0;

            if (HourBox.Text == "")
            {
                if (MinuteBox.Text == "")
                {
                    minute = 0;
                    hour = 0;
                }
                else
                {
                    hour = 0;
                    try
                    {
                        minute = Convert.ToDouble(MinuteBox.Text);                       
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong format");
                        ResultMinuteBox.Text = "Error";
                    }
                }            
                
            }

            if(MinuteBox.Text == "")
            {
                minute = 0;
                try
                {
                    hour = Convert.ToDouble(MinuteBox.Text);                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong format");
                    ResultMinuteBox.Text = "Error";
                }
            }
            
            ResultMinuteBox.Text = (minute + hour * 60).ToString();
            
        }

        private void Calcbtn_2_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;

            if (XBox.Text == "")
                x = 0;
            else
            {
                try
                {
                    x = Convert.ToDouble(XBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong format");
                    FormulaLabel.Text = " ";
                    YBox.Text = "Error";
                }
            }

            if (x >= 3)
            {
                y = x + 1;
                FormulaLabel.Text = "Y = X + 1";
            }
            else
            {
                if (x <= -12)
                {
                    y = 4 * x * x + 2 * x;
                    FormulaLabel.Text = "Y = 4X^2 + 2X";
                }
                else
                {
                    y = 2 * x * x + 2 * x;
                    FormulaLabel.Text = "Y = 2X^2 + 2X";
                }
            }


            YBox.Text = y.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int n = 20;
            int t = 0, k = 0;
            int[] array = new int[20];
            Array.Clear(array, 0, n);
            ArrayLabel.Text = "Array: ";
            
            for (int i = 0; i < array.Length; i++)
                array[i] = 10 - r.Next(20);

            foreach (int item in array)
                ArrayLabel.Text += item + "  ";

            for (int i = 0; i < array.Length; i++)
            {                
                    if (array[i] > 0)
                        t++;
                    if (array[i] < 0)
                        k++;         
            }
            StatisticLabel.Text = "Positiv: " + t + " Negativ: " + k;
            Form1.ActiveForm.Text = k.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.RowCount = 6;
            const int n = 5;
            int[,] matrix = new int[n, n];
            int ColumnSumm = 0;
            labelSumm.Text = "Сумма колонок: ";
            Array.Clear(matrix, 0, n);
            ArrayLabel.Text = "Array: ";

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = r.Next(20) - 10;
                    table[i, j].Value = matrix[i, j];
                }

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, 0] < 0)
                {
                    ColumnSumm = matrix[i, 0] + matrix[i, 1] + matrix[i, 2] + matrix[i, 3] + matrix[i, 4];
                    labelSumm.Text += ("Колонка №" + i + ": " + ColumnSumm + " ");
                    ColumnSumm = 0;
                }
            }
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string String;
            bool IsLastRemoved = false;
            
            String = InputBox.Text;
            int Length = String.Length;

            for (int i = 0; i < Length; i++)
            {
                if (String[i] >= 'a' && String[i] <= 'z')
                {
                    if (i + 1 != Length)
                    {
                        if (String[i + 1] >= 'a' && String[i + 1] <= 'z')
                        {
                            String = String.Remove(i, 1);
                            IsLastRemoved = true;
                            --i;
                            --Length;
                        }
                        else
                        {
                            if (IsLastRemoved == true)
                            {
                                String = String.Remove(i, 1);
                                IsLastRemoved = false;
                                --i;
                                --Length;
                            }
                        }
                    }
                }
                /*if (String[i] >= 'a' && String[i] <= 'z')
                {
                    if (String[i+1] >= 'a' && String[i+1] <= 'z')
                    {
                        String = String.Replace(String[i], ' ');
                        IsLastRemoved = true;
                    }
                    else
                    {
                        if (IsLastRemoved == true)
                        {
                            String = String.Replace(String[i], ' ');
                            IsLastRemoved = false;
                        }
                    }
                }
                */
            }
            String = String.Replace(" ", "");
            OutputLabel.Text = String;
        }
    }
}
