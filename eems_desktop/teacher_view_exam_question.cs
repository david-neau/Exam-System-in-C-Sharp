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
    public partial class teacher_view_exam_question : Form
    {
        private int userId;
        private int examId;

        public teacher_view_exam_question(int userId, int examId)
        {
            InitializeComponent();
            this.userId = userId;
            this.examId = examId;
            LoadExamQuestions(examId);
        }

        private void LoadExamQuestions(int examId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load questions for the selected exam from tbl_question
                    string questionsQuery = "SELECT QuestionID, QuestionText FROM tbl_question WHERE ExamID = @ExamID";
                    using (SqlCommand questionsCommand = new SqlCommand(questionsQuery, connection))
                    {
                        questionsCommand.Parameters.AddWithValue("@ExamID", examId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(questionsCommand);
                        dataAdapter.Fill(dataTable);

                        dataGridExamQuestion.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void teacher_view_exam_question_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewExam_Click(object sender, EventArgs e)
        {
            add_new_question addNewQuestionForm = new add_new_question(userId, examId);
            addNewQuestionForm.ShowDialog();
            LoadExamQuestions(examId);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherDashboard teacherDashboardForm = new TeacherDashboard(userId);
            teacherDashboardForm.Show();
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
