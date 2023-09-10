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
    public partial class ViewTransferRequestItem : Form
    {
        String tr; //Transfer request Number asign to this variable from Transfer Request Form//
        String trun; // Estate id AID from Transfer request Data grid will asign to this variable//
        public ViewTransferRequestItem()
        {
            InitializeComponent();
            
        }

       


        private void ViewTransferRequestItem_Load(object sender, EventArgs e)
        {
            tr = TransferRequest.TRno;
            trun = TransferRequest.TRUnit;
            
            
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "SELECT Product.ProID,Product.ProName, Product.ProMUnit, TransferRequestItems.TRQty FROM Product INNER JOIN TransferRequestItems ON TransferRequestItems.PID = Product.ProID WHERE TRNo ='" + tr + "' ";
                String queryB = "SELECT AUName from Unit Where AUID = '"+trun+"'";
                //String queryA = "SELECT Product.ProID,Product.ProName, Product.ProMUnit,TransferRequest.RequestNo, TransferRequestItems.TRQty FROM Product INNER JOIN TransferRequestItems ON TransferRequestItems.PID = Product.ProID INNER JOIN TransferRequest ON TransferRequestItems.TRNo = TransferRequest.RequestNo WHERE RequestNo ='" + tr + "' ";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                SqlCommand cmdB = new SqlCommand(queryB, Connection.conn);
                DataTable dtA = new DataTable();
                DataTable dtB = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_TrItemView.Columns[0].DataPropertyName = "ProID";
                DG_TrItemView.Columns[1].DataPropertyName = "ProName";
                DG_TrItemView.Columns[2].DataPropertyName = "TRQty";
                DG_TrItemView.Columns[3].DataPropertyName = "ProMUnit";
                SqlDataReader dr = cmdB.ExecuteReader();
                while (dr.Read())
                { 
                  lbl_rfrom.Text = dr.GetValue(0).ToString();
                }

                DG_TrItemView.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
