namespace COMP1004_DOLLARS_RAILL
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFormMainLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yourSelectionLabel = new System.Windows.Forms.Label();
            this.selectionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormMainLabel
            // 
            this.SelectFormMainLabel.AutoSize = true;
            this.SelectFormMainLabel.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFormMainLabel.Location = new System.Drawing.Point(41, 26);
            this.SelectFormMainLabel.Name = "SelectFormMainLabel";
            this.SelectFormMainLabel.Size = new System.Drawing.Size(456, 36);
            this.SelectFormMainLabel.TabIndex = 0;
            this.SelectFormMainLabel.Text = "Dollar Computer Hardware List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 475);
            this.dataGridView1.TabIndex = 1;
            // 
            // yourSelectionLabel
            // 
            this.yourSelectionLabel.AutoSize = true;
            this.yourSelectionLabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionLabel.Location = new System.Drawing.Point(42, 580);
            this.yourSelectionLabel.Name = "yourSelectionLabel";
            this.yourSelectionLabel.Size = new System.Drawing.Size(166, 27);
            this.yourSelectionLabel.TabIndex = 2;
            this.yourSelectionLabel.Text = "Your Selection";
            // 
            // selectionTextBox
            // 
            this.selectionTextBox.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionTextBox.Location = new System.Drawing.Point(214, 577);
            this.selectionTextBox.Name = "selectionTextBox";
            this.selectionTextBox.ReadOnly = true;
            this.selectionTextBox.Size = new System.Drawing.Size(576, 34);
            this.selectionTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(833, 574);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 39);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(956, 574);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(107, 39);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 638);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.selectionTextBox);
            this.Controls.Add(this.yourSelectionLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectFormMainLabel);
            this.Font = new System.Drawing.Font("Britannic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormMainLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label yourSelectionLabel;
        private System.Windows.Forms.TextBox selectionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}

