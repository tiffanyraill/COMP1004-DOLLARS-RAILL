using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_DOLLARS_RAILL
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            // 1. Instantiate the next form
            StartForm startForm = new StartForm();

            // 2. pass a reference to the current form to the next form
            startForm.PreviousForm = this;

            this.splashScreenTimer.Enabled = false;
            startForm.Show();
            this.Hide();
        }
    }
}
