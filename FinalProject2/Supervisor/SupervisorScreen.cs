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
    public partial class SupervisorScreen : Form
    {
        public SupervisorScreen()
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
        
        }
        private void hideSubMenu() 
        {
         if(panel_SubInventory.Visible == true)
                panel_SubInventory.Visible=false;
            if (panel_SubPurchasing.Visible == true)
                panel_SubPurchasing.Visible = false;
            if (panel_PlanSubmenu.Visible == true)
                panel_PlanSubmenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu) 
        {  if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else 
            {
                subMenu.Visible = false;
            }
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

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new Supervisor.DashBoard());
            hideSubMenu();
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {
            loadForm(new ProductScreen());
            hideSubMenu();
        }

        private void btn_TransferRequest_Click(object sender, EventArgs e)
        {
            loadForm(new TransferRequest());
            hideSubMenu();
        }

        private void btn_RawMaterials_Click(object sender, EventArgs e)
        {
            loadForm(new ManageRawMaterials());
            hideSubMenu();
        }

        private void btn_ProductRelease_Click(object sender, EventArgs e)
        {
            loadForm(new ProductRelease());
            hideSubMenu();
        }
       

        private void btn_Plans_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel_PlanSubmenu);
        }

        private void btn_WeeklyPlan_Click(object sender, EventArgs e)
        {
            loadForm(new WeeklyPlan());
            hideSubMenu();
        }

        private void btn_WeeklyProgress_Click(object sender, EventArgs e)
        {
            loadForm(new Supervisor.SWeeklyProgress());
            hideSubMenu();
        }

        private void btn_PurchaseOrder_Click(object sender, EventArgs e)
        {
            loadForm(new PurchaseOrder());
            hideSubMenu();
        }

        private void btn_GRN_Click(object sender, EventArgs e)
        {
            loadForm(new GRN());
            hideSubMenu();
        }

        private void btn_Invoices_Click(object sender, EventArgs e)
        {
            loadForm(new Invoices());
            hideSubMenu();
        }

        private void btn_Delivery_Click(object sender, EventArgs e)
        {
            loadForm(new Supervisor.SupervisorDelivery());
            hideSubMenu();
        }

        private void btn_Estates_Click(object sender, EventArgs e)
        {
            loadForm(new Estates());
            hideSubMenu();
        }

        private void btn_Suppliers_Click(object sender, EventArgs e)
        {
            loadForm(new Supervisor.Supplier());
            hideSubMenu();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(" Are you sure you want to log out?", "Link Naturals", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginFrom login = new LoginFrom();
                login.Show();
            }
              
        }

        private void SupervisorScreen_Load(object sender, EventArgs e)
        {
            loadForm(new Supervisor.DashBoard());
            hideSubMenu();
        }
    }
}
