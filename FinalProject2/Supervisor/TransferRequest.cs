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
    public partial class TransferRequest : Form
    {
        
        public TransferRequest()
        {
            InitializeComponent();
        }
        public static String TRno = "";
        public static String TRUnit = "";
        public static String UTRno = "";
        public void loadForm1(object Form)
        {
            if (this.panel_TransferRequest.Controls.Count > 0)
                this.panel_TransferRequest.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            
            f.Dock = DockStyle.Fill;
            this.panel_TransferRequest.Controls.Add(f);
            this.panel_TransferRequest.Tag = f;
            f.Show();

        }

        private void btn_addNewTransferRequest_Click(object sender, EventArgs e)
        {
            loadForm1(new AddUpdateTransferRequest());
        }

        private void DG_TransferRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TRno = DG_TransferRequest.CurrentRow.Cells[0].Value.ToString();
            TRUnit = DG_TransferRequest.CurrentRow.Cells[2].Value.ToString();
            loadForm1(new ViewTransferRequestItem());
        }

        private void TransferRequest_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            try
            {
                Connection NewConnection = new Connection();
                NewConnection.DBConnection();
                String queryA = "Select * from TransferRequest";
                SqlCommand cmdA = new SqlCommand(queryA, Connection.conn);
                DataTable dtA = new DataTable();
                SqlDataAdapter daA = new SqlDataAdapter(cmdA);
                daA.Fill(dtA);
                DG_TransferRequest.Columns[0].DataPropertyName = "RequestNo";
                DG_TransferRequest.Columns[1].DataPropertyName = "RequestDate";
                DG_TransferRequest.Columns[2].DataPropertyName = "AID";
                DG_TransferRequest.Columns[3].DataPropertyName = "TrDescription";
                DG_TransferRequest.DataSource = dtA;
            }
            catch (SqlException)
            {
                MessageBox.Show(this, "Database Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {   UTRno = DG_TransferRequest.CurrentRow.Cells[0].Value.ToString();
            loadForm1(new UpdateTransferRequest());
        }
        int rowIndex;
        private void DG_TransferRequest_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DG_TransferRequest.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                DG_TransferRequest.CurrentCell = DG_TransferRequest.Rows[e.RowIndex].Cells[0];
                contextMenuStrip1.Show(DG_TransferRequest, e.Location);
                contextMenuStrip1.Show(Cursor.Position);



            }
        }
    }
}
