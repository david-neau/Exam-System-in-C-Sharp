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

    public partial class admin_view_enrollment : Form
    {
        private int classId;

        public admin_view_enrollment(int selectedClassId)
        {
            InitializeComponent();
            classId = selectedClassId;
        }


        public admin_view_enrollment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            admin_view_class classViewForm = Application.OpenForms.OfType<admin_view_class>().FirstOrDefault();
            classViewForm?.Show(); // Show the class view form if found
            this.Close();
        }

        private void LoadEnrolledStudents()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Query to fetch enrolled students for the given classId
                    string query = "SELECT e.EnrollmentID, e.UserID, u.FirstName, u.LastName FROM tbl_enrollment e " +
                                   "INNER JOIN tbl_user u ON e.UserID = u.UserID " +
                                   "WHERE e.ClassID = @ClassID AND e.StatusID = 1"; // Enrolled status ID

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dgvEnrolledStudents.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNotEnrolledStudents()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Query to fetch students who are not enrolled in the class
                    string query = "SELECT u.UserID, u.FirstName, u.LastName FROM tbl_user u " +
                             "WHERE (u.UserID NOT IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID AND StatusID = 1)" +
                             "       OR (u.UserID IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID AND StatusID = 1) AND u.UserID NOT IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID)))" +
                             "   AND u.RoleID = 3"; // RoleID = 3 for students


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dgvNotEnrolledStudents.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void admin_view_enrollment_Load(object sender, EventArgs e)
        {
            LoadEnrolledStudents();
            LoadNotEnrolledStudents();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin_view_class admin_view_class = new admin_view_class();
            admin_view_class.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            admin_view_user admin_view_user = new admin_view_user();
            admin_view_user.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_view_exam admin_view_exam = new admin_view_exam();
            admin_view_exam.Show();

            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {  try
    {
        int userId = Convert.ToInt32(selectedUserID.Text);

        using (SqlConnection connection = db.GetConnection())
        {
            connection.Open();

            // Check if the student is already enrolled (similar logic as before)
            string checkQuery = "SELECT EnrollmentID, StatusID FROM tbl_enrollment " +
                                "WHERE UserID = @UserID AND ClassID = @ClassID";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@UserID", userId);
                checkCommand.Parameters.AddWithValue("@ClassID", classId);

                using (SqlDataReader reader = checkCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int enrollmentId = reader.GetInt32(0);
                        int statusId = reader.GetInt32(1);
                        reader.Close(); // Close the SqlDataReader

                        if (statusId != 1)
                        {
                            // Update status to indicate enrolled
                            string updateQuery = "UPDATE tbl_enrollment SET StatusID = 1 WHERE EnrollmentID = @EnrollmentID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        reader.Close(); // Close the SqlDataReader
                        
                        // Insert enrollment record for a new enrollment
                        string insertQuery = "INSERT INTO tbl_enrollment (UserID, ClassID, StatusID) " +
                                            "VALUES (@UserID, @ClassID, @StatusID)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserID", userId);
                            insertCommand.Parameters.AddWithValue("@ClassID", classId);
                            insertCommand.Parameters.AddWithValue("@StatusID", 1); // Enrolled status ID

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }

            LoadEnrolledStudents();
            LoadNotEnrolledStudents();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(selectedUserID.Text);

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Update status to indicate not enrolled
                    string updateQuery = "UPDATE tbl_enrollment SET StatusID = 0 " +
                                         "WHERE UserID = @UserID AND ClassID = @ClassID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@UserID", userId);
                        updateCommand.Parameters.AddWithValue("@ClassID", classId);
                        updateCommand.ExecuteNonQuery();
                    }

                    LoadEnrolledStudents();
                    LoadNotEnrolledStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEnrolledStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEnrolledStudents.Rows[e.RowIndex];
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                selectedUserID.Text = userId.ToString();
            }
        }

        private void dgvNotEnrolledStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNotEnrolledStudents.Rows[e.RowIndex];
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                selectedUserID.Text = userId.ToString();
            }
        }

        private void btnsrcenrollment_Click(object sender, EventArgs e)
        {
            string searchName = txtsrcenrollment.Text.Trim();
            LoadEnrolledStudents(searchName);
        }
        private void LoadEnrolledStudents(string searchName = "")
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Query to fetch enrolled students for the given classId and name filter
                    string query = "SELECT e.EnrollmentID, e.UserID, u.FirstName, u.LastName FROM tbl_enrollment e " +
                                   "INNER JOIN tbl_user u ON e.UserID = u.UserID " +
                                   "WHERE e.ClassID = @ClassID AND e.StatusID = 1 " +
                                   "AND (u.FirstName LIKE @SearchName OR u.LastName LIKE @SearchName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classId);
                        command.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dgvEnrolledStudents.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string searchName = txtsrcstudentlist.Text.Trim();
            LoadNotEnrolledStudents(searchName);
        }

        private void LoadNotEnrolledStudents(string searchName = "")
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Query to fetch students who are not enrolled in the class and name filter
                    string query = "SELECT u.UserID, u.FirstName, u.LastName FROM tbl_user u " +
                                   "WHERE (u.UserID NOT IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID AND StatusID = 1)" +
                                   "   OR (u.UserID IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID AND StatusID = 1) AND u.UserID NOT IN (SELECT UserID FROM tbl_enrollment WHERE ClassID = @ClassID))) " +
                                   "AND (u.FirstName LIKE @SearchName OR u.LastName LIKE @SearchName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classId);
                        command.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dgvNotEnrolledStudents.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclearsrcenrollment_Click(object sender, EventArgs e)
        {
            txtsrcenrollment.Text = ""; // Clear the search text box
            LoadEnrolledStudents(); // Reload the data without filtering
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtsrcstudentlist.Text = ""; // Clear the search text box
            LoadNotEnrolledStudents(); // Reload the data without filtering
        }

        private void dgvNotEnrolledStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
