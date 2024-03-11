using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BlackJack
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
                signup_password.PasswordChar = '*';
        }


        private void signup_button_Click(object sender, EventArgs e)
        {
            string username = signup_username.Text;
            string password = signup_password.Text;

            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (User.UserExists(username, password))
                    {
                        MessageBox.Show(username + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    User newUser = new User(username, password);
                    newUser.Money = 1000;
                    newUser.Background = "table.jpg";
                    newUser.AddUser();
                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm lForm = new LoginForm();
                    lForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
