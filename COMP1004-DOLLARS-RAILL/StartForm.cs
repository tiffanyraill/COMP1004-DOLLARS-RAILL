///@DollarComputer Assignment #4 RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 3/12/2017
///@Description:multi-form project that simulates a computer purchase.
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
