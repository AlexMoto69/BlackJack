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

namespace BlackJack
{
    public partial class Register : Form
    {
        SqlConnection connect;
        public Register()
        {
            InitializeComponent();
            string debugFolderPath = Directory.GetParent(Application.StartupPath).FullName;
            string solutionFolderPath = Directory.GetParent(debugFolderPath).FullName;
            string databasePath = Path.Combine(solutionFolderPath, "DatabaseLogin.mdf");
            MessageBox.Show("Database file path: " + databasePath);
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
            connect = new SqlConnection(connectionString);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }


        private void signup_button_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM [User] WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            using (SqlDataReader reader = checkUser.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MessageBox.Show(signup_username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Exit the method if the username already exists
                                }
                            }
                        }

                        // If we reach here, it means the username doesn't exist, so we can proceed with registration
                        string insertData = "INSERT INTO [User] (username, passowrd) VALUES (@username, @password)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TO SWITCH THE FORM 
                            Form1 lForm = new Form1();
                            lForm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
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
    }
}
