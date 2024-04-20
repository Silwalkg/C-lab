using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet4.q1
{
    public partial class Form1 : Form
    {
#pragma warning disable CS0649 // Field 'Form1.textBoxNumber1' is never assigned to, and will always have its default value null
        private object textBoxNumber1;
#pragma warning restore CS0649 // Field 'Form1.textBoxNumber1' is never assigned to, and will always have its default value null
        private object textBoxNumber2;

        public Form1()
        {
            InitializeComponent();
        }

        public object LabelResult { get; private set; }
        public object FirstNumber { get; private set; }
        public object SecondNumber { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the input valus from the textbpxes
            int num1, num2;
            try
            {
                num1 = int.Parse(textBox1.Text);
                num2 = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                //Handle the case where the user enters non-numeric characters
                MessageBox.Show("Please enter void numbers!");
                return;
            }
            //Calculate the sum
            int sum = num1 + num2;
            //display the sum in the label
            label1.Text = $"the sum is: {sum}";
        }
    }
}
