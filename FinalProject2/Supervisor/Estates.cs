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
    public partial class Estates : Form
    {
        public Estates()
        {
            InitializeComponent();
        }
        private void Estates_Load(object sender, EventArgs e)
        {
            btn_Update.Visible = false;
            btn_CancelUpdate.Visible = false;
            LoadDataGrid();
        }
        private void btn_addNewEstate_Click(object sender, EventArgs e)
        {
            String auid;
            panel_AddEstates.Visible = true;
            btn_Update.Visible = false;
            btn_CancelUpdate.Visible = true;
            btn_add.Visible = true;
            btn_cancel.Visible = false;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select AUID from Unit order by AUID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    auid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    auid = ("0001");

                }
                else
                {
                    auid = ("0001");
                }
                txt_EstateID.Text = auid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EstateName.Text))
            {
                MessageBox.Show(this, "Estate Name Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EstateName.Focus();

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
            else if (string.IsNullOrEmpty(txt_Contact.Text))
            {
                MessageBox.Show(this, "Contact Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult dialog = MessageBox.Show(" Are you sure you want to add this Estate?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String query = "Insert into Unit(AUID,AUName,AUAddress,AUEmail,AUContact) values(@Estate_id, @EstateName,@Address, @Email, @Contact)";
                        SqlCommand cmd = new SqlCommand(query, Connection.conn);
                        cmd.Parameters.AddWithValue("Estate_id", txt_EstateID.Text);
                        cmd.Parameters.AddWithValue("EstateName", txt_EstateName.Text);
                        cmd.Parameters.AddWithValue("Address", txt_Address.Text);
                        cmd.Parameters.AddWithValue("Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("Contact", txt_Contact.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product Added Successfuly..!");

                        LoadDataGrid();
                        txt_EstateID.Text = "";
                        txt_EstateName.Text = "";
                        txt_Address.Text = "";
                        txt_Email.Text = "";
                        txt_Contact.Text = "";
                        txt_EstateID.Focus();
                        cmd.Dispose();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from Unit";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_Estates.Columns[0].DataPropertyName = "AUID";
                DG_Estates.Columns[1].DataPropertyName = "AUName";
                DG_Estates.Columns[2].DataPropertyName = "AUAddress";
                DG_Estates.Columns[3].DataPropertyName = "AUEmail";
                DG_Estates.Columns[4].DataPropertyName = "AUContact";
                DG_Estates.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
