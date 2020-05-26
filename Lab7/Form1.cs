using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace Lab7
{
    public partial class Calculadora : Form
    {
        private Operations operations = new Operations();
        private double Num1;
        private double Num2;
        private string Op;
        private double Result;
        private bool OpDone = false;

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
            if (box.Text == "0" || box.Text == "Syntax error" || box.Text == "Math error" || OpDone == true)
            {
                box.Text = num.Text;
                OpDone = false;
            }
            else
            {
                box.Text += num.Text;
            }
            
        }

        private void AC_Click(object sender, EventArgs e)
        {
            box.Text = "0";
            pre.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            box.Text = box.Text.Substring(0, box.Text.Length - 1);
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            Op = op.Text;
            try
            {
                Num1 = Convert.ToDouble(box.Text);
            }
            catch (Exception)
            {

                box.Text = "Syntax error";
            }
            box.Clear();
            pre.Text = $"{Num1} {Op} ";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                Num2 = Convert.ToDouble(box.Text);
            }
            catch (Exception)
            {
                box.Text = "Math error";
            }
            pre.Text += box.Text;
            if (Op == "/" && Num2 == 0)
            {
                box.Text = "Math error";
            }
            else
            {
                Result = operations.Op(Num1, Num2, Op);
                box.Text = $"{Result}";
                pre.Text = $"{Num1} {Op} {Num2}";
                Num2 = Result;
                OpDone = true;
            }
            
            /*
            if (Op == "+")
            {
                operations.Op(Num1, Num2, Op);
            }

            else if (Op == "-")
            {
                operations.Op(Num1, Num2, Op);
            }*/
        }

        private void ans_Click(object sender, EventArgs e)
        {
            try
            {
                box.Text = $"{Result}";
            }
            catch (Exception)
            {

            }
        }
    }
}
