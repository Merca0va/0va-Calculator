using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_Calculator
{
    public partial class Form1 : Form
    {
        private string operand1;
        private string operand2;
        private string my_operator;
        private readonly string temp_string;
        double my_result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            my_operator = null;
            Display.Text = "0";

        }


        private void Display_Click(object sender, EventArgs e)
        {

        }

        public void concatenate_display(string X)
        {
            if (Display.Text != "0" && Display.Text != operand1)
            {
                Display.Text = Display.Text + X;
            }

            else 
            {
                length_limit();
                Display.Text = X;
            }
        }

        public void length_limit()
        {
            if (Display.Text.Length >= 33)
            {
                Console.Beep();
                MessageBox.Show("Your number is too long", "Too long");
            }
        }

        public void Op_Click(String this_operator)
        {
            if (operand1 == null)
            {
                operand1 = Display.Text;
                operand2 = null;
            }

            else if (operand2 == null)
            {
                operand2 = Display.Text;
                operand1 = Convert.ToString(Calculate_Result());
                Display.Text = operand1;
                operand2 = null;
            }
            my_operator = this_operator;
        }

        public ref double Calculate_Result()
        {
            if (my_operator == "+")
            {
                my_result = Convert.ToDouble(operand1) + Convert.ToDouble(operand2);
            }

            else if (my_operator == "-")
            {
                my_result = Convert.ToDouble(operand1) - Convert.ToDouble(operand2);
            }

            else if (my_operator == "x")
            {
                my_result = Convert.ToDouble(operand1) * Convert.ToDouble(operand2);
            }

            else if (my_operator == "÷")
            {
                my_result = Convert.ToDouble(operand1) / Convert.ToDouble(operand2);
            }

            else if (my_operator == "%")
            {
                my_result = Convert.ToDouble(operand1) % Convert.ToDouble(operand2);
            }

            return ref my_result;
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            concatenate_display("1");
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            concatenate_display("2");
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            concatenate_display("3");
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            concatenate_display("4");
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            concatenate_display("5");
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            concatenate_display("6");
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            concatenate_display("7");
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            concatenate_display("8");
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            concatenate_display("9");
        }

        private void Button_0_Click(object sender, EventArgs e)
        {
            concatenate_display("0");
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            operand1 = null;
            operand2 = null;
            my_operator = null;
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0" && Display.Text.Length > 1)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }

            else
            {
                Display.Text = "0";
                operand1 = null;
                operand2 = null;
                my_operator = null;
            }
        }

        private void Button_substraction_Click(object sender, EventArgs e)
        {
            Op_Click("-");         
        }

        private void Button_multiplication_Click(object sender, EventArgs e)
        {
            Op_Click("x");
        }

        private void Button_addition_Click(object sender, EventArgs e)
        {
            Op_Click("+");        
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            if (operand2 == null)
            {
                operand2 = Display.Text;
            }

            Display.Text = Convert.ToString(Calculate_Result());
            operand1 = null;
            operand2 = null;
            my_operator = null;
        }

        private void Button_mod_Click(object sender, EventArgs e)
        {
            Op_Click("%");
        }

        private void Button_dot_Click(object sender, EventArgs e)
        {
            concatenate_display(".");
        }

        private void Button_division_Click(object sender, EventArgs e)
        {
            Op_Click("÷");
        }

       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Display.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
