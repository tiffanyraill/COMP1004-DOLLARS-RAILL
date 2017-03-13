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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            //when user clicks "save" show dialog
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //file name
            string name = saveFileDialog1.FileName;
            
        }
    }
}
