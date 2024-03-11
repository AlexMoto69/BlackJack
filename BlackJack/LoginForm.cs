using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace BlackJack
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string UsernameText
        {
            get { return login_username.Text; }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register rForm = new Register();
            rForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
                login_password.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string password = login_password.Text;
            try
            {
                if (User.UserExists(username, password))
                {
                    MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Game mForm = new Game(new User(username, password));
                    mForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
