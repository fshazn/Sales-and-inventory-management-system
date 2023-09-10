using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject2
{
    internal class Connection
    {
        public static SqlConnection conn = null;
        public void DBConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-HFCPIOL;Initial Catalog=Inventory4;Integrated Security=True");
            conn.Open();

        }
    }
}
