using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ClassLibrary;

namespace Lab7
{
    public partial class Calculadora : Form
    {
        //public Operations operations;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (box.Text == "0")
            {
                box.Text = num.Text;
            }
            else
            {
                box.Text += num.Text;
            }
            
        }

        private void AC_Click(object sender, EventArgs e)
        {
            box.Text = "0";
        }

        private void del_Click(object sender, EventArgs e)
        {
            box.Text = box.Text.Substring(0, box.Text.Length - 1);
        }
    }
}
