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
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }
        String ino;
        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            DG_ViewInvoiceItem.Visible = false;
            bunifuCustomLabel4.Visible = false;
            lbl_total.Visible = false;
        }
        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_Invoice";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewInvoice.Columns[0].DataPropertyName = "INo";
                DG_ViewInvoice.Columns[1].DataPropertyName = "SupName";
                DG_ViewInvoice.Columns[2].DataPropertyName = "IDate";
                DG_ViewInvoice.Columns[3].DataPropertyName = "AUName";
                DG_ViewInvoice.Columns[4].DataPropertyName = "IComment";
                DG_ViewInvoice.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadInvoiceItem()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_InvoiceItems where InvNo = '" + ino + "'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewInvoiceItem.Columns[0].DataPropertyName = "RawID";
                DG_ViewInvoiceItem.Columns[1].DataPropertyName = "RawName";
                DG_ViewInvoiceItem.Columns[2].DataPropertyName = "IQty";
                DG_ViewInvoiceItem.Columns[3].DataPropertyName = "RawMUnit";
                DG_ViewInvoiceItem.Columns[4].DataPropertyName = "IUnitPrice";
                DG_ViewInvoiceItem.Columns[5].DataPropertyName = "IAmount";
                DG_ViewInvoiceItem.Columns[6].DataPropertyName = "InvNo";

                DG_ViewInvoiceItem.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DG_ViewInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DG_ViewInvoiceItem.Visible = true;
            bunifuCustomLabel4.Visible = true;
            lbl_total.Visible = true;
            ino = DG_ViewInvoice.CurrentRow.Cells[1].Value.ToString();
            loadInvoiceItem();
            calculateTotal();
        }

        private void calculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < DG_ViewInvoiceItem.Rows.Count; ++i)
            {
                total += Convert.ToInt32(DG_ViewInvoiceItem.Rows[i].Cells[5].Value);
            }
            lbl_total.Text = total.ToString();
            lbl_total.Text = string.Format("{0:#,##0.00}", double.Parse(lbl_total.Text));
        }
    }
}
