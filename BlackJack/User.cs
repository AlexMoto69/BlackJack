using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }
        public string Background { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        private string InitializeDatabaseConnection()
        {
            string debugFolderPath = Directory.GetParent(Application.StartupPath).FullName;
            string solutionFolderPath = Directory.GetParent(debugFolderPath).FullName;
            string databasePath = Path.Combine(solutionFolderPath, "DatabaseLogin.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";
            return connectionString;
        }
        public void LoadUserInformation()
        {
            try
            {
                string connectionString = InitializeDatabaseConnection();
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM [User] WHERE username = @username AND passowrd = @passowrd";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@passowrd", Password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Money = Convert.ToInt32(reader["money"]);
                            Background = reader["background"].ToString();
                        }
                        else
                        {
                            throw new Exception("User not found or invalid credentials.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading user information: " + ex.Message);
            }
        }
        public void UpdateUserMoney(int money)
        {
            try
            {
                string connectionString = InitializeDatabaseConnection();
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "UPDATE [User] SET money = @money WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@money", money);
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user money: " + ex.Message);
            }
        }

        public void UpdateUserBackground(string background)
        {
            try
            {
                string connectionString = InitializeDatabaseConnection();
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "UPDATE [User] SET background = @background WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@background", background);
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user background: " + ex.Message);
            }
        }

        public static bool UserExists(string username, string password)
        {
            try
            {
                User user = new User(username, password);
                string connectionString = user.InitializeDatabaseConnection();
                string query = "SELECT COUNT(*) FROM [User] WHERE username = @username AND passowrd = @passowrd";

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@passowrd", password);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if user exists: " + ex.Message);
            }
        }
        public void AddUser()
        {
            try
            {
                string connectionString = InitializeDatabaseConnection();
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "INSERT INTO [User] (username, passowrd, money, background) VALUES (@username, @passowrd, @money, @background)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", Username);
                        cmd.Parameters.AddWithValue("@passowrd", Password);
                        cmd.Parameters.AddWithValue("@money", Money);
                        cmd.Parameters.AddWithValue("@background", Background);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding user to the database: " + ex.Message);
            }
        }

        public List<(string, int)> RetrieveUserDataFromDatabase()
        {
            List<(string, int)> userData = new List<(string, int)>();
            try
            {
                string connectionString = InitializeDatabaseConnection();
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT username, money FROM [User]";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string username = reader["username"].ToString();
                            int money = Convert.ToInt32(reader["money"]);
                            userData.Add((username, money));
                        }
                    }
                }
                userData = userData.OrderByDescending(u => u.Item2).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving leaderboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userData;
        }
    }
}
