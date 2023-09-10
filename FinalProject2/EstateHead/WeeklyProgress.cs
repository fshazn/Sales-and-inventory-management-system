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
    public partial class WeeklyProgress : Form
    {
        public WeeklyProgress()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.panel_WeeklyProgress.Controls.Count > 0)
                this.panel_WeeklyProgress.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel_WeeklyProgress.Controls.Add(f);
            this.panel_WeeklyProgress.Tag = f;
            f.Show();

        }
        private void btn_addNewWeeklyProgress_Click(object sender, EventArgs e)
        {
            loadForm(new AddUpdateWeeklyProgress());
            btn_CancelWeeklyProgress.Visible = true;
        }

        private void WeeklyProgress_Load(object sender, EventArgs e)
        {   btn_CancelWeeklyProgress.Visible=false;
            loadForm(new ViewWeeklyProgress());
        }

        private void btn_CancelWeeklyProgress_Click(object sender, EventArgs e)
        {
            btn_CancelWeeklyProgress.Visible = false;
           loadForm(new ViewWeeklyProgress());
        }
    }
}
