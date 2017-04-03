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
    public partial class ProductInfoForm : Form
    {
        public SelectForm PreviousForm { get; set; }
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

        private void _ProductInfoForm_Load(object sender, EventArgs e)
        {
            productIDTextBox.Text = Program.selectedProduct.productID.ToString();
            conditionTextBox.Text = Program.selectedProduct.condition;
            costTextBox.Text = Program.selectedProduct.cost.ToString("c2");

            platformTextBox.Text = Program.selectedProduct.platform;
            OSTextBox.Text = Program.selectedProduct.OS;
            manufacturerTextBox.Text = Program.selectedProduct.manufacturer;
            ModelTextBox.Text = Program.selectedProduct.model;

            memoryTextBox.Text = Program.selectedProduct.RAM_size;
            LCDSizeTextBox.Text = Program.selectedProduct.screensize;
            HDDTextBox.Text = Program.selectedProduct.HDD_speed;
            CPUBrandTextBox.Text = Program.selectedProduct.CPU_brand;
            CPUNumberTextBox.Text = Program.selectedProduct.CPU_number;
            GPUTypeTextBox.Text = Program.selectedProduct.GPU_Type;
            CPUTypeTextBox.Text = Program.selectedProduct.CPU_type;
            CPUSpeedTextBox.Text = Program.selectedProduct.CPU_speed;
            webCamTextBox.Text = Program.selectedProduct.webcam;
        }

        private void changeProductButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.Show();
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderform = new OrderForm();
            orderform.Show();
            this.Hide();
        }
    }
}
