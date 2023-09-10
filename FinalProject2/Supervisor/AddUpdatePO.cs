using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2
{
    public partial class AddUpdatePO : Form
    {
        public AddUpdatePO()
        {
            InitializeComponent();
        }
        Connection NewConnection = new Connection();//Create Connection class object//
        String supid, auid, rawid,mu; //use to get the ID's from combo boxes
        decimal amount=0;
        private void AddUpdatePO_Load(object sender, EventArgs e)
        {
            LoadPOID();
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
        private void LoadPOID() 
        {
            String poid;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select POID from PurchaseOrder order by POID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    poid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    poid = ("0001");

                }
                else
                {
                    poid = ("0001");
                }
                txt_POID.Text = poid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Selected Index used to select the id's from the combo boxes.//
        // When select a location from the combo box it automatically asign its id value to the variable declared.//
        private void cmb_DeliveryLocation_SelectedIndexChanged(object sender, EventArgs e)
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
        private void cmb_RawMaterial_SelectedIndexChanged(object sender, EventArgs e)
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
        private void cmb_Supplier_SelectedIndexChanged(object sender, EventArgs e)
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


        private void txt_UnitPrice_Leave(object sender, EventArgs e) // unit price text box eken leave weddi auto .00 add wenawa//
        {
            //CultureInfo cul = new CultureInfo("en-LK");
            //txt_UnitPrice.Text = String.Format(cul,"{0:C2}",decimal.Parse(txt_UnitPrice.Text));
            if (!string.IsNullOrEmpty(txt_UnitPrice.Text))
            {
                txt_UnitPrice.Text = string.Format("{0:#,##0.00}", double.Parse(txt_UnitPrice.Text));
            }
            else
            { }

            //txt_UnitPrice.Text =Amount.ToString("#,0.00");
        }

        // calculate total value of the purchasing items//
        private void calculateTotal()
        {
            decimal total=0;
            for (int i = 0; i < DG_POItem.Rows.Count; ++i)
            {
                total += Convert.ToInt32(DG_POItem.Rows[i].Cells[6].Value);
            }
            txt_total.Text = total.ToString();
            txt_total.Text = string.Format("{0:#,##0.00}", double.Parse(txt_total.Text));
        } 
          //Add purchasing items into data grid//
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
                DG_POItem.Rows.Add(rawid,txt_POID.Text, cmb_RawMaterial.Text,txt_Quantity.Text, mu,txt_UnitPrice.Text, amount);
                cmb_RawMaterial.SelectedItem = null;
                txt_Quantity.Text = String.Empty;
                txt_UnitPrice.Text = String.Empty;
                amount = 0;
                calculateTotal();
            }
        } 
        private void btn_SavePO_Click(object sender, EventArgs e)
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
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this purchase order?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into PurchaseOrder(POID,PODate,POComment,SupID,AID) values(@poid, @podate, @pocomment, @supid,@aid)";

                        SqlCommand cmd = new SqlCommand(query, Connection.conn);

                        cmd.Parameters.AddWithValue("poid", txt_POID.Text);
                        cmd.Parameters.AddWithValue("podate", dtp_PO.Value.ToString());
                        cmd.Parameters.AddWithValue("pocomment", txt_comment.Text);
                        cmd.Parameters.AddWithValue("supid", supid);
                        cmd.Parameters.AddWithValue("aid", auid);

                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < DG_POItem.Rows.Count; i++)
                        {
                            String query1 = "Insert into PurchaseOrderItem(PONo,RID,POQty,POUnitPrice,Amount) values('" + DG_POItem.Rows[i].Cells[1].Value +"','" + DG_POItem.Rows[i].Cells[0].Value + "','" + DG_POItem.Rows[i].Cells[3].Value + "','" + DG_POItem.Rows[i].Cells[5].Value + "','" + DG_POItem.Rows[i].Cells[6].Value + "')";
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            cmd1.ExecuteNonQuery();
                        }

                        MessageBox.Show("Purchase order added successfuly..!", "Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }  // Save Po into database//
    }
}
