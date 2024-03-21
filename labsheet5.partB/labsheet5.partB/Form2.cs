using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet5.partB
{
    public partial class Form2 : Form
    {
        public Form2(string fullname,string username,string email)
        {
            InitializeComponent();

            //display user information
            NameLabel.Text =$"Name: {fullname}";
            UserNameLable.Text = $"username:{username}";
            emaillable.Text = $"Email:{email}";
        }

        internal void show()
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
