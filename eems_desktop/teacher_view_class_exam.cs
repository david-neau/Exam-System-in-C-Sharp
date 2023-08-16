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
    public partial class teacher_view_class_exam : Form
    {
        private int selectedClassId;

        public teacher_view_class_exam(int classId)
        {
            InitializeComponent();
            selectedClassId = classId;

            LoadExamsForClass(selectedClassId);
        }

        private void LoadExamsForClass(int classId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM tbl_exam WHERE ClassID = @ClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassID", classId);

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
        private void teacher_view_class_exam_Load(object sender, EventArgs e)
        {

        }
    }
}
