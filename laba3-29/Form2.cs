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
    public partial class Form2 : Form
    {
        private int[] array;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                array = GenerateRandomArray(n);
                DisplayArray(dataGridView1, array);
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне значення для N.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *= 2;
                }
                DisplayArray(dataGridView1, array);
            }
            else
            {
                MessageBox.Show("Спочатку потрібно згенерувати масив.");
            }
        }

        private int[] GenerateRandomArray(int n)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 101);
            }
            return arr;
        }

        private void DisplayArray(DataGridView dataGridView, int[] array)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.ColumnCount = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView.Columns[i].Name = $"Індекс {i}";
                dataGridView.Columns[i].Width = 60;
            }
            dataGridView.Rows.Add(array.Cast<object>().ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
