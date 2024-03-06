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
        SqlConnection connect;
        public LoginForm()
        {
            InitializeComponent();
            string debugFolderPath = Directory.GetParent(Application.StartupPath).FullName;
            string solutionFolderPath = Directory.GetParent(debugFolderPath).FullName;
            string databasePath = Path.Combine(solutionFolderPath, "DatabaseLogin.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
            connect = new SqlConnection(connectionString);
        }

        /// not sure if this function is good 
        public string UsernameText
        {
            get { return login_username.Text; }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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
            if (login_username.Text == "" || login_password.Text == "")
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

                        String selectData = "SELECT * FROM [User] WHERE username = @username AND passowrd = @passowrd";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@passowrd", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Game mForm = new Game();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void UpdateMoneyInDatabase(int money, string username)
        {
            try
            {
                connect.Open();
                string updateQuery = "UPDATE [User] SET money = @money WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@money", money);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating money in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
