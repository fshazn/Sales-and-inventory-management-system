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
    public partial class UpdateTransferRequest : Form
    {
        public UpdateTransferRequest()
        {
            InitializeComponent();
        }
        String UTRno,estid,proid,mu;
        //UTRNo use to get the Transfer Request ID from static variable in TransferRequest form//
        //esid use to store the AUID which is getting from the cmb_UpdateTREstate combo box//
        //proid is use to store the Product ID which is getting from the cmb_UpdateTRProduct combo box//
        //mu is use to store the Measurement unit which is getting from the cmb_UpdateTRProduct combo box//
        private void UpdateTransferRequest_Load(object sender, EventArgs e)
        {   
            UTRno = TransferRequest.UTRno;
            loadUpdateTREstate();
            loadUpdateTRProduct();
            //Getting Transfer Request Table Data//
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "SELECT * from TransferRequest Where RequestNo = '"+UTRno+"'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                SqlDataReader dr = cmdA.ExecuteReader();
                while (dr.Read())
                {
                    txt_UpdateTRID.Text = dr.GetValue(0).ToString();
                    txt_UpdateDescription.Text = dr.GetValue(3).ToString();
                
                }
            }
            catch (SqlException)
            {

            }
            //Getting Transferrequest Item Data//
            try
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String queryA = "SELECT Product.ProID,Product.ProName, Product.ProMUnit, TransferRequestItems.TRQty FROM Product INNER JOIN TransferRequestItems ON TransferRequestItems.PID = Product.ProID WHERE TRNo ='" + UTRno + "' ";
                    SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                    DataTable dtA = new DataTable();
                    SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                    daA.Fill(dtA);
                    DG_UpdateTRItem.Columns[0].DataPropertyName = "ProID";
                    DG_UpdateTRItem.Columns[1].DataPropertyName = UTRno;
                    DG_UpdateTRItem.Columns[2].DataPropertyName = "ProName";
                    DG_UpdateTRItem.Columns[3].DataPropertyName = "TRQty";
                    DG_UpdateTRItem.Columns[4].DataPropertyName = "ProMUnit";
                    DG_UpdateTRItem.DataSource = dtA;
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {

            }
        }
        //Getting Estates to the combo box in Update Transfer Request Form//
        public void loadUpdateTREstate() 
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from Unit Where AUID != '" + 1 + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_UpdateTREstate.Items.Add(dr["AUName"].ToString());
                    cmb_UpdateTREstate.DisplayMember = (dr["AUName"].ToString());
                    cmb_UpdateTREstate.ValueMember = (dr["AUID"].ToString());

                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        int rowIndex;
        private void DG_UpdateTRItem_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                DG_UpdateTRItem.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_UpdateTRItem.CurrentCell = DG_UpdateTRItem.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_UpdateTRItem, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DG_UpdateTRItem.Rows.RemoveAt(DG_UpdateTRItem.CurrentCell.RowIndex);
        }


        int indexRow;
        private void DG_UpdateTRItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            
            cmb_UpdateTRProduct.Text = DG_UpdateTRItem.CurrentRow.Cells[2].Value.ToString();
            txt_UpdateTRQuantity.Text = DG_UpdateTRItem.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_UpdateTRProduct_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DG_UpdateTRItem.Rows[indexRow];
            row.Cells[2].Value = cmb_UpdateTRProduct.Text;
            row.Cells[4].Value = txt_UpdateTRQuantity.Text;
        }

        //getting Product Names to the combo box in Update Transfer Request Form//
        public void loadUpdateTRProduct()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from Product";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_UpdateTRProduct.Items.Add(dr["ProName"].ToString());
                    cmb_UpdateTRProduct.DisplayMember = (dr["ProName"].ToString());
                    cmb_UpdateTRProduct.ValueMember = (dr["ProID"].ToString());

                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Getting Product ID using Product Combo box//
        private void cmb_UpdateTRProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ProID,ProMUnit from Product where ProName = '" + cmb_UpdateTRProduct.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    proid = dr[0].ToString();
                    mu = dr[1].ToString();
                }
            }
            catch
            {

            }
        }

        //Getting AUID using Estate Combo Box//
        private void cmb_UpdateTREstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select AUID from Unit where AUName = '" + cmb_UpdateTREstate.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    estid = dr[0].ToString();

                }
            }
            catch
            {

            }
        }
    }
}
