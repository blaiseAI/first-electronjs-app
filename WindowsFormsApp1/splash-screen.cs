using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();

        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            //this.ClientSize = this.BackgroundImage.Size;
        }

       

        private void splash_screen_Timer_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
