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
    public partial class SelectForm : Form
    {
        private product selectedProduct;
        public StartForm PreviousForm { get; set; } 

        public SelectForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputerDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputerDataSet.Products);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productForm = new ProductInfoForm();
            productForm.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dataGridView1.SelectedRows.Count > 0) // Checking to see if any cell is selected
            {
                string manufacturer = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string model = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string cost = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty; 
               

                selectionTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + ", " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString()
              + ", $ " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
            
                nextButton.Enabled = true;
            }
        }
    }

