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

namespace FinalProject2.Supervisor
{
    public partial class SupervisorDelivery : Form
    {
        public SupervisorDelivery()
        {
            InitializeComponent();
        }
        String dno;
        private void SupervisorDelivery_Load(object sender, EventArgs e)
        {
            loadDel();
            DG_ViewDeliveryItems.Visible = false;
            
        }
        private void loadDel()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from View_Delivery";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewDeliveries.Columns[0].DataPropertyName = "DelNo";
                DG_ViewDeliveries.Columns[2].DataPropertyName = "AID";
                DG_ViewDeliveries.Columns[3].DataPropertyName = "AUName";
                DG_ViewDeliveries.Columns[1].DataPropertyName = "DelDate";
                DG_ViewDeliveries.Columns[4].DataPropertyName = "Dstatus";
                DG_ViewDeliveries.DataSource = dtA;
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
                String queryA = "Select PID,ProName,DelQty,ProMUnit from View_DeliveryItem where DNo = '" + dno + "'";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_ViewDeliveryItems.Columns[0].DataPropertyName = "PID";
                DG_ViewDeliveryItems.Columns[1].DataPropertyName = "ProName";
                DG_ViewDeliveryItems.Columns[2].DataPropertyName = "DelQty";
                DG_ViewDeliveryItems.Columns[3].DataPropertyName = "ProMUnit";
                DG_ViewDeliveryItems.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DG_ViewDeliveries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dno = DG_ViewDeliveries.CurrentRow.Cells[0].Value.ToString();
            DG_ViewDeliveryItems.Visible = true;
            loadDelitem();
        }

        int rowIndex;
        private void DG_ViewDeliveries_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_ViewDeliveries.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_ViewDeliveries.CurrentCell = DG_ViewDeliveries.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_ViewDeliveries, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
                dno = DG_ViewDeliveries.CurrentRow.Cells[4].Value.ToString();
               
            }
        }

        private void transferGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Do you want to transfer these goods?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String query = "Select DStatus from DeliveryOrder Where DelNo = '" + dno + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        String Status = dt.Rows[0][0].ToString();
                        

                        // String Aid = dt.Rows[0][1].ToString();
                        if (Status == "In Progress")
                        {
                            MessageBox.Show("You have already transferred these goods into your stock!", "Link Naturals!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                         else if (Status == "Transferred")
                         {
                             try
                             {
                                 Connection NewConnection1 = new Connection();
                                 NewConnection1.DBConnection();
                                 String queryA = "Update DeliveryOrder set Dstatus = 'Transferred' Where DelNo = '" + dno + "'";
                                 SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);

                                 for (int i = 0; i <= DG_ViewDeliveryItems.Rows.Count - 1; i++)
                                 {
                                     String query1 = "Update ProductStockLevel set ProductQty = ProductQty + @pqty Where PID = @pid and AID = '1'";
                                     String query2 = "Update ProductStockLevel set ProductQty = ProductQty - @pdqty Where PID = @pdid and AID = @aid";
                                     SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                                     cmd1.Parameters.AddWithValue("@pqty", DG_ViewDeliveryItems.Rows[i].Cells[2].Value);
                                     cmd1.Parameters.AddWithValue("@pid", DG_ViewDeliveryItems.Rows[i].Cells[0].Value);
                                     cmd1.ExecuteNonQuery();
                                     SqlCommand cmd2 = new SqlCommand(query2, Connection.conn);
                                     cmd2.Parameters.AddWithValue("@pdqty", DG_ViewDeliveryItems.Rows[i].Cells[2].Value);
                                     cmd2.Parameters.AddWithValue("@pdid", DG_ViewDeliveryItems.Rows[i].Cells[0].Value);
                                     cmd2.Parameters.AddWithValue("@aid", dno);
                                     cmd2.ExecuteNonQuery();
                                 }
                                 cmdA.ExecuteNonQuery();
                                 MessageBox.Show("Goods transfered!");

                                 cmd.Dispose();

                             }
                             catch (SqlException)
                             {
                                 MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                         }

                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }
                

        }
        
    }
}
