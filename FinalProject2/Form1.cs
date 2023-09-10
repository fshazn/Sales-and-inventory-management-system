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
    public partial class LoginFrom : Form
    {
        
        public LoginFrom()
        {
            InitializeComponent();
           
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public static String UserAid,Userid;
        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to close this programme ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                txt_Username.Text = "";
                txt_Username.ForeColor = Color.Black;
               

            }
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (txt_Username.Text == "")
            {
                txt_Username.Text = "Username";
                txt_Username.ForeColor = Color.Gray;


            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (txt_Password.Text == "Password")
            {
                txt_Password.Text = "";
                txt_Password.ForeColor = Color.Black;
                txt_Password.UseSystemPasswordChar = true;

            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Password";
                txt_Password.ForeColor = Color.Gray;


            }
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == true)
            {
                btn_ShowPassword.Hide();
                btn_HidePassword.Show();
                txt_Password.UseSystemPasswordChar=false;
                
            }
        }

        private void btn_HidePassword_Click(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar == false)
            {
                btn_ShowPassword.Show();
                btn_HidePassword.Hide();
                txt_Password.UseSystemPasswordChar = true;

            }
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            btn_HidePassword.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Username")
            {
                MessageBox.Show(this, "Please enter your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Username.Focus();

            }
            else if (txt_Password.Text == "Password")
            {
                MessageBox.Show(this, "Please enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Password.Focus();
            }
            else
            {
                try
                {
                    Connection NewConnection = new Connection();
                    NewConnection.DBConnection();
                    String query = "Select * from Users Where UserUsername = '" + txt_Username.Text + "' AND  UserPassword = '" + txt_Password.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Connection.conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        String UserRole = dt.Rows[0][1].ToString();
                         Userid = dt.Rows[0][0].ToString();
                        UserAid = dt.Rows[0][7].ToString();
                        if (UserRole == "Supervisor")
                        {
                            SupervisorScreen sc = new SupervisorScreen();
                            sc.Show();
                            this.Hide();
                        }
                        else if (UserRole == "Manager")
                        {
                            Manager.ManagerScreen msc = new Manager.ManagerScreen();
                            msc.Show();
                            this.Hide();
                        }
                        else if (UserRole == "EstateHead")
                        {
                            EstateHead.EstateHeadScreen esc = new EstateHead.EstateHeadScreen();
                            esc.Show();
                            this.Hide();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Invaild UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Username.Clear();
                        txt_Password.Clear();
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
