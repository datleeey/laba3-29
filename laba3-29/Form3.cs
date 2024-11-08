using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3_29
{
    public partial class Form3 : Form
    {
        private int[,] array;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && int.TryParse(textBox2.Text, out int m) && n > 0 && m > 0)
            {
                array = GenerateRandomArray(n, m);
                DisplayArray(dataGridView1, array);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для N та M.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                int sum = CalculateSumOfOddIndexedElements(array);
                label3.Text = $"Сума елементів: {sum}";
            }
            else
            {
                MessageBox.Show("Спочатку потрібно згенерувати масив.");
            }
        }

        private int[,] GenerateRandomArray(int n, int m)
        {
            Random rand = new Random();
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(1, 101); // Генерація чисел від 1 до 100
                }
            }
            return arr;
        }

        private void DisplayArray(DataGridView dataGridView, int[,] array)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            int columns = array.GetLength(1);
            for (int i = 0; i < columns; i++)
            {
                dataGridView.Columns.Add($"col{i}", $"Індекс {i}");
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                var row = new DataGridViewRow();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = array[i, j] });
                }
                dataGridView.Rows.Add(row);
            }
        }

        private int CalculateSumOfOddIndexedElements(int[,] array)
        {
            int sum = 0;
            for (int i = 1; i < array.GetLength(0); i += 2)
            {
                for (int j = 1; j < array.GetLength(1); j += 2)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
