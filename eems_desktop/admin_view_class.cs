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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eems_desktop
{

    public partial class admin_view_class : Form
    {
        public admin_view_class()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedClassId != 0) // Assuming classId is never 0 (modify this condition as needed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM tbl_class WHERE ClassID = @ClassID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@ClassID", selectedClassId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Clear the ClassInfo TextBox and reset selectedClassId
                                ClassInfo.Text = "";
                                selectedClassId = 0;

                                // Refresh or reload the DataGridView if needed
                                // dataGridViewClasses.Refresh();

                                MessageBox.Show("Row deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete row from the database.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT c.ClassID, c.ClassName, u.FirstName + ' ' + u.LastName AS FullName " +
                       "FROM tbl_class c " +
                       "INNER JOIN tbl_user u ON c.UserID = u.UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                   
                        table.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadTeacherCombo()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT UserID, FirstName, LastName FROM tbl_user WHERE RoleID = 2";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userId = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);
                            string fullName = $"{firstName} {lastName}";

                            // Create a new ComboBox item with the full name as display text
                            // and the UserID as the value
                            ComboBoxItem item = new ComboBoxItem(fullName, userId);
                            comboBoxUsers.Items.Add(item);
                        }
                    }
                }
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }


        private void admin_view_class_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadTeacherCombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_view_class admin_view_class = new admin_view_class();
            admin_view_class.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private int selectedClassId;
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = table.Rows[e.RowIndex];
                selectedClassId = Convert.ToInt32(selectedRow.Cells["ClassID"].Value);

              
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT ClassName, UserID FROM tbl_class WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", selectedClassId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string className = reader.GetString(0);
                                int userId = reader.GetInt32(1);

                                txtClassName.Text = className;

                                // Find the ComboBoxItem with the matching UserID and select it
                                foreach (ComboBoxItem item in comboBoxUsers.Items)
                                {
                                    if (item.Value == userId)
                                    {
                                        comboBoxUsers.SelectedItem = item;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                ClassInfo.Text = $"{selectedClassId}";
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }




        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtClassName.Text) || comboBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Empty field!");
            }
            else
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_class (ClassName,UserID) values (@ClassName,@UserID)", connection);
                    cmd.Parameters.AddWithValue("@ClassName", (txtClassName.Text));
                    ComboBoxItem selectedComboBoxItem = (ComboBoxItem)comboBoxUsers.SelectedItem;
                    int selectedUserId = selectedComboBoxItem.Value;
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Class has been added to database.");
                      LoadUserData();

                }
            }
            LoadUserData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text) || comboBoxUsers.SelectedItem == null)
            {
                MessageBox.Show("Empty field!");
            }
            else
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string updateQuery = "UPDATE tbl_class SET ClassName = @ClassName, UserID = @UserID WHERE ClassID = @ClassID";
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);

                    cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
                    ComboBoxItem selectedComboBoxItem = (ComboBoxItem)comboBoxUsers.SelectedItem;
                    int selectedUserId = selectedComboBoxItem.Value;
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                    cmd.Parameters.AddWithValue("@ClassID", selectedClassId); // Use the selected ClassID

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Class has been updated.");
                    LoadUserData();
                }
            }
            LoadUserData();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            if (selectedClassId != 0)
            {
                admin_view_enrollment enrollmentForm = new admin_view_enrollment(selectedClassId);
                enrollmentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a class before proceeding with enrollment.", "No Class Selected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
