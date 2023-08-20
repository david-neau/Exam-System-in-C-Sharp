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
using static eems_desktop.admin_view_class;

namespace eems_desktop
{
    public partial class admin_view_user : Form
    {



        public admin_view_user()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Close();
        }

        private void admin_view_user_Load(object sender, EventArgs e)
        {
            LoadUserData(); 
            LoadRoleData(); 
            LoadStatusData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM tbl_user";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        table.DataSource = dataTable;

                        // (Optional) Adjust DataGridView columns appearance if needed
                        // For example: dataGridViewUsers.Columns["Password"].Visible = false; // Hide Password column
                        // For more formatting options, you can explore DataGridView properties and events.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_view_class admin_view_class = new admin_view_class();
            admin_view_class.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_view_user admin_view_user = new admin_view_user();
            admin_view_user.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_view_exam admin_view_exam = new admin_view_exam();
            admin_view_exam.Show();

            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }
        private int selectedUserId;
        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                int selectedUserId = Convert.ToInt32(selectedRow.Cells["UserID"].Value); // Assuming "UserID" is the column name

                // Populate the textboxes and comboboxes with the data from the selected row
                txtselectedID.Text = selectedUserId.ToString();
                txtFirstname.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastname.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();

                // Find and select the corresponding role in the combobox
                int roleId = Convert.ToInt32(selectedRow.Cells["RoleID"].Value);
                foreach (ComboBoxItem item in cbxRole.Items)
                {
                    if (item.Value == roleId)
                    {
                        cbxRole.SelectedItem = item;
                        break;
                    }
                }

                // Find and select the corresponding status in the combobox
                int statusId = Convert.ToInt32(selectedRow.Cells["StatusID"].Value);
                foreach (ComboBoxItem item in cbxStatus.Items)
                {
                    if (item.Value == statusId)
                    {
                        cbxStatus.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void LoadRoleData()
        {
            cbxRole.Items.Clear();

              using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT RoleID, RoleName FROM tbl_role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roleId = reader.GetInt32(0);
                            string roleName = reader.GetString(1);

                            ComboBoxItem item = new ComboBoxItem(roleName, roleId);
                            cbxRole.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void LoadStatusData()
        {
            cbxStatus.Items.Clear();

              using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT StatusID, StatusType FROM tbl_status";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int statusId = reader.GetInt32(0);
                            string statusType = reader.GetString(1);

                            ComboBoxItem item = new ComboBoxItem(statusType, statusId);
                            cbxStatus.Items.Add(item);
                        }
                    }
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            (table.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterValue = txtFirstname.Text;
            (table.DataSource as DataTable).DefaultView.RowFilter = $"FirstName LIKE '%{filterValue}%'";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                   string.IsNullOrWhiteSpace(txtLastname.Text) ||
                   string.IsNullOrWhiteSpace(txtUsername.Text) ||
                   string.IsNullOrWhiteSpace(txtPassword.Text) ||
                   string.IsNullOrWhiteSpace(txtContact.Text) ||
                   cbxRole.SelectedItem == null ||
                   cbxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string contact = txtContact.Text;
            int roleId = ((ComboBoxItem)cbxRole.SelectedItem)?.Value ?? -1;
            int statusId = ((ComboBoxItem)cbxStatus.SelectedItem)?.Value ?? -1;

            if (roleId == -1 || statusId == -1)
            {
                MessageBox.Show("Please select a valid role and status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                  using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO tbl_user (FirstName, LastName, Username, Password, Contact, RoleID, StatusID) " +
                                         "VALUES (@FirstName, @LastName, @Username, @Password, @Contact, @RoleID, @StatusID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@RoleID", roleId);
                        command.Parameters.AddWithValue("@StatusID", statusId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                cbxRole.SelectedItem == null ||
                cbxStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtselectedID.Text)) // Ensure you have the selected ID
            {
                MessageBox.Show("Please fill in all the fields and select a valid user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(txtselectedID.Text); // Get the selected user ID
            string firstName = txtFirstname.Text;
            string lastName = txtLastname.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string contact = txtContact.Text;
            int roleId = ((ComboBoxItem)cbxRole.SelectedItem).Value;
            int statusId = ((ComboBoxItem)cbxStatus.SelectedItem).Value;

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string updateQuery = "UPDATE tbl_user SET FirstName = @FirstName, LastName = @LastName, " +
                                         "Username = @Username, Password = @Password, Contact = @Contact, " +
                                         "RoleID = @RoleID, StatusID = @StatusID WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@RoleID", roleId);
                        command.Parameters.AddWithValue("@StatusID", statusId);
                        command.Parameters.AddWithValue("@UserID", userId); // Use the selected user ID

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUserData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsrcln_Click(object sender, EventArgs e)
        {
            string filterValue = txtLastname.Text;
            (table.DataSource as DataTable).DefaultView.RowFilter = $"LastName LIKE '%{filterValue}%'";
        }

        private void btnsrcun_Click(object sender, EventArgs e)
        {
            string filterValue = txtUsername.Text;
            (table.DataSource as DataTable).DefaultView.RowFilter = $"Username LIKE '%{filterValue}%'";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            admin_view_exam admin_view_exam = new admin_view_exam();
            admin_view_exam.Show();

            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            admin_view_user admin_view_user = new admin_view_user();
            admin_view_user.Show();

            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            admin_view_class admin_view_class = new admin_view_class();
            admin_view_class.Show();

            this.Close();
        }
    }
}
