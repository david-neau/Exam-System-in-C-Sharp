using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eems_desktop
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Close();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            admin_view_exam admin_view_exam = new admin_view_exam();
            admin_view_exam.Show();

            this.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            admin_view_user admin_view_user = new admin_view_user();
            admin_view_user.Show();
        }
    }
}
