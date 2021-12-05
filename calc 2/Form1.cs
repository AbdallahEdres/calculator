using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_2
{
    public partial class Form1 : Form
    {
        // this function does the operation
        public string _equal(double num1, double num2, string op)
        {
            if (num1 == 0 && op == "/")
            {
                return "Can't divide by ZERO!!";
            }
            else
            {
                switch (op)
                {
                    case "+":
                        num2 = num2 + num1;
                        return Convert.ToString(num2);


                    case "-":
                        num2 = num2 - num1;
                        return Convert.ToString(num2);

                    case "x":
                        num2 = num2 * num1;
                        return Convert.ToString(num2);

                    case "/":

                        num2 = num2 / num1;

                        return Convert.ToString(num2);

                }
                return Convert.ToString(num2);
            }
        }

        double num1, num2=0;
        string op="+";
        public Form1()
        {
            InitializeComponent();
            result_txt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void dot_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += ".");
            result_txt.Focus();
        }
        //operators when pressed does the previos one then changes the op
        private void plus_but_Click(object sender, EventArgs e)
        {
            result_txt.Text = _equal(num1, num2, op);
            if (result_txt.Text == "Can't divide by ZERO!!")
            {
                lable.Text = "Can't divide by ZERO!!";
                result_txt.Text = null;
                op = "+";
                num1 = 0;
            }
            else
            if (result_txt.Text != null)
            {
               
                num2 = Convert.ToDouble(result_txt.Text);
                op = "+";
                lable.Text = Convert.ToString(num2);
                result_txt.Text = null;
                op_lable.Text = "+";
                num1 = 0;
            }
            result_txt.Focus();
        }

        private void minus_but_Click(object sender, EventArgs e)
        {
            result_txt.Text = _equal(num1, num2, op);
            if (result_txt.Text == "Can't divide by ZERO!!")
            {
                lable.Text = "Can't divide by ZERO!!";
                result_txt.Text = null;
                op = "-";
                num1 = 0;
            }
            else
            if (result_txt.Text != null)
            {

                num2 = Convert.ToDouble(result_txt.Text);
                op = "-";
                lable.Text = Convert.ToString(num2);
                result_txt.Text = null;
                op_lable.Text = "-";
                num1 = 0;
            }
            result_txt.Focus();
        }

        private void mult_but_Click(object sender, EventArgs e)
        {
            result_txt.Text = _equal(num1, num2, op);
            if (result_txt.Text == "Can't divide by ZERO!!")
            {
                lable.Text = "Can't divide by ZERO!!";
                result_txt.Text = null;
                op = "x";
                num1 = 0;
            }
            else
            if (result_txt.Text != null)
            {

                num2 = Convert.ToDouble(result_txt.Text);
                op = "x";
                lable.Text = Convert.ToString(num2);
                result_txt.Text = null;
                op_lable.Text = "X";
                num1 = 0;
            }
            result_txt.Focus();
        }

        private void div_but_Click(object sender, EventArgs e)
        {
            result_txt.Text = _equal(num1, num2, op);
            if (result_txt.Text == "Can't divide by ZERO!!")
            {
                lable.Text = "Can't divide by ZERO!!";
                result_txt.Text = null;
                op = "/";
                num1 = 0;
            }
            else
            if (result_txt.Text != null)
            {

                num2 = Convert.ToDouble(result_txt.Text);
                op = "/";
                lable.Text = Convert.ToString(num2);
                result_txt.Text = null;
                op_lable.Text = "/";
                num1 = 0;
            }
            result_txt.Focus();
        }

        private void percent_but_Click(object sender, EventArgs e)
        {
            if (op == "/" || op == "x")
            {
                num1 = (num1 / 100);
            }
            else
            {
                num1 = (num1 / 100) * num2;
            }
            num2 = Convert.ToDouble( _equal(num1, num2, op));
            lable.Text = Convert.ToString(num2);
            result_txt.Text = null;
            op = "";
            op_lable.Text = "";

            result_txt.Focus();
        }
        //delet one number
        private void backspace_but_Click(object sender, EventArgs e)
        {
            if (op_lable.Text != "=")
            {
                if (result_txt.Text.Length > 1)
                {
                    result_txt.Text = result_txt.Text.Remove(result_txt.Text.Length - 1, 1);
                    num1 = Convert.ToDouble(result_txt.Text);
                }
                else
                {
                    result_txt.Text = null;
                    num1 = 0;
                }
            }
            result_txt.Focus();
        }
        private void equal_but_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(_equal(num1, num2, op));
            result_txt.Text = Convert.ToString(num2);
            lable.Text= Convert.ToString(num2);
            num1 = 0;
            op_lable.Text = "=";
            op = null;
            result_txt.Focus();
        }

        private void clear_but_Click(object sender, EventArgs e)
        {
            lable.Text = null;
            result_txt.Text = null;
            num2 = 0;
            num1 = 0;
            op = "+";
            op_lable.Text = " ";
            num2= Convert.ToDouble(_equal(num1, num2, op));
            result_txt.Focus();
        }
        //num buttons
        private void num1_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "1");
            result_txt.Focus();
        }

        private void num2_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "2");
            result_txt.Focus();
        }

        private void num3_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "3");
            result_txt.Focus();
        }



        private void num4_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "4");
            result_txt.Focus();
        }

        private void num5_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "5");
            result_txt.Focus();
        }

        private void num6_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "6");
            result_txt.Focus();
        }

        private void num7_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "7");
            result_txt.Focus();
        }

        private void num8_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "8");
            result_txt.Focus();

        }

        private void num9_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "9");
            result_txt.Focus();

        }

        private void result_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.NumPad0)
            {
                num1 = Convert.ToDouble(result_txt.Text += "0");
            }
            else
                if (e.KeyCode == Keys.NumPad1)
            {
                num1 = Convert.ToDouble(result_txt.Text += "1");
            }
            else
                if (e.KeyCode == Keys.NumPad2)
            {
                num1 = Convert.ToDouble(result_txt.Text += "2");
            }
            else
                if (e.KeyCode == Keys.NumPad3)
            {
                num1 = Convert.ToDouble(result_txt.Text += "3");
            }
            else
                if (e.KeyCode == Keys.NumPad4)
            {
                num1 = Convert.ToDouble(result_txt.Text += "4");
            }
            else
                if (e.KeyCode == Keys.NumPad5)
            {
                num1 = Convert.ToDouble(result_txt.Text += "5");
            }
            else
                if (e.KeyCode == Keys.NumPad6)
            {
                num1 = Convert.ToDouble(result_txt.Text += "6");
            }
            else
                if (e.KeyCode == Keys.NumPad7)
            {
                num1 = Convert.ToDouble(result_txt.Text += "7");
            }
            else
                if (e.KeyCode == Keys.NumPad8)
            {
                num1 = Convert.ToDouble(result_txt.Text += "8");
            }
            else
                if (e.KeyCode == Keys.NumPad9)
            {
                num1 = Convert.ToDouble(result_txt.Text += "9");
            }
            else
                if (e.KeyCode == Keys.Multiply)
            {
               
            }
            else
                if (e.KeyCode == Keys.Back)
            {
                
            }
            else
                if (e.KeyCode == Keys.Add)
            {
                
            }
            else
                if (e.KeyCode == Keys.Divide)
            {
                
            }
            else
                if (e.KeyCode == Keys.Escape)
            {
                
            }
            else
                if (e.KeyCode == Keys.Subtract)
            {
                
            }
        }

        private void num0_but_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(result_txt.Text += "0");
            result_txt.Focus();
        }
    }
}
