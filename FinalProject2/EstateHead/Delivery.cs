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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }
        Connection NewConnection = new Connection();//Create Connection class object//
        String proid, mu,dno;
        String delstatus = "In Progress";
        String auid = LoginFrom.UserAid;

        private void Delivery_Load(object sender, EventArgs e)
        {
            loadDel();
            DG_DeliveryItems.Visible = false;
            panel_Delitems.Visible = false;
        }

        private void btn_placeNewDelivery_Click(object sender, EventArgs e)
        {
            panel_Delitems.Visible = true;
            loadProduct();
            loadDeliverNumber();
        }

        private void btn_CancelNewDelivery_Click(object sender, EventArgs e)
        {
            panel_Delitems.Visible=false;
        }
        private void loadProduct()
        {
            try
            {   
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

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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

        private void loadDeliverNumber()
        {
            String delid;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select DelNo from DeliveryOrder order by DelNo Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    delid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    delid = ("0001");

                }
                else
                {
                    delid = ("0001");
                }
                txt_DelNo.Text = delid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_addDelitem_Click(object sender, EventArgs e)
        {
            if (cmb_Product.SelectedItem == null)
            {
                MessageBox.Show("Please Select a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Product.Focus();
            }

            else if (string.IsNullOrEmpty(txt_Quantity.Text))
            {
                MessageBox.Show("Please enter product quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_Quantity.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Quantity Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quantity.Clear();
            }
            else
            {

               DG_NewDelitem.Rows.Add(proid, txt_DelNo.Text, cmb_Product.Text, txt_Quantity.Text, mu);
                cmb_Product.SelectedItem = null;
                txt_Quantity.Text = String.Empty;
            }
        }

        private void btn_SaveDelivery_Click(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to add this delivery?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    String query = "Insert into DeliveryOrder(DelNo,DelDate,Dstatus,AID) values(@delno, @deldate, @dstatus, @aid)";

                    SqlCommand cmd = new SqlCommand(query, Connection.conn);

                    cmd.Parameters.AddWithValue("delno", txt_DelNo.Text);
                    cmd.Parameters.AddWithValue("deldate", dtp_DelDate.Value.ToString());
                    cmd.Parameters.AddWithValue("dstatus", delstatus);
                    cmd.Parameters.AddWithValue("aid", auid);
                    cmd.ExecuteNonQuery();
                   for (int i = 0; i < DG_NewDelitem.Rows.Count; i++)
                    {
                        String query1 = "Insert into DeliveryItem(DNo,PID,DelQty) values('" + DG_NewDelitem.Rows[i].Cells[1].Value + "','" + DG_NewDelitem.Rows[i].Cells[0].Value + "','" + DG_NewDelitem.Rows[i].Cells[3].Value + "')";
                        SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                        cmd1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Delivery added successfuly..!", "Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDel();
                    loadDelitem();
                    cmd.Dispose();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_Deliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dno = DG_Deliveries.CurrentRow.Cells[0].Value.ToString();
            DG_DeliveryItems.Visible = true;
            loadDelitem();
        }

        private void loadDel()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select DelNo,DelDate,Dstatus from View_Delivery Where AID = '"+auid+"'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_Deliveries.Columns[0].DataPropertyName = "DelNo";
                DG_Deliveries.Columns[1].DataPropertyName = "DelDate";
                DG_Deliveries.Columns[2].DataPropertyName = "Dstatus";
                DG_Deliveries.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDelitem()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select ProName,DelQty,ProMUnit from View_DeliveryItem where DNo = '" + dno + "'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_DeliveryItems.Columns[0].DataPropertyName = "ProName";
                //DG_DeliveryItems.Columns[1].DataPropertyName = "DNo";
                DG_DeliveryItems.Columns[1].DataPropertyName = "DelQty";
                DG_DeliveryItems.Columns[2].DataPropertyName = "ProMUnit";
                DG_DeliveryItems.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
