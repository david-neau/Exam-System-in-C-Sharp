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
    public partial class admin_view_result : Form
    {
        private int examId;
        public admin_view_result(int examId)
        {
            InitializeComponent();
            this.examId = examId;

            LoadExamResults(examId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Hide();
        }

        private void LoadExamResults(int examId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT a.AttemptID, u.FirstName, u.LastName,  COUNT(r.ResponseID) AS TotalQuestions " +
                                   "FROM tbl_attempt a " +
                                   "INNER JOIN tbl_user u ON a.UserID = u.UserID " +
                                   "LEFT JOIN tbl_response r ON a.AttemptID = r.AttemptID " +
                                   "WHERE a.ExamID = @ExamID " +
                                   "GROUP BY a.AttemptID, u.FirstName, u.LastName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExamID", examId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        // Calculate and add the score based on correct answers
                        dataTable.Columns.Add("CorrectCount", typeof(int)); // Add a column for CorrectCount
                        dataTable.Columns.Add("CalculatedScore", typeof(int));

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int attemptId = Convert.ToInt32(row["AttemptID"]);
                            int correctCount = GetCorrectResponseCount(attemptId); // Implement this function to get correct count
                            int totalQuestions = Convert.ToInt32(row["TotalQuestions"]);
                            int calculatedScore = (int)Math.Round((double)correctCount / totalQuestions * 100); // Calculate the score

                            row["CorrectCount"] = correctCount; // Set the value for CorrectCount
                            row["CalculatedScore"] = calculatedScore;
                        }

                        dataGridViewUsers.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCorrectResponseCount(int attemptId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Count the number of correct responses for the given attempt
                    string query = "SELECT COUNT(*) " +
                                   "FROM tbl_response r " +
                                   "INNER JOIN tbl_answer a ON r.QuestionID = a.QuestionID AND r.OptionID = a.OptionID " +
                                   "WHERE r.AttemptID = @AttemptID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AttemptID", attemptId);
                        return (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }



        private void admin_view_result_Load(object sender, EventArgs e)
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
    }
}
