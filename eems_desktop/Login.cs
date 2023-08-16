using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eems_desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Connect to the database and query for the user
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserID, RoleID FROM tbl_user WHERE Username = @username AND Password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int roleId = reader.GetInt32(reader.GetOrdinal("RoleID"));
                                int userId = reader.GetInt32(reader.GetOrdinal("UserID"));

                                Form targetForm = null;

                                // Redirect based on role_id
                                switch (roleId)
                                {
                                    case 1:
                                        targetForm = new AdminDashboard();
                                        break;

                                    case 2:
                                        targetForm = new TeacherDashboard(userId); // Pass UserID to TeacherDashboard
                                        break;

                                    case 3:
                                        targetForm = new StudentDashboard(userId);
                                        break;

                                    default:
                                        MessageBox.Show("Unknown role_id");
                                        break;
                                }

                                if (targetForm != null)
                                {
                                    // Close the current form only after showing the target form
                                    targetForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
