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

namespace FinalProject2
{
    public partial class POReciept : Form
    {
        public POReciept()
        {
            InitializeComponent();
        }

        private void POReciept_Load(object sender, EventArgs e)
        {

            reportViewer1.Reset();
            ReportDataSource ds1 = new ReportDataSource("DataSet1",PoDetail());
            ReportDataSource ds2 = new ReportDataSource("DataSet2", PoDetail1());
            reportViewer1.LocalReport.DataSources.Add(ds1);
            reportViewer1.LocalReport.DataSources.Add(ds2);
            reportViewer1.LocalReport.ReportPath = @"E:\Final Project\Visual Studio\FinalProject2\FinalProject2\Reports\POReciept.rdlc";
            this.reportViewer1.RefreshReport();


        }

        private DataTable PoDetail()
        {
            
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_9 Where POID = '"+ViewPO.ponumber+"'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataReader drA = cmdA.ExecuteReader();
                dtA.Load(drA);
                return dtA;

        }
        private DataTable PoDetail1()
        {

            Connection NewConnection = new Connection();
            NewConnection.DBConnection();
            String queryA = "Select * from View_10 Where PONo = '" + ViewPO.ponumber + "'";
            SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
            DataTable dtA = new DataTable();
            SqlDataReader drA = cmdA.ExecuteReader();
            dtA.Load(drA);
            return dtA;

        }

        private void btn_CancelGeneratePO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
