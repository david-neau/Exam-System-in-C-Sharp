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
    public partial class admin_view_result : Form
    {
        public admin_view_result()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard AdminDashboard = new AdminDashboard();
            AdminDashboard.Show();

            this.Hide();
        }
    }
}
