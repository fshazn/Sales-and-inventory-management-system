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
    public partial class ProductScreen : Form
    {
        public ProductScreen()
        {
            InitializeComponent();
        }
        String proid,productid;
        private void ProductScreen_Load(object sender, EventArgs e)
        {
            lbl_p.Visible = false;
            lbl_Product.Visible = false;
            panel_AddProduct.Visible = false;
            DG_ProductStock.Visible = false;
            LoadDataGrid();

        }

        private void btn_addNewProduct_Click(object sender, EventArgs e)
        {
            
            panel_AddProduct.Visible = true;
            btn_Update.Visible = false;
            btn_CancelUpdate.Visible = true;
            btn_add.Visible = true;
            btn_cancel.Visible = false;
            loadProductID();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel_AddProduct.Visible = false;
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_productName.Text))
            {
                MessageBox.Show(this, "Product Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_productName.Focus();

            }
            else if (txt_Quantity.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Quantity Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quantity.Focus();
                txt_Quantity.Text = String.Empty;
            }
            else if (cmb_Munit.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Measurement Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Quantity.Text))
                {
                    try
                    {
                        Connection NewConnection = new Connection();
                        NewConnection.DBConnection();
                        DialogResult dialog = MessageBox.Show(" Are you sure you want to add this product?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            String query = "Insert into Product(ProID,ProName,ProQty, ProMUnit) values(@product_id, @productName,@proqty, @product_munit)";               
                            SqlCommand cmd = new SqlCommand(query, Connection.conn);
                            cmd.Parameters.AddWithValue("product_id", txt_productID.Text);
                            cmd.Parameters.AddWithValue("productName", txt_productName.Text);
                            cmd.Parameters.AddWithValue("proqty", txt_Quantity.Text);
                            cmd.Parameters.AddWithValue("product_munit", cmb_Munit.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();                          
                            MessageBox.Show("Product Added Successfuly..!");
                            LoadDataGrid();
                            loadProductID();
                            txt_productName.Text = "";
                            txt_Quantity.Text = "";
                            txt_productID.Focus();
                            cmb_Munit.Refresh();
                            cmd.Dispose();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    try
                    {
                        Connection NewConnection = new Connection();
                        NewConnection.DBConnection();
                        DialogResult dialog = MessageBox.Show(" Are you sure you want to add this product?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            String query = "Insert into Product(ProID,ProName,ProQty, ProMUnit) values(@product_id, @productName,@proqty, @product_munit)";
                            String query1 = "Insert into ProductStockLevel(AID,PID,ProductQty) values(@unitID,@pid,@qty)";
                            SqlCommand cmd = new SqlCommand(query, Connection.conn);
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            cmd.Parameters.AddWithValue("product_id", txt_productID.Text);
                            cmd.Parameters.AddWithValue("productName", txt_productName.Text);
                            cmd.Parameters.AddWithValue("proqty", txt_Quantity.Text);
                            cmd.Parameters.AddWithValue("product_munit", cmb_Munit.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                            cmd1.Parameters.AddWithValue("unitID", 1);
                            cmd1.Parameters.AddWithValue("pid", txt_productID.Text);
                            cmd1.Parameters.AddWithValue("qty", txt_Quantity.Text);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Product Added Successfuly..!");
                            LoadDataGrid();
                            loadProductID();
                            txt_productName.Text = "";
                            txt_Quantity.Text = "";
                            txt_productID.Focus();
                            cmb_Munit.Refresh();
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

        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from Product";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_Product.Columns[0].DataPropertyName = "ProID";
                DG_Product.Columns[1].DataPropertyName = "ProName";
                DG_Product.Columns[2].DataPropertyName = "ProQty";
                DG_Product.Columns[3].DataPropertyName = "ProMUnit";
                DG_Product.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadProductID()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ProID from Product order by ProID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    proid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    proid = ("0001");

                }
                else
                {
                    proid = ("0001");
                }
                txt_productID.Text = proid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_p.Visible = true;
            lbl_Product.Visible = true;
            DG_ProductStock.Visible = true;
            lbl_Product.Text = DG_Product.CurrentRow.Cells[1].Value.ToString();
            productid = DG_Product.CurrentRow.Cells[0].Value.ToString();
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "SELECT Unit.AUName, ProductStockLevel.ProductQty, Product.ProMUnit FROM Product INNER JOIN ProductStockLevel ON ProductStockLevel.PID = Product.ProID INNER JOIN Unit ON ProductStockLevel.AID = Unit.AUID  WHERE ProID ='" + productid + "' ";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ProductStock.Columns[0].DataPropertyName = "AUName";
                DG_ProductStock.Columns[1].DataPropertyName = "ProductQty";
                DG_ProductStock.Columns[2].DataPropertyName = "ProMUnit";
                DG_ProductStock.DataSource = dtA;
            }
            catch (SqlException)
            {

            }
        }
        int rowIndex;
        private void DG_Product_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_Product.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_Product.CurrentCell = DG_Product.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_Product, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
                productid = DG_Product.CurrentRow.Cells[0].Value.ToString();


            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_AddNewProduct.Visible = false;
            btn_addNewProduct.Visible = false;
            panel_AddProduct.Show();
            btn_Update.Visible = true;
            btn_CancelUpdate.Visible = true;
            btn_add.Visible = false;
            btn_cancel.Visible = false;
            String productid = DG_Product.CurrentRow.Cells[0].Value.ToString();
            txt_productID.Text = DG_Product.CurrentRow.Cells[0].Value.ToString();
            txt_productName.Text = DG_Product.CurrentRow.Cells[1].Value.ToString();
            txt_Quantity.Text = DG_Product.CurrentRow.Cells[2].Value.ToString();
            cmb_Munit.Text = DG_Product.CurrentRow.Cells[3].Value.ToString();

           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you update this product?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String query = "Update Product set ProName = '" + txt_productName.Text + "',ProQty = '" + txt_Quantity.Text + "',ProMUnit ='" + cmb_Munit.Text + "' where ProID ='" + txt_productID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfuly..!");
                    LoadDataGrid();
                    txt_productID.Text = "";
                    txt_productName.Text ="";
                    txt_Quantity.Text = "";
                    cmb_Munit.Text = "";

                    panel_AddProduct.Visible = false;
                    lbl_AddNewProduct.Visible = true;
                    btn_addNewProduct.Visible = true;

                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
               

        }

        private void btn_CancelUpdate_Click(object sender, EventArgs e)
        {
            txt_productID.Text = "";
            txt_productName.Text = "";
            txt_Quantity.Text = "";
            cmb_Munit.Text = "";
            panel_AddProduct.Visible=false;
            lbl_AddNewProduct.Visible=true;
            btn_addNewProduct.Visible=true;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to remove this product?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String query1 = "Delete from Product where ProID = '" + productid + "'";
                    SqlCommand cmd = new SqlCommand(query1, Connection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Removed Successfuly..!");
                    LoadDataGrid();

                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
