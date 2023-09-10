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
    public partial class AddUpdateGRN : Form
    {
        public AddUpdateGRN()
        {
            InitializeComponent();
        }
        Connection NewConnection = new Connection();//Create Connection class object//
        String supid, auid, rawid, mu; //use to get the ID's from combo boxes
        decimal amount = 0;

        private void AddUpdateGRN_Load(object sender, EventArgs e)
        {
            loadGRNNumber();
            loadRawMaterial();
            LoadUnits();
            LoadSupplier();
        }
        // Load data into raw material combo box
        private void loadRawMaterial()
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
        // Load location in to combo box
        private void LoadUnits() 
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
        // Load suppliers into Supplier combo box//
        private void LoadSupplier() 
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
        private void loadGRNNumber()
        {

            String grnNumber;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select GrnNo from GRN order by GrnNo Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    grnNumber = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    grnNumber = ("0001");

                }
                else
                {
                    grnNumber = ("0001");
                }
                txt_GRNID.Text = grnNumber.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        



        //Selected Index used to select the id's from the combo boxes.//
        // When select a location from the combo box it automatically asign its id value to the variable declared.//
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
            for (int i = 0; i < DG_GRNItem.Rows.Count; ++i)
            {
                total += Convert.ToInt32(DG_GRNItem.Rows[i].Cells[6].Value);
            }
            txt_total.Text = total.ToString();
            txt_total.Text = string.Format("{0:#,##0.00}", double.Parse(txt_total.Text));
        }



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
                DG_GRNItem.Rows.Add(rawid, txt_GRNID.Text, cmb_RawMaterial.Text, txt_Quantity.Text, mu, txt_UnitPrice.Text, amount);
                cmb_RawMaterial.SelectedItem = null;
                txt_Quantity.Text = String.Empty;
                txt_UnitPrice.Text = String.Empty;
                amount = 0;
                calculateTotal();
            }
        }

        private void btn_SaveGrn_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrEmpty(txt_PONumber.Text))
            {
                MessageBox.Show("Please enter the PO number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_PONumber.Text.Any(char.IsLetter))
            {
                MessageBox.Show("PO number cannot contain letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PONumber.Clear();
            }
            else if (string.IsNullOrEmpty(txt_InvoiceNumber.Text))
            {
                MessageBox.Show("Please enter invoice number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_InvoiceNumber.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Invoice number cannot contain letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_InvoiceNumber.Clear();
            }
            else
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this GRN?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into GRN(GrnNo,GrnDate,GrnComment,PONo,SID,InNo,AID) values(@grnno, @grndate,@grncomment,@pono,@sid,@inno,@aid)";

                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                        cmd.Parameters.AddWithValue("grnno", txt_GRNID.Text);
                        cmd.Parameters.AddWithValue("grndate", dtp_Invoice.Value.ToString());
                        cmd.Parameters.AddWithValue("inno", txt_InvoiceNumber.Text);
                        cmd.Parameters.AddWithValue("sid", supid);
                        cmd.Parameters.AddWithValue("pono", txt_PONumber.Text);
                        cmd.Parameters.AddWithValue("aid", auid);
                        cmd.Parameters.AddWithValue("grncomment", txt_comment.Text);

                        cmd.ExecuteNonQuery();
                        for (int i = 0; i < DG_GRNItem.Rows.Count; i++)
                        {
                            String query1 = "Insert into GRNItems(GNo,RID,GQty,GRNUnitPrice,GRNAmount) values('" + DG_GRNItem.Rows[i].Cells[1].Value + "','" + DG_GRNItem.Rows[i].Cells[0].Value + "','" + DG_GRNItem.Rows[i].Cells[3].Value + "','" + DG_GRNItem.Rows[i].Cells[5].Value + "','" + DG_GRNItem.Rows[i].Cells[6].Value + "')";
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            cmd1.ExecuteNonQuery();
                        }
                        updateProduct();
                        MessageBox.Show("GRN added successfuly..!", "Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateProduct()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                //Mulinma e raw material eka e unit eke already thiyenawada nadda kiyala check karnawa
                for (int i = 0; i <= DG_GRNItem.Rows.Count - 1; i++)
                {   
                    String query = "Select * from RawMaterialsStockLevel Where RID = @rid and AID = @aid";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("@rid", DG_GRNItem.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@aid", auid);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        // thiyenawanm update karnawa
                        try
                        {
                            Connection NewConnection1 = new Connection();
                            NewConnection1.DBConnection();
                            for (int item = 0; item <= DG_GRNItem.Rows.Count - 1; item++)
                            {
                                String query1 = "Update RawMaterialsStockLevel set RQty = RQty + @rawqty Where RID = @rid and AID = @aid";
                                SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                                cmd1.Parameters.AddWithValue("@rawqty", DG_GRNItem.Rows[i].Cells[3].Value);
                                cmd1.Parameters.AddWithValue("@rid", DG_GRNItem.Rows[i].Cells[0].Value);
                                cmd1.Parameters.AddWithValue("@aid", auid);
                                cmd1.ExecuteNonQuery();

                            }
                        }

                        catch (SqlException)
                        {
                            MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //nathnam aluthin insert karnawa
                    else
                    {
                        try
                        {
                            Connection NewConnection2 = new Connection();
                            NewConnection.DBConnection();
                            for (int x = 0; x < DG_GRNItem.Rows.Count; x++)
                            {
                                String query1 = "Insert into RawMaterialsStockLevel(AID,RID,RQty) values('" + auid + "','" + DG_GRNItem.Rows[i].Cells[0].Value + "','" + DG_GRNItem.Rows[i].Cells[3].Value + "')";
                                SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                                cmd1.ExecuteNonQuery();
                            }
                            cmd.Dispose();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }



            }
            catch 
            { }
            //total raw material eka update karanawa
            try
            {
                try
                {
                    Connection NewConnection1 = new Connection();
                    NewConnection1.DBConnection();
                    for (int i = 0; i<= DG_GRNItem.Rows.Count - 1; i++)
                    {
                        String query1 = "Update RawMaterials set RawQty = RawQty + @rawqty Where RawID = @rid";
                        SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                        cmd1.Parameters.AddWithValue("@rawqty", DG_GRNItem.Rows[i].Cells[3].Value);
                        cmd1.Parameters.AddWithValue("@rid", DG_GRNItem.Rows[i].Cells[0].Value);
                        cmd1.ExecuteNonQuery();
                    }
                }

                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch 
            { }
           
        }

    }
}
