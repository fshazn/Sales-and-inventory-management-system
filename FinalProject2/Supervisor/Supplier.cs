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
using System.Text.RegularExpressions;

namespace FinalProject2.Supervisor
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        String supid;
        private void Supplier_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            panel_AddSupplier.Visible = false;
            loadSupplierID();
        }
        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from Supplier";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_Suppliers.Columns[0].DataPropertyName = "SupID";
                DG_Suppliers.Columns[1].DataPropertyName = "SupName";
                DG_Suppliers.Columns[2].DataPropertyName = "SupAddress";
                DG_Suppliers.Columns[3].DataPropertyName = "SupEmail";
                DG_Suppliers.Columns[4].DataPropertyName = "SupContact";
                DG_Suppliers.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_addNewSupplier_Click(object sender, EventArgs e)
        {
            panel_AddSupplier.Visible = true;
            btn_Update.Visible = false;
            btn_CancelUpdate.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SupplierName.Text))
            {
                MessageBox.Show(this, "Supplier Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SupplierName.Focus();

            }
            else if (string.IsNullOrEmpty(txt_Address.Text))
            {
                MessageBox.Show(this, "Address Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Address.Focus();

            }
            else if (string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show(this, "Email Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();

            }
            else if (!Regex.IsMatch(txt_Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show(this, "Invalid Email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
                txt_Email.Text = String.Empty;
                
            }
            else if (string.IsNullOrEmpty(txt_Contact.Text))
            {
                MessageBox.Show(this, "Contact Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact.Focus();

            }
            else if (!Regex.IsMatch(txt_Contact.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show(this, "Invalid contact format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact.Focus();
            }
            else if (txt_Contact.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Contact Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contact.Focus();
            }


            else
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this Supplier?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into Supplier values(@Supplier_id,@SupplierName,@Address,@Email,@Contact)";
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                        cmd.Parameters.AddWithValue("Supplier_id", txt_SupplierID.Text);
                        cmd.Parameters.AddWithValue("SupplierName", txt_SupplierName.Text);
                        cmd.Parameters.AddWithValue("Address", txt_Address.Text);
                        cmd.Parameters.AddWithValue("Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("Contact", txt_Contact.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier Added Successfuly..!");

                        LoadDataGrid();
                        loadSupplierID();
                        txt_SupplierName.Text = "";
                        txt_Address.Text = "";
                        txt_Email.Text = "";
                        txt_Contact.Text = "";
                        txt_SupplierID.Focus();
                        cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void loadSupplierID()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select SupID from Supplier order by SupID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    supid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    supid = ("0001");

                }
                else
                {
                    supid = ("0001");
                }
                txt_SupplierID.Text = supid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel_AddSupplier.Visible = false;
        }
        int rowIndex;
        private void DG_Suppliers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_Suppliers.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_Suppliers.CurrentCell = DG_Suppliers.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_Suppliers, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_AddNewSupplier.Visible = false;
            btn_addNewSupplier.Visible = false;
            panel_AddSupplier.Show();
            btn_Update.Visible = true;
            btn_CancelUpdate.Visible = true;
            btn_add.Visible = false;
            btn_cancel.Visible = false;
            
            txt_SupplierID.Text = DG_Suppliers.CurrentRow.Cells[0].Value.ToString();
            txt_SupplierName.Text = DG_Suppliers.CurrentRow.Cells[1].Value.ToString();
            txt_Address.Text = DG_Suppliers.CurrentRow.Cells[2].Value.ToString();
            txt_Email.Text = DG_Suppliers.CurrentRow.Cells[3].Value.ToString();
            txt_Contact.Text = DG_Suppliers.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_CancelUpdate_Click(object sender, EventArgs e)
        {
            panel_AddSupplier.Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to update this Supplier?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    String query = "Update Supplier set SupName ='" + txt_SupplierName.Text+"', SupAddress ='"+txt_Address.Text+"', SupEmail ='"+txt_Email.Text+"', SupContact ='"+txt_Contact.Text+"' Where SupID = '"+txt_SupplierID.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Updated Successfuly..!");

                    LoadDataGrid();
                    txt_SupplierID.Text = "";
                    txt_SupplierName.Focus();
                    txt_SupplierName.Text = "";
                    txt_Address.Text = "";
                    txt_Email.Text = "";
                    txt_Contact.Text = "";
                    
                    cmd.Dispose();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to remove this Supplier?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    String query = "Delete from Supplier Where SupID = '"+ DG_Suppliers.CurrentRow.Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier Removed Successfuly..!");

                    LoadDataGrid();
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
