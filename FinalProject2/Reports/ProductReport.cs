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
    public partial class ProductReport : Form
    {
        public ProductReport()
        {
            InitializeComponent();
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from View_ProductStockLevel";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet3 ds1 = new DataSet3();

                da.Fill(ds1,"View_ProductStockLevel");
                ReportDataSource datasource1 = new ReportDataSource("DataSet1", ds1.Tables[0]);
                this.reportViewer2.LocalReport.DataSources.Clear();

                this.reportViewer2.LocalReport.DataSources.Add(datasource1);
                this.reportViewer2.RefreshReport();

            }
            catch
            {

            }
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
