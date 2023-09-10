using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject2.Manager
{
    public partial class ManagerScreen : Form
    {
        public ManagerScreen()
        {
            InitializeComponent();
            customizeDesign();
        }
        public void loadForm(object Form)
        {
            if (this.panel_Formcontainer.Controls.Count > 0)
                this.panel_Formcontainer.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_Formcontainer.Controls.Add(f);
            this.panel_Formcontainer.Tag = f;
            f.Show();

        }
        private void customizeDesign()
        {
            panel_SubInventory.Visible = false;
            panel_SubPurchasing.Visible = false;
            panel_PlanSubmenu.Visible = false;
            panel_Report.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel_SubInventory.Visible == true)
                panel_SubInventory.Visible = false;
            if (panel_SubPurchasing.Visible == true)
                panel_SubPurchasing.Visible = false;
            if (panel_PlanSubmenu.Visible == true)
                panel_PlanSubmenu.Visible = false;
            if (panel_Report.Visible == true)
                panel_Report.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_WeeklyProgress_Click(object sender, EventArgs e)
        {

        }

        private void btn_WeeklyPlan_Click(object sender, EventArgs e)
        {
            loadForm(new ViewWeeklyPlan());
            hideSubMenu();
        }

        private void btn_Plans_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_PlanSubmenu);
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {

        }

        private void btn_GRN_Click(object sender, EventArgs e)
        {
            loadForm(new ViewGRN());
            hideSubMenu();
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            loadForm(new ViewInvoice());
            hideSubMenu();
        }

        private void btn_PurchaseOrder_Click(object sender, EventArgs e)
        {
            loadForm(new ViewPO());
            hideSubMenu();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to close this programme ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubInventory);
        }

        private void btn_Purchasing_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_SubPurchasing);
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            loadForm(new Supervisor.SupervisorDelivery());
            hideSubMenu();
        }

        private void btn_RawMaterialReport_Click(object sender, EventArgs e)
        {
            loadForm(new Reports.RawMatReport());
            hideSubMenu();
        }

        private void btn_ProductReport_Click(object sender, EventArgs e)
        {
            loadForm(new Reports.ProductReport());
            hideSubMenu();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Report);
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

        }
    }
}
