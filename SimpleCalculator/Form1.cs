using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Add";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Add";
                label1.Text = calculator.Log;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (calculator.AnswerNumber == null)
            {
                calculator.AnswerNumber = int.Parse(textBox2.Text);
            }
        }
        private void Addition_Click(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Add";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Add";
                label1.Text = calculator.Log;
            }
        }
        private void Subtraction_Click(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Subtract";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Subtract";
                label1.Text = calculator.Log;
            }
        }
        private void Multiplication_Click(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Multiply";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Multiply";
                label1.Text = calculator.Log;
            }

        }
        private void Division_Click(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Divide";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Divide";
                label1.Text = calculator.Log;
            }
        }

        static Calculator calculator = new Calculator();
        public class Calculator
        {
            public string Log { get; set; }
            public int? AnswerNumber { get; set; }
            public string Mode { get; set; }
            public string Addition(int n)
            {
                AnswerNumber = AnswerNumber + n;
                string result = "" + AnswerNumber;
                Log = Log + "+" + n;
                return result;
            }
            public string Subtraction(int n)
            {
                AnswerNumber = AnswerNumber - n;
                string result = "" + AnswerNumber;
                Log = Log + "-" + n;
                return result;
            }
            public string Multiplication(int n)
            {
                AnswerNumber = AnswerNumber * n;
                string result = "" + AnswerNumber;
                Log = Log + "x" + n;
                return result;
            }
            public string Division(int n)
            {
                AnswerNumber = AnswerNumber / n;
                string result = "" + AnswerNumber;
                Log = Log + "/" + n;
                return result;
            }
            public string MakeBinary(int n)
            {
                string result = "";
                while (n > 0)
                {
                    int reminder = n % 2;
                    result = reminder + result;
                    n = n / 2;
                }
                return result;
            }
            public string FromBinary(int n)
            {
                int decimalVal = 0;
                int baseVal = 1;
                int rem;
                string result = "";
                while (n > 0)
                {
                    rem = n % 10;
                    decimalVal = decimalVal + rem * baseVal;
                    n = n / 10;
                    baseVal = baseVal * 2;
                    result = result + decimalVal;
                }
                return result;
            }
            public void Answer(int n)
            {
                if (Mode == "Add")
                {
                    Addition(n);
                }
                else if (Mode == "Subtract")
                {
                    Subtraction(n);
                }
                else if (Mode == "Multiply")
                {
                    Multiplication(n);
                }
                else if (Mode == "Divide")
                {
                    Division(n);
                }
                else
                {
                    Log = Log + AnswerNumber;
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            if (calculator.Mode == null)
            {
                calculator.Mode = "Add";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Add";
                label1.Text = calculator.Log;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Subtraction_Click_1(object sender, EventArgs e)
        {
            if (calculator.Mode == null)
            {
                calculator.Mode = "Subtract";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Subtract";
                label1.Text = calculator.Log;
            }
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (calculator.AnswerNumber == null)
            {
                calculator.AnswerNumber = int.Parse(textBox2.Text);
            }
        }

        private void Multiplication_Click_1(object sender, EventArgs e)
        {
            if (calculator.Mode == null)
            {
                calculator.Mode = "Multiply";
            }
            else
            {
                calculator.Answer(int.Parse(textBox2.Text));
                calculator.Mode = "Multiply";
                label1.Text = calculator.Log;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Text = calculator.FromBinary(int.Parse(textBox2.Text));

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label2.Text = calculator.MakeBinary(int.Parse(textBox2.Text));
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            calculator.Answer(int.Parse(textBox2.Text));
            label1.Text = calculator.Log + calculator.AnswerNumber;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calculator.Mode = null;
            calculator.AnswerNumber = null;
            calculator.Log = null;
            label1.Text = calculator.Log;
            label2.Text = null;
        }
    }
}
