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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace eems_desktop
{
    public partial class add_new_question : Form
    {
        private int userId;
        private int examId;

        public add_new_question(int userId, int examId)
        {
            InitializeComponent();
            this.userId = userId;
            this.examId = examId;
            LoadQuestionTypes();
        }



        private void add_new_question_Load(object sender, EventArgs e)
        {
          
        }

        private void ClearMCQFormFields()
        {
            txtmqcquestiontext.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();

            foreach (Control control in groupBox1.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void btnInsertMCQ_Click_1(object sender, EventArgs e)
        {
            if (cbxQuestionType.SelectedItem != null && cbxQuestionType.SelectedValue.ToString() == "1")
            {
                string questionText = txtmqcquestiontext.Text;

                int questionId;
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string insertQuestionQuery = "INSERT INTO tbl_question (QuestionText, ExamID) VALUES (@QuestionText, @ExamID); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertQuestionQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@QuestionText", questionText);
                        cmd.Parameters.AddWithValue("@ExamID", examId);
                        questionId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                List<string> options = new List<string>
        {
            txtOption1.Text,
            txtOption2.Text,
            txtOption3.Text,
            txtOption4.Text
        };

                int correctOptionIndex = -1; // Index of the correct option
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    for (int i = 0; i < options.Count; i++)
                    {
                        System.Windows.Forms.RadioButton radioButton = Controls.Find($"rboption{i + 1}iscorrect", true).FirstOrDefault() as System.Windows.Forms.RadioButton;
                        bool isCorrect = radioButton?.Checked ?? false;

                        if (i == 0)
                        {
                            // Insert the first option into tbl_option and tbl_answer
                            string insertOptionQuery = "INSERT INTO tbl_option (OptionText, QuestionID) VALUES (@OptionText, @QuestionID); SELECT SCOPE_IDENTITY();";
                            using (SqlCommand cmd = new SqlCommand(insertOptionQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@OptionText", options[i]);
                                cmd.Parameters.AddWithValue("@QuestionID", questionId);
                                int optionId = Convert.ToInt32(cmd.ExecuteScalar());

                                if (isCorrect)
                                {
                                    correctOptionIndex = i; // Store the index of the correct option
                                }

                                string insertAnswerQuery = "INSERT INTO tbl_answer (QuestionID, OptionID) VALUES (@QuestionID, @OptionID)";
                                using (SqlCommand answerCmd = new SqlCommand(insertAnswerQuery, connection))
                                {
                                    answerCmd.Parameters.AddWithValue("@QuestionID", questionId);
                                    answerCmd.Parameters.AddWithValue("@OptionID", optionId);
                                    answerCmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            // Insert the remaining options into tbl_option
                            string insertOptionQuery = "INSERT INTO tbl_option (OptionText, QuestionID) VALUES (@OptionText, @QuestionID);";
                            using (SqlCommand cmd = new SqlCommand(insertOptionQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@OptionText", options[i]);
                                cmd.Parameters.AddWithValue("@QuestionID", questionId);
                                cmd.ExecuteNonQuery();
                            }

                            if (isCorrect)
                            {
                                correctOptionIndex = i; // Store the index of the correct option
                            }
                        }
                    }
                }

                if (correctOptionIndex >= 0)
                {
                    MessageBox.Show("MCQ question and options inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a correct option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearMCQFormFields();
            }
        }

        private void LoadQuestionTypes()
        {
            Dictionary<int, string> questionTypes = new Dictionary<int, string>
        {
            { 1, "MCQ" },
            { 2, "True/False" }
        };

            cbxQuestionType.DataSource = new BindingSource(questionTypes, null);
            cbxQuestionType.DisplayMember = "Value";
            cbxQuestionType.ValueMember = "Key";
        }

        private void cbxQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuestionType.SelectedItem != null)
            {
                int selectedQuestionTypeId = ((KeyValuePair<int, string>)cbxQuestionType.SelectedItem).Key;

                groupBox1.Visible = (selectedQuestionTypeId == 1);
                groupBox2.Visible = (selectedQuestionTypeId == 2);

                if (selectedQuestionTypeId != 1 && selectedQuestionTypeId != 2)
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            teacher_view_exam_question teacherViewExamQuestionForm = new teacher_view_exam_question(userId,examId);
            teacherViewExamQuestionForm.Show();
            this.Close();
        }

        private void btnInsertTF_Click(object sender, EventArgs e)
        {
            if (cbxQuestionType.SelectedItem != null && cbxQuestionType.SelectedValue.ToString() == "2")
            {
                string questionText = txttfquestiontext.Text;

                int questionId;
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string insertQuestionQuery = "INSERT INTO tbl_question (QuestionText, ExamID) VALUES (@QuestionText, @ExamID); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertQuestionQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@QuestionText", questionText);
                        cmd.Parameters.AddWithValue("@ExamID", examId);
                        questionId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                int optionIdTrue;
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string insertOptionQuery = "INSERT INTO tbl_option (OptionText, QuestionID) VALUES (@OptionText, @QuestionID); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertOptionQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@OptionText", "True"); // Insert 'True' option
                        cmd.Parameters.AddWithValue("@QuestionID", questionId);
                        optionIdTrue = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                int optionIdFalse;
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    string insertOptionQuery = "INSERT INTO tbl_option (OptionText, QuestionID) VALUES (@OptionText, @QuestionID); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(insertOptionQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@OptionText", "False"); // Insert 'False' option
                        cmd.Parameters.AddWithValue("@QuestionID", questionId);
                        optionIdFalse = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                bool isTrueSelected = rbtrue.Checked;
                int correctOptionId = isTrueSelected ? optionIdTrue : optionIdFalse;

                string insertAnswerQuery = "INSERT INTO tbl_answer (QuestionID, OptionID) VALUES (@QuestionID, @OptionID)";
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(insertAnswerQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@QuestionID", questionId);
                        cmd.Parameters.AddWithValue("@OptionID", correctOptionId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("True/False question and options inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTFFormFields();
            }
        }
        private void ClearTFFormFields()
        {
            txttfquestiontext.Clear();
            rbtrue.Checked = false;
            rbfalse.Checked = false;
        }
    }
}
