using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace labsheet5.partB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //Clear the text of all textboxes when  the "Reset" button is clicked
            fnTextBox.Text = "";
            lnTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now.Date; // Set date picker to today
            emailTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SIGNUP_Click(object sender, EventArgs e)
        {
            //Check if password and confirm password match
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            //Check if any field is empty
            if (string.IsNullOrEmpty(fnTextBox.Text) || string.IsNullOrEmpty(lnTextBox.Text) ||
            string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(usernameTextBox.Text) ||
            string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(confirmPasswordTextBox.Text) ||
            string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            //creat object and pass user information
            Form2 userinfo = new Form2(
                $"{fnTextBox.Text}{lnTextBox.Text}",
                usernameTextBox.Text,//pass username
                emailTextBox.Text//pass email);
                );

            //Link with Homepage
            userinfo.show();
            this.Hide();


            if (! passwordTextBox.Equals(confirmPasswordTextBox))
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation (optional)
            // - Check for strong password requirements (length, complexity)
            // - Validate email format using Regex

            return;


            //creat an object as a homeform and pass user information

            //link with HomePage
        }
        //Method to check if a given text is a string
         private bool IsString(string Text)
        {
            //check if all characters in the text are letters
            return !string.IsNullOrEmpty(Text) && Text.All(char.IsLetter);
        }
    }
}
