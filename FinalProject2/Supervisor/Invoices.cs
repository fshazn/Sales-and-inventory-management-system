using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.panel_GRN.Controls.Count > 0)
                this.panel_GRN.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_GRN.Controls.Add(f);
            this.panel_GRN.Tag = f;
            f.Show();

        }
        private void Invoices_Load(object sender, EventArgs e)
        {
            btn_CancelNewInvoice.Visible = false;
            loadForm(new ViewInvoice());

        }

        private void btn_createNewInvoice_Click(object sender, EventArgs e)
        {
            loadForm(new AddUpdateInvoice());
            btn_CancelNewInvoice.Visible = true;
        }

        private void btn_CancelNewInvoice_Click(object sender, EventArgs e)
        {
            loadForm(new ViewInvoice());
            btn_CancelNewInvoice.Visible = false;
        }
    }
}
