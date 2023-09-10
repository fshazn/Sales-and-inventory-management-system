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
    public partial class AddUpdateInvoice : Form
    {
        public AddUpdateInvoice()
        {
            InitializeComponent();
        }
        Connection NewConnection = new Connection();//Create Connection class object//
        String supid, auid, rawid, mu; //use to get the ID's from combo boxes
        decimal amount = 0;
        private void AddUpdateInvoice_Load(object sender, EventArgs e)
        {
            loadInvoiceNumber();
            loadRawMaterial();
            LoadUnits();
            LoadSupplier();
        }

        private void loadRawMaterial()// Load data into raw material combo box
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select * from RawMaterials";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_RawMaterial.Items.Add(dr["RawName"].ToString());
                    cmb_RawMaterial.DisplayMember = (dr["RawName"].ToString());
                    cmb_RawMaterial.ValueMember = (dr["RawID"].ToString());


                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUnits() // Load location in to combo box
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select * from Unit";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_DeliveryLocation.Items.Add(dr["AUName"].ToString());
                    cmb_DeliveryLocation.DisplayMember = (dr["AUName"].ToString());
                    cmb_DeliveryLocation.ValueMember = (dr["AUID"].ToString());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadSupplier() // Load suppliers into Supplier combo box//
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select * from Supplier";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Supplier.Items.Add(dr["SupName"].ToString());
                    cmb_Supplier.DisplayMember = (dr["SupName"].ToString());
                    cmb_Supplier.ValueMember = (dr["SupID"].ToString());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadInvoiceNumber()
        {

            String invoiceNumber;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select INo from SupplierInvoice order by INo Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    invoiceNumber = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    invoiceNumber = ("0001");

                }
                else
                {
                    invoiceNumber = ("0001");
                }
                txt_InvoiceID.Text = invoiceNumber.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Selected Index used to select the id's from the combo boxes.//
        // When select a location from the combo box it automatically asign its id value to the variable declared.//

        private void cmb_RawMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select RawID,RawMUnit from RawMaterials where RawName = '" + cmb_RawMaterial.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rawid = dr[0].ToString();
                    mu = dr[1].ToString();
                }
            }
            catch
            {

            }
        }

        private void cmb_Supplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select SupID from Supplier where SupName = '" + cmb_Supplier.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    supid = dr[0].ToString();
                }
            }
            catch
            {
            }
        }

        private void cmb_DeliveryLocation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                NewConnection.DBConnection();
                String query = "Select AUID from Unit where AUName = '" + cmb_DeliveryLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auid = dr[0].ToString();
                }
            }
            catch
            {
            }
        }

       

        private void txt_UnitPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_UnitPrice.Text))
            {
                txt_UnitPrice.Text = string.Format("{0:#,##0.00}", double.Parse(txt_UnitPrice.Text));
            }
            else
            { }
        }
        // calculate total value of the invoice items//
        private void calculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < DG_InvoiceItem.Rows.Count; ++i)
            {
                total += Convert.ToInt32(DG_InvoiceItem.Rows[i].Cells[7].Value);
            }
            txt_total.Text = total.ToString();
            txt_total.Text = string.Format("{0:#,##0.00}", double.Parse(txt_total.Text));
        } 

        //Add invoice items into data grid//
        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            if (cmb_RawMaterial.SelectedItem == null)
            {
                MessageBox.Show("Please Select a material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_RawMaterial.Focus();
            }

            else if (string.IsNullOrEmpty(txt_UnitPrice.Text))
            {
                MessageBox.Show("Please Enter Unit Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                amount = Convert.ToInt32(txt_Quantity.Text) * Convert.ToDecimal(txt_UnitPrice.Text);
                DG_InvoiceItem.Rows.Add(rawid, txt_InvoiceID.Text,txt_PONumber.Text, cmb_RawMaterial.Text, txt_Quantity.Text, mu, txt_UnitPrice.Text, amount);
                cmb_RawMaterial.SelectedItem = null;
                txt_Quantity.Text = String.Empty;
                txt_UnitPrice.Text = String.Empty;
                amount = 0;
                calculateTotal();
            }
        }
        private void btn_SaveInvoice_Click(object sender, EventArgs e)
        {
            if (cmb_Supplier.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Supplier.Focus();
            }
            else if (cmb_DeliveryLocation.SelectedItem == null)
            {
                MessageBox.Show("Please Select a location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_DeliveryLocation.Focus();
            }
            else if (cmb_DeliveryLocation.SelectedItem == null)
            {
                MessageBox.Show("Please Select a location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_DeliveryLocation.Focus();
            }
            else
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this supplier invoice?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into SupplierInvoice(INo,IDate,SID,PONo,AID,IComment) values(@ino, @idate, @sid, @pono,@aid,@icomment)";
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                        cmd.Parameters.AddWithValue("ino", txt_InvoiceID.Text);
                        cmd.Parameters.AddWithValue("idate", dtp_Invoice.Value.ToString());
                        cmd.Parameters.AddWithValue("sid", supid);
                        cmd.Parameters.AddWithValue("pono", txt_PONumber.Text);
                        cmd.Parameters.AddWithValue("aid", auid);
                        cmd.Parameters.AddWithValue("icomment", txt_comment.Text);
                        cmd.ExecuteNonQuery();
                      for (int i = 0; i < DG_InvoiceItem.Rows.Count; i++)
                        {
                            String query1 = "Insert into SUpllierInvoiceItem(InvNo,RID,IQty,IUnitPrice,IAmount) values('" + DG_InvoiceItem.Rows[i].Cells[1].Value + "','" + DG_InvoiceItem.Rows[i].Cells[0].Value + "','" + DG_InvoiceItem.Rows[i].Cells[4].Value + "','" + DG_InvoiceItem.Rows[i].Cells[6].Value + "','" + DG_InvoiceItem.Rows[i].Cells[7].Value + "')";
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            cmd1.ExecuteNonQuery();
                        }
                        MessageBox.Show("Supplier invoice added successfuly..!", "Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
