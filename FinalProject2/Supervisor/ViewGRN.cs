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
    public partial class ViewGRN : Form
    {
        public ViewGRN()
        {
            InitializeComponent();
        }
        String grnno;
        private void ViewGRN_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            DG_ViewGRNItem.Visible = false;

        }
        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_GRN";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewGRN.Columns[0].DataPropertyName = "GrnNo";
                DG_ViewGRN.Columns[1].DataPropertyName = "PONo";
                DG_ViewGRN.Columns[2].DataPropertyName = "InNo";
                DG_ViewGRN.Columns[3].DataPropertyName = "GrnDate";
                DG_ViewGRN.Columns[4].DataPropertyName = "SupName";
                DG_ViewGRN.Columns[5].DataPropertyName = "AUName";
                DG_ViewGRN.Columns[6].DataPropertyName = "GrnComment";
                DG_ViewGRN.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DG_ViewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DG_ViewGRNItem.Visible = true;
          //  lbl_total.Visible = true;
            grnno = DG_ViewGRN.CurrentRow.Cells[0].Value.ToString();
            loadGRNItem();
            //calculateTotal();
        }
        private void loadGRNItem()
{
    try
    {
        Connection NewConnection = new Connection();
        NewConnection.DBConnection();
        String queryA = "Select RID,RawName,RawMUnit,GQty,GRNUnitPrice,GRNAmount from View_GRNItem where GNo = '" + grnno + "'";
        SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
        DataTable dtA = new DataTable();
        SqlDataAdapter daA = new SqlDataAdapter(cmdA);
        daA.Fill(dtA);
        DG_ViewGRNItem.Columns[0].DataPropertyName = "RID";
        DG_ViewGRNItem.Columns[1].DataPropertyName = "RawName";
        DG_ViewGRNItem.Columns[2].DataPropertyName = "GQty";
        DG_ViewGRNItem.Columns[3].DataPropertyName = "RawMUnit";
        DG_ViewGRNItem.Columns[4].DataPropertyName = "GRNUnitPrice";
        DG_ViewGRNItem.Columns[5].DataPropertyName = "GRNAmount";
        DG_ViewGRNItem.DataSource = dtA;
    }
    catch (SqlException)
    {
        MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
    }
}
