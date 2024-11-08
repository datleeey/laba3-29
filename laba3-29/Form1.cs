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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одномірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 oneDimForm = new Form2();
            oneDimForm.Show();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 twoDimForm = new Form3();
            twoDimForm.Show();
        }
    }
}
