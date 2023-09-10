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
    public partial class AddUpdatewWeeklyPlan : Form
    {
        public AddUpdatewWeeklyPlan()
        {
            InitializeComponent();
        }
        String unitID,productID, activityID, acmUnit;
        private void AddUpdatewWeeklyPlan_Load(object sender, EventArgs e)
        {
            PlanKey();
            LoadUnitCombo();
            LoadProductCombo();
            LoadActivityCombo();
        }
        public void LoadUnitCombo()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from Unit";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Estate.Items.Add(dr["AUName"].ToString());
                    cmb_Estate.DisplayMember = (dr["AUName"].ToString());
                    cmb_Estate.ValueMember = (dr["AUID"].ToString());

                }
            }
            catch
            {

            }
        }
        public void LoadProductCombo()
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
                    cmb_Product.Items.Add(dr["ProName"].ToString());
                    cmb_Product.DisplayMember = (dr["ProName"].ToString());
                    cmb_Product.ValueMember = (dr["ProID"].ToString());

                }
            }
            catch
            {

            }
        }
        public void LoadActivityCombo()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select * from Activities";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Activity.Items.Add(dr["ACName"].ToString());
                    cmb_Activity.DisplayMember = (dr["ACName"].ToString());
                    cmb_Activity.ValueMember = (dr["ACID"].ToString());

                }
            }
            catch
            {

            }
        }

        private void cmb_Activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ACID,ACMUnit from Activities where ACName = '" + cmb_Activity.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    activityID = dr[0].ToString();
                    acmUnit = dr[1].ToString();
                }
            }
            catch
            {

            }
        }

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select ProID from Product where ProName = '" + cmb_Product.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    productID = dr[0].ToString();
                }
            }
            catch
            {

            }
        }

        

        private void cmb_Estate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select AUID from Unit where AUName = '" + cmb_Estate.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    unitID = dr[0].ToString();
                }
            }
            catch
            {

            }
        }

        public void PlanKey()
        {
            String proid;
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String query = "Select WPLID from WeeklyPlan order by WPLID Desc";
                SqlCommand cmd = new SqlCommand(query, Connection.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    proid = id.ToString("0000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    proid = ("0250");

                }
                else
                {
                    proid = ("0250");
                }
                txt_WPlanID.Text = proid.ToString();

                cmd.Dispose();
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AdditemWP_Click(object sender, EventArgs e)
        {
            if (cmb_Product.SelectedItem == null)
            {
                MessageBox.Show("Please Select a product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Product.Focus();
            }

            else if (string.IsNullOrEmpty(txt_WPitemAmount.Text))
            {
                MessageBox.Show("Please enter amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_WPitemAmount.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Amount cannot contain letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_WPitemAmount.Clear();
            }
            else
            {

                
                DG_WPitem.Rows.Add(activityID, cmb_Activity.Text,productID, cmb_Product.Text, txt_WPitemAmount.Text,acmUnit);
                cmb_Product.SelectedItem = null;
                txt_WPitemAmount.Text = String.Empty;
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                DialogResult dialog = MessageBox.Show(" Are you sure you want to add this Plan?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    String query = "Insert into WeeklyPlan(WPLID,WPLDate,WPLDueDate,WPLDescription,AID) values(@planID, @planDate, @planDueDate, @planDescription, @unitID)";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    cmd.Parameters.AddWithValue("planID", txt_WPlanID.Text);
                    cmd.Parameters.AddWithValue("planDate", dtp_WPlanDate.Value.ToString());
                    cmd.Parameters.AddWithValue("planDueDate", dtp_WPlanDueDate.Value.ToString());
                    cmd.Parameters.AddWithValue("planDescription", txt_WPlanDescription.Text);
                    cmd.Parameters.AddWithValue("unitID", unitID);
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < DG_WPitem.Rows.Count; i++)
                    {
                        String query1 = "Insert into WeeklyPlanLines(WPLaID,ACNo,PID,WPLAmount) values('"+txt_WPlanID.Text+"','" + DG_WPitem.Rows[i].Cells[0].Value + "','" + DG_WPitem.Rows[i].Cells[2].Value + "','" + DG_WPitem.Rows[i].Cells[4].Value + "')";
                        SqlCommand cmd1 = new SqlCommand(query1, Connection.conn);
                        cmd1.ExecuteNonQuery();
                    }

                    MessageBox.Show("Weekly Plan Added Successfuly..!");
                    
                    cmb_Activity.Refresh();
                    cmb_Estate.Refresh();
                    cmb_Product.Refresh();
                    txt_WPitemAmount.Text = "";
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
