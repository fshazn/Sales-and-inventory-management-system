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
    public partial class AddUpdateTransferRequest : Form
    {
        public AddUpdateTransferRequest()
        {
            InitializeComponent();
        }
        String proid,mu,estid;
       
        private void btn_CancelTransferRequest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUpdateTransferRequest_Load(object sender, EventArgs e)
        {   
            loadRequestFrom();
            LoadProduct();
            String reqid;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select RequestNo from TransferRequest order by RequestNo Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    reqid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    reqid = ("0001");

                }
                else
                {
                    reqid = ("0001");
                }
                txt_TRID.Text = reqid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadRequestFrom() //Load unit names into the Combo Box//
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from Unit Where AUID != '"+1+"'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Estate.Items.Add(dr["AUName"].ToString());
                    cmb_Estate.DisplayMember = (dr["AUName"].ToString());
                    cmb_Estate.ValueMember = (dr["AUID"].ToString());

                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadProduct() //Load product Names into the combo box//
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
                    cmb_Product.Items.Add(dr["ProName"].ToString());
                    cmb_Product.DisplayMember = (dr["ProName"].ToString());
                    cmb_Product.ValueMember = (dr["ProID"].ToString());

                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_addTrItem_Click(object sender, EventArgs e)
        {

            if (cmb_Product.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Product.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("Please Enter Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Quantity.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Quantity Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quantity.Clear();
            }
            else 
            {
                
                DG_TrItem.Rows.Add(proid,txt_TRID.Text, cmb_Product.Text, txt_Quantity.Text, mu);
                cmb_Product.SelectedItem = null;
                txt_Quantity.Text = String.Empty;
            }
            
        }
        int rowIndex;
        private void DG_TrItem_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_TrItem.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_TrItem.CurrentCell = DG_TrItem.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_TrItem, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DG_TrItem.Rows.RemoveAt(DG_TrItem.CurrentCell.RowIndex);
        }

        private void btn_CreateTR_Click(object sender, EventArgs e)
        {
            if (cmb_Estate.SelectedItem == null)
            {
                MessageBox.Show("Please select an Estate");
            }
            else if (DG_TrItem.Rows.Count == 0)
            {
                MessageBox.Show(this, "Add the products that you want to request!");

            }
            else 
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this transfer request?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into TransferRequest(RequestNo,RequestDate,AID,TrDescription) values(@reqNo, @reqD, @unit, @reqDesc)";
                        
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                       
                        cmd.Parameters.AddWithValue("reqNo", txt_TRID.Text);
                        cmd.Parameters.AddWithValue("reqD", dtp_RTDate.Value.ToString());
                        cmd.Parameters.AddWithValue("unit", estid);
                        cmd.Parameters.AddWithValue("reqDesc", txt_Description.Text);
                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < DG_TrItem.Rows.Count ; i++)
                        {
                            String query1 = "Insert into TransferRequestItems(PID,TRNo,TRQty) values('" + DG_TrItem.Rows[i].Cells[0].Value +"','"+ DG_TrItem.Rows[i].Cells[1].Value + "','"+ DG_TrItem.Rows[i].Cells[3].Value + "')";
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            cmd1.ExecuteNonQuery();
                        }
                        
                        MessageBox.Show("Transfer request added successfuly..!","Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmb_Estate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select AUID from Unit where AUName = '" + cmb_Estate.Text + "'";
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

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ProID,ProMUnit from Product where ProName = '" + cmb_Product.Text + "'";
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
    }
}
