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
    public partial class ViewWeeklyPlan : Form
    {
        public ViewWeeklyPlan()
        {
            InitializeComponent();
        }

        private void ViewWeeklyPlan_Load(object sender, EventArgs e)
        {
            loadWeeklyPlan();
            DG_ViewWeeklyPlanItem.Visible = false;
        }
        private void loadWeeklyPlan()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_WeeklyPlan";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_WeeklyPlan.Columns[0].DataPropertyName = "WPLID";
                DG_WeeklyPlan.Columns[1].DataPropertyName = "AUName";
                DG_WeeklyPlan.Columns[2].DataPropertyName = "WPLDate";
                DG_WeeklyPlan.Columns[3].DataPropertyName = "WPLDueDate";
                DG_WeeklyPlan.Columns[4].DataPropertyName = "WPLDescription";
                DG_WeeklyPlan.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void DG_WeeklyPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DG_ViewWeeklyPlanItem.Visible = true;

            String planid = DG_WeeklyPlan.CurrentRow.Cells[0].Value.ToString();
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select ACName,ProName,WPLAmount,ACMUnit from View_WeeklyPlanitem  Where WPLaID='" + planid + "' ";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewWeeklyPlanItem.Columns[0].DataPropertyName = "ACName";
                DG_ViewWeeklyPlanItem.Columns[1].DataPropertyName = "ProName";
                DG_ViewWeeklyPlanItem.Columns[2].DataPropertyName = "WPLAmount";
                DG_ViewWeeklyPlanItem.Columns[3].DataPropertyName = "ACMUnit";
                DG_ViewWeeklyPlanItem.DataSource = dtA;
            }//
            catch (SqlException)
            {

            }
        }
        private void loadWeeklyPlanItem()
        {
            

        }
    }
}
