using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class dashboard : Form
    {
        private bool isCollapsed;

        public dashboard()
        {
            InitializeComponent();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserAnalytics objUI = new UserAnalytics();
            objUI.Show();
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dashboard_logout(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are sure you want to logout","confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You are being logged out ..");
                this.Close();
            }
            else
            {
                MessageBox.Show("Operation cancelled by the user.");
            }
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_dropdown_Timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                dashboard_btn_user.Image = Resources.down_arrow;
                dashboard_panel_dropdown.Height += 10;
                if(dashboard_panel_dropdown.Size == dashboard_panel_dropdown.MaximumSize)
                {
                    dashboard_dropdown_Timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                dashboard_btn_user.Image = Resources.up_arrow;
                dashboard_panel_dropdown.Height -= 10;
                if (dashboard_panel_dropdown.Size == dashboard_panel_dropdown.MinimumSize)
                {
                    dashboard_dropdown_Timer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard_dropdown_Timer.Start();
        }
    }
}
