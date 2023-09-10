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
    public partial class ViewPO : Form
    {
        public ViewPO()
        {
            InitializeComponent();
        }
        public static String ponumber;//to pass the poid to report form//
        private void ViewPO_Load(object sender, EventArgs e)
        {
            GD_RawPO.Hide();
            LoadPOdata();
        }

        private void LoadPOdata()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_PurchaseOrder";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_PO.Columns[0].DataPropertyName = "POID";
                DG_PO.Columns[1].DataPropertyName = "PODate";
                DG_PO.Columns[2].DataPropertyName = "SupName";
                DG_PO.Columns[3].DataPropertyName = "AUName"; 
                DG_PO.Columns[4].DataPropertyName = "POcomment";
                DG_PO.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_PO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String pono = DG_PO.CurrentRow.Cells[0].Value.ToString();
            GD_RawPO.Visible = true;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select RawName,POQty,RawMUnit,POUnitPrice,Amount from View_POItems where PONo = '" + pono+"'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                GD_RawPO.Columns[0].DataPropertyName = "RawName";
               // GD_RawPO.Columns[1].DataPropertyName = "PONo";
                GD_RawPO.Columns[1].DataPropertyName = "POQty"; 
                GD_RawPO.Columns[2].DataPropertyName = "RawMUnit";
                GD_RawPO.Columns[3].DataPropertyName = "POUnitPrice";
                GD_RawPO.Columns[4].DataPropertyName = "Amount";
                GD_RawPO.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int rowIndex;
        private void DG_PO_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_PO.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_PO.CurrentCell = DG_PO.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_PO, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ponumber = DG_PO.CurrentRow.Cells[0].Value.ToString();
            POReciept pr = new POReciept();
            pr.Show();

        }
    }
}
