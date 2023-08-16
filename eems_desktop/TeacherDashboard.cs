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
    public partial class TeacherDashboard : Form
    {
        private int userId;

        public TeacherDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void LoadClasses()
        {
            cbxClassID.Items.Clear();
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load class data into cbxClassID based on the logged-in teacher's UserID
                    string query = "SELECT ClassID, ClassName FROM tbl_class WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

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


        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            LoadExams();
            LoadClasses();
            LoadStatusOptions();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                selectExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();

                int classId = Convert.ToInt32(row.Cells["ClassID"].Value);

                // Find the ComboBoxItem based on the classId
                foreach (ComboBoxItem item in cbxClassID.Items)
                {
                    if (item.Value == classId)
                    {
                        cbxClassID.SelectedItem = item;
                        break;
                    }
                }

                dtpStart.Value = Convert.ToDateTime(row.Cells["StartDateTime"].Value);
                dtpEnd.Value = Convert.ToDateTime(row.Cells["EndDateTime"].Value);

                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

                // Find the ComboBoxItem based on the statusId
                foreach (ComboBoxItem item in cbxStatus.Items)
                {
                    if (item.Value == statusId)
                    {
                        cbxStatus.SelectedItem = item;
                        break;
                    }
                }

                int autoStop = Convert.ToInt32(row.Cells["AutoStop"].Value);
                radioBtnOn.Checked = (autoStop == 1);
                radioBtnOff.Checked = (autoStop == 0);

                txtDuration.Text = row.Cells["Duration"].Value.ToString();
            }
        }

        private void btnViewExam_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedClassId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ClassID"].Value);

                teacher_view_class_exam viewClassExamForm = new teacher_view_class_exam(selectedClassId);
                viewClassExamForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a class to view exams for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExams()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load exam data from tbl_exam where ClassID has the logged-in teacher's UserID
                    string query = "SELECT e.ExamID, e.StartDateTime, e.EndDateTime, e.ExamName, e.Duration, e.AutoStop, e.ClassID, e.StatusID " +
                                   "FROM tbl_exam e " +
                                   "INNER JOIN tbl_class c ON e.ClassID = c.ClassID " +
                                   "WHERE c.UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtExamName.Clear();
            cbxClassID.SelectedIndex = -1;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            cbxStatus.SelectedIndex = -1;
            txtDuration.Clear();
            radioBtnOff.Checked = true;
            selectExamID.Clear();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Insert a new exam record into tbl_exam based on user input
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
                        command.Parameters.AddWithValue("@Duration", Convert.ToInt32(txtDuration.Text)); // Get duration from TextBox
                        int selectedStatusId = ((ComboBoxItem)cbxStatus.SelectedItem).Value;
                        command.Parameters.AddWithValue("@StatusID", selectedStatusId);

                        int autoStopValue = radioBtnOn.Checked ? 1 : 0;
                        command.Parameters.AddWithValue("@AutoStop", autoStopValue);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Exam added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields
                        ClearInputFields();

                        // Refresh DataGridView (if needed)
                        LoadExams();
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

                        int autoStopValue = radioBtnOn.Checked ? 1 : 0;
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

        private int GetCurrentStatusId(int examId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT StatusID FROM tbl_exam WHERE ExamID = @ExamID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExamID", examId);

                        object statusId = command.ExecuteScalar();

                        if (statusId != null && statusId != DBNull.Value)
                        {
                            return Convert.ToInt32(statusId);
                        }
                        else
                        {
                            return -1; // Return a value that indicates no status found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return a value that indicates an error occurred
            }
        }
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int examId = Convert.ToInt32(selectExamID.Text);
                int currentStatusId = GetCurrentStatusId(examId);

                // Determine the new status ID based on the current status ID
                int newStatusId = (currentStatusId == 1) ? 2 : 1;

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE tbl_exam SET StatusID = @StatusID WHERE ExamID = @ExamID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExamID", examId);
                        command.Parameters.AddWithValue("@StatusID", newStatusId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Exam status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh DataGridView
                            LoadExams();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update exam status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectExamID.Text))
                {
                    int examId = Convert.ToInt32(selectExamID.Text);

                    teacher_view_exam_question examQuestionForm = new teacher_view_exam_question(userId, examId);
                    examQuestionForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select an exam to view questions for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
