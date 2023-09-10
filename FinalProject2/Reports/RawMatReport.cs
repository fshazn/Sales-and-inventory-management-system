using Microsoft.Reporting.WinForms;
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

namespace FinalProject2.Reports
{
    public partial class RawMatReport : Form
    {
        public RawMatReport()
        {
            InitializeComponent();
        }

        private void RawMatReport_Load(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from View_5";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet2 ds = new DataSet2();

                da.Fill(ds, "View_5");
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();

            }
            catch
            {

            }
            this.reportViewer1.RefreshReport();
        }
    }
}
