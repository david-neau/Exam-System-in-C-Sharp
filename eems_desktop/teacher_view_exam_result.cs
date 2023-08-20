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
    public partial class teacher_view_exam_result : Form
    {
        private int UserId;
        private int ExamId;

        public teacher_view_exam_result(int userId, int examId)
        {
            InitializeComponent();

            UserId = userId;
            ExamId = examId;
            LoadExamResults();
        }
        private void LoadExamResults()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Load exam results for the specified examId
                    string query = "SELECT a.AttemptID, u.FirstName + ' ' + u.LastName AS StudentName, a.UserID, " +
                                   "e.ExamName, e.StartDateTime, e.EndDateTime, er.CorrectResponses, " +
                                   "q.TotalQuestions " +
                                   "FROM tbl_attempt a " +
                                   "INNER JOIN tbl_user u ON a.UserID = u.UserID " +
                                   "INNER JOIN tbl_exam e ON a.ExamID = e.ExamID " +
                                   "LEFT JOIN (SELECT AttemptID, COUNT(*) AS CorrectResponses " +
                                   "           FROM tbl_response r " +
                                   "           INNER JOIN tbl_answer ans ON r.QuestionID = ans.QuestionID AND r.OptionID = ans.OptionID " +
                                   "           GROUP BY AttemptID) er ON a.AttemptID = er.AttemptID " +
                                   "LEFT JOIN (SELECT ExamID, COUNT(*) AS TotalQuestions FROM tbl_question GROUP BY ExamID) q ON e.ExamID = q.ExamID " +
                                   "WHERE e.ExamID = @ExamID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ExamID", ExamId);

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);

                        dgvExamResults.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teacher_view_exam_result_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TeacherDashboard teacherDashboardForm = new TeacherDashboard(UserId);
            teacherDashboardForm.Show();
            this.Close();
        }
    }
}
