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
    public partial class WeeklyPlan : Form
    {
        public WeeklyPlan()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.panel_WeeklyPlan.Controls.Count > 0)
                this.panel_WeeklyPlan.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_WeeklyPlan.Controls.Add(f);
            this.panel_WeeklyPlan.Tag = f;
            f.Show();

        }

        private void btn_createNewWeeklyPlan_Click(object sender, EventArgs e)
        {
            
            loadForm(new AddUpdatewWeeklyPlan());
            btn_CancelNewPlan.Visible = true;
        }

        private void WeeklyPlan_Load(object sender, EventArgs e)
        {
            btn_CancelNewPlan.Visible = false;
            loadForm(new ViewWeeklyPlan());
        }

        private void btn_CancelNewPlan_Click(object sender, EventArgs e)
        {
            btn_CancelNewPlan.Visible = false;
            loadForm(new ViewWeeklyPlan());
        }
    }
}
