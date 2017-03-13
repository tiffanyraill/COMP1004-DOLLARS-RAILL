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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Getting Ready To Print...");
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Your Business!\n\n" + "Your Order will be Processed in 7-10 Business Days ");
            Application.Exit();
        }
    }
}
