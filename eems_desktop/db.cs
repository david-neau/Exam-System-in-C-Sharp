using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eems_desktop
{
    internal class db
    {
        private static string connectionString = "Data Source=DESKTOP-01B4F2C;Initial Catalog=eems;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}
