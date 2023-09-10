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
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.panel_PO.Controls.Count > 0)
                this.panel_PO.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_PO.Controls.Add(f);
            this.panel_PO.Tag = f;
            f.Show();

        }
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            loadForm(new ViewPO());
            btn_CancelNewPO.Visible = false;
        }

        private void btn_createNewPO_Click(object sender, EventArgs e)
        {
            loadForm(new AddUpdatePO());
            btn_CancelNewPO.Visible = true;
        }

        private void btn_CancelNewPO_Click(object sender, EventArgs e)
        {
            loadForm(new ViewPO());
            btn_CancelNewPO.Visible = false;
        }
    }
}
