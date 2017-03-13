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
    public partial class SelectForm : Form
    {
        public StartForm PreviousForm { get; set; }
        public SelectForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
