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
using static eems_desktop.QuestionForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace eems_desktop
{
    public partial class QuestionForm : Form
    {
        private int ExamId;
        private int UserId;
        private List<Question> Questions;
        private List<Option> Options;
        private int[] SelectedOptions;
        private int CurrentQuestionIndex = 0;
        private int remainingTimeInSeconds;
        private int examDurationInSeconds;

        public QuestionForm(int examId, int userId)
        {
            InitializeComponent();
            ExamId = examId;
            UserId = userId;

            LoadQuestionsAndOptions();
            SelectedOptions = new int[Questions.Count];
            CurrentQuestionIndex = 0;
        }

        public class Question
        {
            public int QuestionId { get; set; }
            public int ExamId { get; set; }
            public string QuestionText { get; set; }
        }

        public class Option
        {
            public int OptionId { get; set; }
            public int QuestionId { get; set; }
            public string OptionText { get; set; }
        }

        private void LoadQuestionsAndOptions()
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string durationQuery = "SELECT Duration FROM tbl_exam WHERE ExamID = @ExamID";
                using (SqlCommand command = new SqlCommand(durationQuery, connection))
                {
                    command.Parameters.AddWithValue("@ExamID", ExamId);
                    examDurationInSeconds = Convert.ToInt32(command.ExecuteScalar()) * 60; // Convert minutes to seconds
                }
            }

            remainingTimeInSeconds = examDurationInSeconds;

            // Start the timer
            timer1.Start();

            Questions = new List<Question>();
            Options = new List<Option>();

            string connectionString = @"Data Source=DESKTOP-01B4F2C;Initial Catalog=eems;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string questionsQuery = "SELECT QuestionId, QuestionText FROM tbl_question WHERE ExamId = @ExamId";
                using (SqlCommand questionsCmd = new SqlCommand(questionsQuery, connection))
                {
                    questionsCmd.Parameters.AddWithValue("@ExamId", ExamId);
                    using (SqlDataReader questionsReader = questionsCmd.ExecuteReader())
                    {
                        while (questionsReader.Read())
                        {
                            Question question = new Question
                            {
                                QuestionId = questionsReader.GetInt32(0),
                                ExamId = ExamId,
                                QuestionText = questionsReader.GetString(1)
                            };
                            Questions.Add(question);
                        }
                    }
                }

                string optionsQuery = "SELECT OptionId, QuestionId, OptionText FROM tbl_Option WHERE QuestionId = @QuestionId";
                foreach (Question question in Questions)
                {
                    using (SqlCommand optionsCmd = new SqlCommand(optionsQuery, connection))
                    {
                        optionsCmd.Parameters.AddWithValue("@QuestionId", question.QuestionId);
                        using (SqlDataReader optionsReader = optionsCmd.ExecuteReader())
                        {
                            while (optionsReader.Read())
                            {
                                Option option = new Option
                                {
                                    OptionId = optionsReader.GetInt32(0),
                                    QuestionId = question.QuestionId,
                                    OptionText = optionsReader.GetString(2)
                                };
                                Options.Add(option);
                            }
                        }
                    }
                }
            }
        }

        private void DisplayQuestionAndOptions()
        {
            if (CurrentQuestionIndex < Questions.Count)
            {
                Question currentQuestion = Questions[CurrentQuestionIndex];
                lblQuestion.Text = currentQuestion.QuestionText;

                flowLayoutPanelOptions.Controls.Clear();

                List<Option> optionsForCurrentQuestion = Options.Where(o => o.QuestionId == currentQuestion.QuestionId).ToList();
                foreach (Option option in optionsForCurrentQuestion)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = option.OptionText,
                        Tag = option.OptionId,
                        AutoSize = true
                    };

                    radioButton.CheckedChanged += RadioButton_CheckedChanged;

                    if (SelectedOptions[CurrentQuestionIndex] == option.OptionId)
                    {
                        radioButton.Checked = true;
                    }

                    flowLayoutPanelOptions.Controls.Add(radioButton);
                }

                btnPrevious.Enabled = CurrentQuestionIndex > 0;
                btnNext.Enabled = CurrentQuestionIndex < Questions.Count - 1;

                btnSubmit.Visible = CurrentQuestionIndex == Questions.Count - 1;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            int selectedOptionId = (int)selectedRadioButton.Tag;
            SelectedOptions[CurrentQuestionIndex] = selectedOptionId;
        }

   

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex < Questions.Count - 1)
            {
                CurrentQuestionIndex++;
                DisplayQuestionAndOptions();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex > 0)
            {
                CurrentQuestionIndex--;
                DisplayQuestionAndOptions();
            }
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            DisplayQuestionAndOptions();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            int attemptId;

            string connectionString = @"Data Source=DESKTOP-01B4F2C;Initial Catalog=eems;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertAttemptQuery = "INSERT INTO tbl_Attempt (ExamId, UserID) VALUES (@ExamId, @UserId); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(insertAttemptQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ExamId", ExamId);
                    cmd.Parameters.AddWithValue("@UserId", UserId); // Pass the userId to the query
                    attemptId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertResponseQuery = "INSERT INTO tbl_Response (AttemptId, OptionId, QuestionId) VALUES (@AttemptId, @OptionId, @QuestionId)";
                using (SqlCommand cmd = new SqlCommand(insertResponseQuery, connection))
                {
                    for (int i = 0; i < Questions.Count; i++)
                    {
                        if (SelectedOptions[i] != 0)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@AttemptId", attemptId);
                            cmd.Parameters.AddWithValue("@OptionId", SelectedOptions[i]);
                            cmd.Parameters.AddWithValue("@QuestionId", Questions[i].QuestionId);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show($"Please select an option for Question {i + 1} before submitting.", "Incomplete Submission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            MessageBox.Show("Responses submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AttemptResult attemptResultForm = new AttemptResult(attemptId, ExamId, UserId);
            attemptResultForm.Show();
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex < Questions.Count - 1)
            {
                CurrentQuestionIndex++;
                DisplayQuestionAndOptions(); // Update the display
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (CurrentQuestionIndex > 0)
            {
                CurrentQuestionIndex--;
                DisplayQuestionAndOptions(); // Update the display
            }
        }

        private void flowLayoutPanelOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTimeInSeconds--;

            if (remainingTimeInSeconds <= 0)
            {
                // Timer has ended, submit selections
                timer1.Stop(); // Stop the timer
                SubmitSelections();
            }
            else
            {
                // Update the timer display
                int minutes = remainingTimeInSeconds / 60;
                int seconds = remainingTimeInSeconds % 60;
                lblTimer.Text = $"{minutes:00}:{seconds:00}";
            }
        }

        private void SubmitSelections()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-01B4F2C;Initial Catalog=eems;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert attempt information into tbl_Attempt
                    int attemptId;
                    string insertAttemptQuery = "INSERT INTO tbl_Attempt (ExamId, UserID) VALUES (@ExamId, @UserId); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertAttemptQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ExamId", ExamId);
                        cmd.Parameters.AddWithValue("@UserId", UserId);
                        attemptId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert responses into tbl_Response
                    string insertResponseQuery = "INSERT INTO tbl_Response (AttemptId, OptionId, QuestionId) VALUES (@AttemptId, @OptionId, @QuestionId)";
                    using (SqlCommand cmd = new SqlCommand(insertResponseQuery, connection))
                    {
                        for (int i = 0; i < Questions.Count; i++)
                        {
                            int selectedOption = SelectedOptions[i];

                            // If no option is selected, use DBNull.Value to insert NULL
                            object optionValue = (selectedOption != 0) ? (object)selectedOption : DBNull.Value;

                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@AttemptId", attemptId);
                            cmd.Parameters.AddWithValue("@OptionId", optionValue);
                            cmd.Parameters.AddWithValue("@QuestionId", Questions[i].QuestionId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Responses submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the attempt result form
                    AttemptResult attemptResultForm = new AttemptResult(attemptId, ExamId, UserId);
                    attemptResultForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
