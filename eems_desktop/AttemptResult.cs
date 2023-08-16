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
    public partial class AttemptResult : Form
    {
        private int attemptId;
        private int ExamId;
        private int userID;

        public AttemptResult(int attemptId, int examId, int UserID)
        {
            InitializeComponent();
            this.attemptId = attemptId;
            ExamId = examId;
            userID = UserID;
            // Call the method to retrieve and display the result
            DisplayAttemptResult();
            CalculateAndDisplayPercentage();
        }
        private void DisplayAttemptResult()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-01B4F2C;Initial Catalog=eems;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve all responses for the given attemptId from tbl_response
                    string responsesQuery = "SELECT r.OptionID, o.QuestionID " +
                                            "FROM tbl_Response r " +
                                            "INNER JOIN tbl_Option o ON r.OptionID = o.OptionID " +
                                            "WHERE r.AttemptID = @AttemptId";
                    using (SqlCommand responsesCommand = new SqlCommand(responsesQuery, connection))
                    {
                        responsesCommand.Parameters.AddWithValue("@AttemptId", attemptId);

                        Dictionary<int, int> selectedOptionsByQuestion = new Dictionary<int, int>();

                        using (SqlDataReader responsesReader = responsesCommand.ExecuteReader())
                        {
                            while (responsesReader.Read())
                            {
                                int optionId = responsesReader.GetInt32(0);
                                int questionId = responsesReader.GetInt32(1);
                                selectedOptionsByQuestion[questionId] = optionId;
                            }
                        }

                        // Count the number of correct responses using tbl_answer
                        int correctCount = 0;
                        foreach (var kvp in selectedOptionsByQuestion)
                        {
                            int questionId = kvp.Key;
                            int selectedOptionId = kvp.Value;

                            string correctResponseQuery = "SELECT COUNT(*) " +
                                                          "FROM tbl_Answer " +
                                                          "WHERE QuestionID = @QuestionId " +
                                                          "AND OptionID = @OptionId";
                            using (SqlCommand correctResponseCommand = new SqlCommand(correctResponseQuery, connection))
                            {
                                correctResponseCommand.Parameters.AddWithValue("@QuestionId", questionId);
                                correctResponseCommand.Parameters.AddWithValue("@OptionId", selectedOptionId);

                                int responseCount = Convert.ToInt32(correctResponseCommand.ExecuteScalar());
                                if (responseCount > 0)
                                {
                                    correctCount++;
                                }
                            }
                        }

                        // Get the total number of questions in the exam from tbl_question
                        string totalQuestionsQuery = "SELECT COUNT(*) " +
                                                     "FROM tbl_Question " +
                                                     "WHERE ExamID = @ExamId";
                        using (SqlCommand totalQuestionsCommand = new SqlCommand(totalQuestionsQuery, connection))
                        {
                            totalQuestionsCommand.Parameters.AddWithValue("@ExamId", ExamId);
                            int totalQuestions = Convert.ToInt32(totalQuestionsCommand.ExecuteScalar());

                            // Get the total number of responses in the attempt
                            int totalResponses = selectedOptionsByQuestion.Count;

                            // Display the results
                            lblResult.Text = $"Number of correct responses: {correctCount}" +
                                             $"\nTotal questions in exam: {totalQuestions}" +
                                             $"\nTotal responses in attempt: {totalResponses}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void CalculateAndDisplayPercentage()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Count the number of correct responses
                    string correctResponsesQuery = "SELECT COUNT(*) FROM tbl_response r " +
                                                  "INNER JOIN tbl_option o ON r.OptionID = o.OptionID " +
                                                  "INNER JOIN tbl_answer a ON o.OptionID = a.OptionID " +
                                                  "WHERE r.AttemptID = @AttemptId";
                    using (SqlCommand correctResponsesCommand = new SqlCommand(correctResponsesQuery, connection))
                    {
                        correctResponsesCommand.Parameters.AddWithValue("@AttemptId", attemptId);
                        int correctResponses = (int)correctResponsesCommand.ExecuteScalar();

                        // Retrieve the total number of questions in the exam
                        string totalQuestionsQuery = "SELECT COUNT(*) FROM tbl_question WHERE ExamID = @ExamId";
                        using (SqlCommand totalQuestionsCommand = new SqlCommand(totalQuestionsQuery, connection))
                        {
                            totalQuestionsCommand.Parameters.AddWithValue("@ExamId", ExamId);
                            int totalQuestions = (int)totalQuestionsCommand.ExecuteScalar();

                            // Calculate and display the percentage
                            double percentage = (correctResponses * 100.0) / totalQuestions;
                            lblPercentage.Text = $"Your score: {percentage:F2}%";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AttemptResult_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StudentDashboard studentDashboardForm = new StudentDashboard(userID);
            studentDashboardForm.Show();

            this.Close();
        }
    }

}