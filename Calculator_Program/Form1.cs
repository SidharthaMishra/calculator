using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Program
{
    public partial class Form1 : Form
    {
        private int choice;
        private double num1;
        private double num2;
        private double result;
        private string str;
        private bool flag;

        public Form1()
        {
            InitializeComponent();
            choice = 0;
            num1 = 0;
            num2 = 0;
            result = 0;
            str = " ";
            flag = false;
        }

        private double add(double n1, double n2)
        {
            return n1 + n2;
        }

        private double sub(double n1, double n2)
        {
            return n1 - n2;
        }

        private double mult(double n1, double n2)
        {
            return n1 * n2;
        }

        private double div(double n1, double n2)
        {
            return n1 / n2;
        }


        private void button17_Click(object sender, EventArgs e)
        {
            //EQUAL BUTTON

            //Error Handling: Make sure the textbox is not empty
            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text.ToString();
                num2 = double.Parse(str);
                this.textBox1.Clear();
            }


            switch (choice)
            {
                case 1:
                    //add
                    result=add(num1, num2);
                    this.textBox1.Text = result.ToString();
                    break;
                case 2:
                    //sub
                    result = sub(num1, num2);
                    this.textBox1.Text = result.ToString();
                    break;
                case 3:
                    //mult
                    result = mult(num1, num2);
                    this.textBox1.Text = result.ToString();
                    break;
                case 4:
                    //div
                    result = div(num1, num2);
                    this.textBox1.Text = result.ToString();
                    break;
                default:
                    //reset
                    reset();
                    break;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Add Button
            choice = 1;

            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text.ToString();
                num1 = double.Parse(str);
            }

            this.textBox1.Clear();
            this.textBox1.Text = "+";
            this.textBox1.Clear();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            //Subtract Button
            choice = 2;

            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text.ToString();
                num1 = double.Parse(str);
            }

            this.textBox1.Clear();
            this.textBox1.Text = "-";
            this.textBox1.Clear();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            //Multiplication Button
            choice = 3;

            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text.ToString();
                num1 = double.Parse(str);
            }

            this.textBox1.Clear();
            this.textBox1.Text = "x";
            this.textBox1.Clear();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            //Division Button
            choice = 4;

            if (this.textBox1.Text.Length > 0)
            {
                str = this.textBox1.Text.ToString();
                num1 = double.Parse(str);
            }

            this.textBox1.Clear();
            this.textBox1.Text = "/";
            this.textBox1.Clear();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 Button
            this.textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2 Button
            this.textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //3 Button
            this.textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4 Button
            this.textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5 Button
            this.textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6 Button
            this.textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //7 Button
            this.textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //8 Button
            this.textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //9 Button
            this.textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //DECIMAL Button
            this.textBox1.AppendText(".");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ZERO Button
            this.textBox1.AppendText("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //+/- Button
            
            if (flag == false)
            {
                if (this.textBox1.Text.Length <= 0)
                {
                    this.textBox1.AppendText("-");
                    flag = true;
                }
            
            }
            else
            {
                this.textBox1.Clear();
                flag = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            reset();
        }
        
        private void reset()
        {
            this.textBox1.Clear();
            num1 = 0;
            num2 = 0;
            str = " ";
            result = 0;
            flag = false;
            choice = 0;
        }

    }

}
