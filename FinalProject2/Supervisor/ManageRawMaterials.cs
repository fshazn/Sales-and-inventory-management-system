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
    public partial class ManageRawMaterials : Form
    {
        public ManageRawMaterials()
        {
            InitializeComponent();
        }


        String UnitID;
        private void btn_addNewRawMat_Click(object sender, EventArgs e)
        {

            
            panel_AddRaw.Show();
            btn_addNewRawMat.Hide();
            String rawid;
            panel_AddRaw.Visible = true;
            btn_UpdateRawMat.Visible = false;
            btn_add.Visible = true;
            btn_CancelUpdate.Visible = false;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select RawID from RawMaterials order by RawID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    rawid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    rawid = ("0001");

                }
                else
                {
                    rawid = ("0001");
                }
                txt_rawMaterialID.Text = rawid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel_AddRaw.Hide();
            btn_addNewRawMat.Show();


        }

        private void ManageRawMaterials_Load(object sender, EventArgs e)
        {
            panel_AddRaw.Hide();
            DG_RawStock.Hide();
            lbl_r.Visible = false;
            lbl_RawMaterial.Visible = false;
            LoadDataGrid();
        }

        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from RawMaterials";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_RawMaterial.Columns[0].DataPropertyName = "RawID";
                DG_RawMaterial.Columns[1].DataPropertyName = "RawName";
                DG_RawMaterial.Columns[2].DataPropertyName = "RawQty";
                DG_RawMaterial.Columns[3].DataPropertyName = "RawMUnit";
                DG_RawMaterial.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rawMaterialName.Text))
            {
                MessageBox.Show(this, "Raw Material Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rawMaterialName.Focus();

            }

            else if (cmb_MeasurementUnit.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Measurement Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
            else
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this Raw Material?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        int qty = 0;
                        String query = "Insert into RawMaterials(RawID,RawName,RawQty,RawMUnit) values(@raw_id, @rawName,@rawqty,@raw_munit)";                        
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);                   
                        cmd.Parameters.AddWithValue("raw_id", txt_rawMaterialID.Text);
                        cmd.Parameters.AddWithValue("rawName", txt_rawMaterialName.Text);
                        cmd.Parameters.AddWithValue("rawqty", qty);
                        cmd.Parameters.AddWithValue("raw_munit", cmb_MeasurementUnit.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Raw Material Added Successfuly..!");
                        LoadDataGrid();
                        txt_rawMaterialID.Text = "";
                        txt_rawMaterialName.Text = "";
                        txt_rawMaterialName.Focus();
                        cmb_MeasurementUnit.Refresh();
                        cmd.Dispose();
                        panel_AddRaw.Visible = false;
                        btn_addNewRawMat.Visible = true;
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void DG_RawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_r.Visible = true;
            lbl_RawMaterial.Visible = true;
            lbl_r.Visible=true;
            DG_RawStock.Visible = true;
            loadRawStock();
            
        }
        int rowIndex;
        private void DG_RawMaterial_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_RawMaterial.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_RawMaterial.CurrentCell = DG_RawMaterial.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_RawMaterial, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_AddNewProduct.Visible = false;
            btn_addNewRawMat.Visible = false;
            panel_AddRaw.Show();
            btn_UpdateRawMat.Visible = true;
            btn_CancelUpdate.Visible = true;
            btn_add.Visible = false;
            btn_cancel.Visible = false;
            String productid = DG_RawMaterial.CurrentRow.Cells[0].Value.ToString();
            txt_rawMaterialID.Text = DG_RawMaterial.CurrentRow.Cells[0].Value.ToString();
            txt_rawMaterialName.Text = DG_RawMaterial.CurrentRow.Cells[1].Value.ToString();
            cmb_MeasurementUnit.Text = DG_RawMaterial.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_UpdateRawMat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you update this material?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String query = "Update RawMaterials set RawName = '" + txt_rawMaterialName.Text + "',RawMUnit ='" + cmb_MeasurementUnit.Text + "' where RawID ='" + txt_rawMaterialID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Material Details Updated Successfuly..!");
                    LoadDataGrid();
                    
                    txt_rawMaterialID.Text = "";
                    txt_rawMaterialName.Text = "";
                    cmb_MeasurementUnit.Text = "";

                    panel_AddRaw.Visible = false;
                    lbl_AddNewProduct.Visible = true;
                    btn_addNewRawMat.Visible = true;

                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public void loadRawStock()
        {
            lbl_RawMaterial.Text = DG_RawMaterial.CurrentRow.Cells[1].Value.ToString();
            String rawmatid = DG_RawMaterial.CurrentRow.Cells[0].Value.ToString();
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "SELECT Unit.AUName, RawMaterialsStockLevel.RQty, RawMaterials.RawMUnit FROM RawMaterials INNER JOIN RawMaterialsStockLevel ON RawMaterialsStockLevel.RID = RawMaterials.RawID INNER JOIN Unit ON RawMaterialsStockLevel.AID = Unit.AUID  WHERE RawID ='" + rawmatid + "' ";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_RawStock.Columns[0].DataPropertyName = "AUName";
                DG_RawStock.Columns[1].DataPropertyName = "RQty";
                DG_RawStock.Columns[2].DataPropertyName = "RawMUnit";
                DG_RawStock.DataSource = dtA;
            }
            catch (SqlException)
            {

            }
        }

        private void btn_CancelUpdate_Click(object sender, EventArgs e)
        {
            txt_rawMaterialID.Text = "";
            txt_rawMaterialName.Text = "";
            cmb_MeasurementUnit.Text = "";
            panel_AddRaw.Visible = false;
            lbl_AddNewProduct.Visible = true;
            btn_addNewRawMat.Visible = true;
        }
    }
}
