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
    public partial class StartForm : Form
    {
        public SplashScreen PreviousForm { get; set; }
        public StartForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //instantiate next form
            SelectForm selectForm = new SelectForm();
            selectForm.PreviousForm = this;
            selectForm.Show();
            //hide current form
            this.Hide();
        }
    }
}
