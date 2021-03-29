using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtA.Text != String.Empty)
=======
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
>>>>>>> 634a976edcbf2c769d5dd90b16a0a3155b150e0c
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKetQua.Text = c.ToString();
            }
        }
    }
}
