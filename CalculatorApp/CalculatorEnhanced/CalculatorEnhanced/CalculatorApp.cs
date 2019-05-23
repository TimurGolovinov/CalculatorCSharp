using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//m228724
//Golovinov Timur
//21/05/2019
//Version 1.0
//This is a calculator app that uses 3 custom libraries for math, algebra and trigonometry functions.
namespace CalculatorEnhanced
{
    public partial class CalculatorApp : Form
    {
        //calculator variables
        double operand = 0;// first operand
        string operation;//string for operation
        double result = 0.0;//Calculated Result

        public CalculatorApp()
        {
            InitializeComponent();
        }
        //Buttons 0-9
        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button9.Text;
        }

        //Button CLEAR
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            this.operand = 0;
        }

        // Button point
        private void buttonDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        //plus button
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operand = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        //minus button
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                operand += double.Parse(txtDisplay.Text);
                operation = "-";
                txtDisplay.Clear();
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "-";
            }


        }
        //multiply button
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();

        }
        //divide button
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();

        }
        //Square Root Button
        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "sqrt";
            txtDisplay.Clear();

        }
        //Cube root button
        private void buttonCubeRoot_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "cuberoot";
            txtDisplay.Clear();
        }
        //Sin button
        private void buttonSin_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "sin";
            txtDisplay.Clear();
        }
        //Cos button
        private void buttonCos_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "cos";
            txtDisplay.Clear();
        }
        //Tan button
        private void buttonTan_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "tan";
            txtDisplay.Clear();
        }
        //Inverse Button
        private void buttonInverse_Click(object sender, EventArgs e)
        {
            operand += double.Parse(txtDisplay.Text);
            operation = "inv";
            txtDisplay.Clear();
            if (operand != 0)//check is input not zero
            {
                result = Algebra.Algebra.Inverse((int)operand);
                txtDisplay.Text = result.ToString();
                operand += double.Parse(txtDisplay.Text);
            }
            else
            {
                txtDisplay.Text = "Cannot Reverse Zero";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": //plus is pressed - go to related library and use appropriate function
                    result = BasicMath.Arithmetic.Add((int)operand, int.Parse(txtDisplay.Text));
                    txtDisplay.Text = result.ToString();
                    break;
                case "-"://minus is pressed - go to related library and use appropriate function
                    result = BasicMath.Arithmetic.Sub((int)operand, int.Parse(txtDisplay.Text));
                    txtDisplay.Text = result.ToString();
                    break;
                case "*"://multiply is pressed - go to related library and use appropriate function
                    result = BasicMath.Arithmetic.Mult((int)operand, int.Parse(txtDisplay.Text));
                    txtDisplay.Text = result.ToString();
                    break;
                case "/"://divide is pressed - go to related library and use appropriate function
                    if (int.Parse(txtDisplay.Text) != 0)//check is input not zero
                    {
                        result = BasicMath.Arithmetic.Div((int)operand, int.Parse(txtDisplay.Text));
                        txtDisplay.Text = result.ToString();
                    }
                    else
                    {
                        txtDisplay.Text = "DIV/ZERO ERR";
                    }
                    break;
                case "sqrt"://square root is pressed - go to related library and use appropriate function
                    if (operand > 0)//check if input is more than zero
                    {
                        txtDisplay.Text = Algebra.Algebra.Sqrt(operand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number must be positive", "Error Message");
                        txtDisplay.Text = "0";
                    }
                    break;
                case "cuberoot"://cube root is pressed - go to related library and use appropriate function

                    if (operand >= 0)//check if input is more than zero
                    {
                        txtDisplay.Text = Algebra.Algebra.CubicRoot(operand).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number must be positive", "Error Message");
                        txtDisplay.Text = "0";
                    }
                    break;
                case "sin"://sin is pressed - go to related library and use appropriate function
                    result = Trigonometry.Trigonometry.Sine(operand * (Math.PI / 180.0));
                    txtDisplay.Text = result.ToString();
                    break;
                case "cos"://cos is pressed - go to related library and use appropriate function
                    result = Trigonometry.Trigonometry.Cosine(operand * (Math.PI / 180.0));
                    txtDisplay.Text = result.ToString();
                    break;
                case "tan"://tan is pressed - go to related library and use appropriate function
                    if (operand % 90 != 0)//Number cannot be divisible by 90 without descimals
                    {
                        result = Trigonometry.Trigonometry.Tan(operand * (Math.PI / 180.0)); //convert the value in degrees to radians:
                        txtDisplay.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Number cannot be divisible by 90 without descimals", "Error Message");
                        txtDisplay.Text = "0";
                    }
                    break;
                default:
                    break;
            }
            //clear the variables
            operand = 0;
            result = 0;
        }

        //method for menu exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
