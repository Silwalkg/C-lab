using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void AddButtonClick(object sender, EventArgs e)
    {
        PerformOperation(textBox1, textBox2, resultLabel, '+');
    }

    private void SubtractButtonClick(object sender, EventArgs e)
    {
        PerformOperation(textBox1, textBox2, resultLabel, '-');
    }

    private void MultiplyButtonClick(object sender, EventArgs e)
    {
        PerformOperation(textBox1, textBox2, resultLabel, '*');
    }

    private void DivideButtonClick(object sender, EventArgs e)
    {
        PerformOperation(textBox1, textBox2, resultLabel, '/');
    }

    private void PerformOperation(TextBox input1, TextBox input2, Label output, char operation)
    {
        try
        {
            double num1 = double.Parse(input1.Text);
            double num2 = double.Parse(input2.Text);

            double result;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new ArgumentException("Invalid operation symbol.");
            }

            output.Text = result.ToString();
        }
        catch (FormatException)
        {
            output.Text = "Invalid input. Please enter numbers only.";
        }
        catch (DivideByZeroException ex)
        {
            output.Text = ex.Message;
        }
        catch (Exception ex)
        {
            output.Text = $"An error occurred: {ex.Message}";
        }
    }
}