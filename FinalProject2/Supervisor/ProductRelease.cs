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
    public partial class ProductRelease : Form
    {
        public ProductRelease()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.panel_Prodcutrelease.Controls.Count > 0)
                this.panel_Prodcutrelease.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_Prodcutrelease.Controls.Add(f);
            this.panel_Prodcutrelease.Tag = f;
            f.Show();

        }

        private void btn_addNewProductRelease_Click(object sender, EventArgs e)
        {
            loadForm(new AddUpdateProductRelease());
            
        }
    }
}
