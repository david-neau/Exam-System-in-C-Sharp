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
    public partial class admin_view_exam : Form
    {
        public admin_view_exam()
        {
            InitializeComponent();
            LoadExams();
            LoadTeachers();

            LoadStatusOptions();
        }

        private void LoadStatusOptions()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT StatusID, StatusType FROM tbl_status";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        // Clear and reset the ComboBox
                        cbxStatus.Items.Clear();
                        cbxStatus.DisplayMember = "Text"; // DisplayMember should match the property name in ComboBoxItem
                        cbxStatus.ValueMember = "Value"; // ValueMember should match the property name in ComboBoxItem

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int statusId = Convert.ToInt32(row["StatusID"]);
                            string statusType = row["StatusType"].ToString();
                            ComboBoxItem item = new ComboBoxItem(statusType, statusId);
                            cbxStatus.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExams()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT e.*, c.ClassName, u.FirstName, u.LastName " +
                                   "FROM tbl_class c " +
                                   "INNER JOIN tbl_exam e ON c.ClassID = e.ClassID " +
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load teacher data into cbxUserID (similar to cbxClassTeacher in your previous form)
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

                                cbxUserID.Items.Add(new ComboBoxItem(fullName, userId));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClasses(int selectedUserId)
        {
            cbxClassID.Items.Clear();
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load class data into cbxClassID based on the selected teacher (UserID)
                    string query = "SELECT ClassID, ClassName FROM tbl_class WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", selectedUserId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int classId = reader.GetInt32(0);
                                string className = reader.GetString(1);

                                cbxClassID.Items.Add(new ComboBoxItem(className, classId));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void admin_view_exam_Load(object sender, EventArgs e)
        {
       
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        connection.Open();

                       
                        string insertQuery = "INSERT INTO tbl_exam (ExamName, ClassID, StartDateTime, EndDateTime, Duration, AutoStop, StatusID) " +
                                             "VALUES (@ExamName, @ClassID, @StartDateTime, @EndDateTime, @Duration, @AutoStop, @StatusID)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                        
                            command.Parameters.AddWithValue("@ExamName", txtExamName.Text);
                            ComboBoxItem selectedClassItem = (ComboBoxItem)cbxClassID.SelectedItem;
                            int selectedClassId = selectedClassItem.Value;
                            command.Parameters.AddWithValue("@ClassID", selectedClassId);
                            command.Parameters.AddWithValue("@StartDateTime", dtpStart.Value);
                            command.Parameters.AddWithValue("@EndDateTime", dtpEnd.Value);
                            command.Parameters.AddWithValue("@Duration", Convert.ToInt32(txtDuration.Text)); 
                            int selectedStatusId = ((ComboBoxItem)cbxStatus.SelectedItem).Value;
                            command.Parameters.AddWithValue("@StatusID", selectedStatusId);

                           
                            int autoStopValue = 0; 
                            if (radioBtnOn.Checked)
                            {
                                autoStopValue = 1;
                            }
                            command.Parameters.AddWithValue("@AutoStop", autoStopValue);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Exam added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadExams(); // Refresh DataGridView after adding an exam
            }

            // Similar event handlers and methods for editing and deleting exams can be added
        }

        private void cbxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserID.SelectedItem is ComboBoxItem selectedComboBoxItem)
            {
                int selectedUserId = selectedComboBoxItem.Value;
                cbxClassID.Items.Clear();
                LoadClasses(selectedUserId);
            }
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int examId = Convert.ToInt32(selectExamID.Text);

                if (string.IsNullOrWhiteSpace(txtExamName.Text) ||
                    cbxClassID.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtDuration.Text) ||
                    cbxStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE tbl_exam SET ExamName = @ExamName, ClassID = @ClassID, StartDateTime = @StartDateTime, EndDateTime = @EndDateTime, Duration = @Duration, AutoStop = @AutoStop, StatusID = @StatusID " +
                                         "WHERE ExamID = @ExamID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExamID", examId);
                        command.Parameters.AddWithValue("@ExamName", txtExamName.Text);
                        ComboBoxItem selectedClassItem = (ComboBoxItem)cbxClassID.SelectedItem;
                        int selectedClassId = selectedClassItem.Value;
                        command.Parameters.AddWithValue("@ClassID", selectedClassId);
                        command.Parameters.AddWithValue("@StartDateTime", dtpStart.Value);
                        command.Parameters.AddWithValue("@EndDateTime", dtpEnd.Value);
                        command.Parameters.AddWithValue("@Duration", Convert.ToInt32(txtDuration.Text));
                        int selectedStatusId = ((ComboBoxItem)cbxStatus.SelectedItem).Value;
                        command.Parameters.AddWithValue("@StatusID", selectedStatusId);

                        int autoStopValue = 0; 
                        if (radioBtnOn.Checked)
                        {
                            autoStopValue = 1; 
                        }
                        command.Parameters.AddWithValue("@AutoStop", autoStopValue);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exam updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                            LoadExams(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to update exam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int selectedExamId;
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = table.Rows[e.RowIndex];
                selectExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();

                int classId = Convert.ToInt32(row.Cells["ClassID"].Value);
                cbxClassID.SelectedIndex = cbxClassID.FindStringExact(classId.ToString());

                dtpStart.Value = Convert.ToDateTime(row.Cells["StartDateTime"].Value);
                dtpEnd.Value = Convert.ToDateTime(row.Cells["EndDateTime"].Value);

                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

                foreach (ComboBoxItem item in cbxStatus.Items)
                {
                    if (item.Value == statusId)
                    {
                        cbxStatus.SelectedItem = item;
                        break;
                    }
                }

                int autoStop = Convert.ToInt32(row.Cells["AutoStop"].Value);
                if (autoStop == 1)
                {
                    radioBtnOn.Checked = true;
                }
                else
                {
                    radioBtnOff.Checked = true;
                }

                txtDuration.Text = row.Cells["Duration"].Value.ToString();

                
            }
        }



        private void ClassInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            admin_view_class admin_view_class = new admin_view_class();
            admin_view_class.Show();

            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            admin_view_user admin_view_user = new admin_view_user();
            admin_view_user.Show();

            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            admin_view_exam admin_view_exam = new admin_view_exam();
            admin_view_exam.Show();

            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedExamId = Convert.ToInt32(table.CurrentRow.Cells["ExamID"].Value);
            admin_view_result viewExamResultForm = new admin_view_result(selectedExamId);
            viewExamResultForm.Show();
            this.Close();
        }
    }
    
}
