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

namespace FinalProject2.EstateHead
{
    public partial class EstateProduct : Form
    {
        public EstateProduct()
        {
            InitializeComponent();
        }
        String proid, mu;
        private void EstateProduct_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel5.Text = LoginFrom.UserAid;
            LoadDataGrid();
            loadProduct();
        }

        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select ProID,ProName,ProductQty,ProMUnit from View_EstateProduct Where AID = '"+ LoginFrom.UserAid + "'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_Product.Columns[0].DataPropertyName = "ProID";
                DG_Product.Columns[1].DataPropertyName = "ProName";
                DG_Product.Columns[2].DataPropertyName = "ProductQty";
                DG_Product.Columns[3].DataPropertyName = "ProMUnit";
                DG_Product.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addStock()
        { 
        
        }
        private void loadProduct()
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
                    cmb_Estateproduct.Items.Add(dr["ProName"].ToString());
                    cmb_Estateproduct.DisplayMember = (dr["ProName"].ToString());
                    cmb_Estateproduct.ValueMember = (dr["ProID"].ToString());


                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void cmb_Estateproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ProID,ProMUnit from Product where ProName = '" + cmb_Estateproduct.Text + "'";
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
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select PID,ProductQty from ProductStockLevel Where PID = '" + proid + "' and AID = '" + LoginFrom.UserAid + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int qty = Convert.ToInt32(txt_Quantity.Text);

                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        Connection NewConnection1 = new Connection();
                        NewConnection1.DBConnection();
                        String queryA = "Update ProductStockLevel set ProductQty = ProductQty+ @pqty Where PID = @pid and AID = @aid";
                        String queryB = "Update Product set ProQty = ProQty+ @pqty Where ProID = @proid";
                        SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                        SqlCommand cmdB = new SqlCommand(queryB, Connection.conn);
                        cmdA.Parameters.AddWithValue("@pqty", qty);
                        cmdA.Parameters.AddWithValue("pid", proid);
                        cmdA.Parameters.AddWithValue("aid", LoginFrom.UserAid);
                        cmdA.ExecuteNonQuery();
                        LoadDataGrid();
                        cmdB.Parameters.AddWithValue("@pqty", qty);
                        cmdB.Parameters.AddWithValue("proid", proid);
                        cmdB.ExecuteNonQuery();
                        MessageBox.Show("Product Stock Added!");

                        cmdA.Dispose();
                        cmdB.Dispose();

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
                        Connection NewConnection2 = new Connection();
                        NewConnection2.DBConnection();
               
  
                           
                            String query1 = "Insert into ProductStockLevel(AID,PID,ProductQty) values(@unitID,@pid,@qty)";
                            String query2 = "Update Product set ProQty = ProQty+ @pqty Where ProID = @proid";                        
                            SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                            SqlCommand cmd2 = new SqlCommand(query2, Connection.conn);                        
                            cmd1.Parameters.AddWithValue("unitID", LoginFrom.UserAid);
                            cmd1.Parameters.AddWithValue("pid", proid);
                            cmd1.Parameters.AddWithValue("qty", qty);
                            cmd1.ExecuteNonQuery();
                            cmd2.Parameters.AddWithValue("@pqty", qty);
                            cmd2.Parameters.AddWithValue("proid", proid);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Product Stock Added!");
                            LoadDataGrid();
                            txt_Quantity.Text = "";
                            cmb_Estateproduct.Refresh();
                            cmd.Dispose();
                        
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch
            {
            }
        }
    }
}
