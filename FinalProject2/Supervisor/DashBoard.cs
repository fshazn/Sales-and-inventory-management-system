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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProject2.Supervisor
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {  
            loadProductChart();
            loadMaterialChart();
           countingDeliveries();
            countingCDeliveries();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void loadProductChart()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DataSet ds = new DataSet(); 
                String queryA = "Select ProName,ProQty from Product";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdA);
                adapter.Fill(ds);
                chart1.DataSource = ds;
                chart1.Series["Product"].XValueMember = "ProName";
                chart1.Series["Product"].YValueMembers = "ProQty";
                chart1.Titles.Add("Product");

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadMaterialChart()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DataSet ds = new DataSet();
                String queryA = "Select RawName,RawQty from RawMaterials";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdA);
                adapter.Fill(ds);
                chart2.DataSource = ds;
                chart2.Series["Raw Material"].XValueMember = "RawName";
                chart2.Series["Raw Material"].YValueMembers = "RawQty";
                chart2.Titles.Add("Raw Material");

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void countingDeliveries()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DataSet ds = new DataSet();
                String queryA = "Select Count (Dstatus) from DeliveryOrder where Dstatus = 'In Progress'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                object count = cmdA.ExecuteScalar();
                
                if (count != null) lbl_InProgressDeliveries.Text = count.ToString();
                cmdA.Dispose();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void countingCDeliveries()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DataSet ds = new DataSet();
                String queryA = "Select Count (Dstatus) from DeliveryOrder where Dstatus = 'Transferred'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                object count = cmdA.ExecuteScalar();

                if (count != null) lbl_CompletedDeliveries.Text = count.ToString();
                cmdA.Dispose();

            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
