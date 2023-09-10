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
    public partial class GRN : Form
    {
        public GRN()
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
        private void GRN_Load(object sender, EventArgs e)
        {
            loadForm(new ViewGRN());
            btn_CancelNewGRN.Visible = false;

        }

        private void btn_createNewGRN_Click(object sender, EventArgs e)
        {
            btn_CancelNewGRN.Visible = true;
            loadForm(new AddUpdateGRN());
        }

        private void btn_CancelNewGRN_Click(object sender, EventArgs e)
        {
            loadForm(new ViewGRN());
            
            btn_CancelNewGRN.Visible=false;
        }
    }
}
