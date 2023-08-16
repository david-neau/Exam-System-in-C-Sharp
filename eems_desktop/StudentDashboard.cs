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
    public partial class StudentDashboard : Form
    {
        private int userId;
        public StudentDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadEnrolledClassesAndExams();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void LoadEnrolledClassesAndExams()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load enrolled classes for the student from tbl_enrollment
                    string enrolledClassesQuery = "SELECT ClassID FROM tbl_enrollment WHERE UserID = @UserID";
                    using (SqlCommand enrolledClassesCommand = new SqlCommand(enrolledClassesQuery, connection))
                    {
                        enrolledClassesCommand.Parameters.AddWithValue("@UserID", userId);

                        List<int> enrolledClassIds = new List<int>();

                        using (SqlDataReader enrolledClassesReader = enrolledClassesCommand.ExecuteReader())
                        {
                            while (enrolledClassesReader.Read())
                            {
                                int classId = enrolledClassesReader.GetInt32(0);
                                enrolledClassIds.Add(classId);
                            }
                        }

                        // Load exams for the enrolled classes from tbl_exam that have associated rows in tbl_question
                        string examsQuery = "SELECT DISTINCT e.ExamID, e.ExamName, e.StartDateTime, e.EndDateTime, e.Duration " +
                                            "FROM tbl_exam e " +
                                            "INNER JOIN tbl_question q ON e.ExamID = q.ExamID " +
                                            "WHERE e.ClassID IN (" + string.Join(",", enrolledClassIds) + ")";

                        using (SqlCommand examsCommand = new SqlCommand(examsQuery, connection))
                        {
                            DataTable dataTable = new DataTable();
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(examsCommand);
                            dataAdapter.Fill(dataTable);

                            dgvExam.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadEnrolledClassesAndExams();
            LoadAttemptHistory();
        }

        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedExamId = Convert.ToInt32(dgvExam.Rows[e.RowIndex].Cells["ExamID"].Value);
                selectExamID.Text = selectedExamId.ToString();
            }
        }

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectExamID.Text))
            {
                MessageBox.Show("Please select an exam to start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected exam ID from the selectExamID TextBox
            int selectedExamId = Convert.ToInt32(selectExamID.Text);

            // Create an instance of the QuestionForm and pass both exam ID and user ID
            QuestionForm questionForm = new QuestionForm(selectedExamId, userId);

            // Show the QuestionForm
            questionForm.Show();

            // Optionally, you can hide the current form if needed
            this.Hide();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAttemptHistory()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load attempt history for the user including ExamName and UserID
                    string attemptHistoryQuery =
                        "SELECT a.AttemptID, e.ExamName, a.UserID " +
                        "FROM tbl_attempt a " +
                        "INNER JOIN tbl_exam e ON a.ExamID = e.ExamID " +
                        "WHERE a.UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(attemptHistoryQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        // Add the CorrectResponses and TotalQuestions columns to the DataGridView
                        dataTable.Columns.Add("CorrectResponses", typeof(int));
                        dataTable.Columns.Add("TotalQuestions", typeof(int));

                        dgvResult.DataSource = dataTable;

                        DisplayAttemptResults(); // Call the function to display attempt results
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAttemptResults()
        {
            try
            {
                foreach (DataGridViewRow row in dgvResult.Rows)
                {
                    int attemptId = Convert.ToInt32(row.Cells["AttemptID"].Value);
                    string examName = Convert.ToString(row.Cells["ExamName"].Value);

                    int correctCount = GetCorrectResponseCount(attemptId);

                    // Display the results
                    row.Cells["CorrectResponses"].Value = correctCount;
                    row.Cells["TotalQuestions"].Value = GetTotalQuestions(examName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCorrectResponseCount(int attemptId)
        {
            int correctCount = 0;

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Count the number of correct responses for the given attemptId
                    string correctResponseCountQuery =
                        "SELECT COUNT(*) " +
                        "FROM tbl_response r " +
                        "INNER JOIN tbl_answer a ON r.QuestionID = a.QuestionID AND r.OptionID = a.OptionID " +
                        "WHERE r.AttemptID = @AttemptID";

                    using (SqlCommand command = new SqlCommand(correctResponseCountQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AttemptID", attemptId);

                        correctCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return correctCount;
        }

        private int GetTotalQuestions(string examName)
        {
            int totalQuestions = 0;

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Count the total number of questions for the given examName
                    string totalQuestionsQuery =
                        "SELECT COUNT(*) " +
                        "FROM tbl_question q " +
                        "INNER JOIN tbl_exam e ON q.ExamID = e.ExamID " +
                        "WHERE e.ExamName = @ExamName";

                    using (SqlCommand command = new SqlCommand(totalQuestionsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExamName", examName);

                        totalQuestions = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalQuestions;
        }
    }
}
