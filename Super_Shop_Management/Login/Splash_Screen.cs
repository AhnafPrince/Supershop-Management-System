using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management.Login
{
    public partial class Splash_Screen : Form
    {

        public Splash_Screen()
        {
            InitializeComponent();
        }

        
        private void s_timer_Tick_1(object sender, EventArgs e)
        {
            int flag = 0;
            s_timer.Start();
            s_progressBar.Value += 1;
            if (s_progressBar.Value == 100)
            {
                s_timer.Stop();
                this.Close();
            }
        }

    }
}
