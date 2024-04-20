using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet4.Q4
{
    public partial class Form1 : Form
    {
        string operation = "";
        double result_value = 0;
        bool is_Operation_Performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || is_Operation_Performed)
            {
                Result.Clear(); // clear initiol value
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!Result.Text.Contains("."))
                {
                    Result.Text = Result.Text + btn.Text;
                }
            }
            else
            {
                Result.Text = Result.Text + btn.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
                if (result_value != 0)
                {
                    button16.PerformClick();
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(Result.Text);
                    lb_Result.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
                else
                {
                    Button btn = (Button)sender;
                    operation = btn.Text;
                    result_value = double.Parse(Result.Text);
                    lb_Result.Text = result_value + operation;
                    is_Operation_Performed = true;
                }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
                switch (operation)
                {
                    case "+":

                        Result.Text = (result_value + double.Parse(Result.Text)).ToString(); break;

                case "-": 
                        Result.Text = (result_value - double.Parse(Result.Text)).ToString(); break;

                case "*":

                    Result.Text = (result_value * double.Parse(Result.Text)).ToString(); break;

                case "/":

                        //if (double.Parse(Result.Text) = 0)



                    Result.Text = (result_value / double.Parse(Result.Text)).ToString(); break;
                 }
                
            }
    }

    public class Calculator
    {

    }
}
