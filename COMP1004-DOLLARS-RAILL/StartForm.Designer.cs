namespace COMP1004_DOLLARS_RAILL
{
    partial class StartForm
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
            this.newOrderButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.startForm_Label = new System.Windows.Forms.Label();
            this.startFormLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startFormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(106, 250);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 35);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "Start a New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(106, 291);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(193, 35);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open a Saved Order";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(106, 332);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(193, 35);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // startForm_Label
            // 
            this.startForm_Label.AutoSize = true;
            this.startForm_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startForm_Label.Location = new System.Drawing.Point(45, 9);
            this.startForm_Label.Name = "startForm_Label";
            this.startForm_Label.Size = new System.Drawing.Size(325, 29);
            this.startForm_Label.TabIndex = 3;
            this.startForm_Label.Text = "Order Your Computer Today!";
            // 
            // startFormLogo
            // 
            this.startFormLogo.Image = global::COMP1004_DOLLARS_RAILL.Properties.Resources.startformLogo;
            this.startFormLogo.Location = new System.Drawing.Point(50, 59);
            this.startFormLogo.Name = "startFormLogo";
            this.startFormLogo.Size = new System.Drawing.Size(311, 185);
            this.startFormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startFormLogo.TabIndex = 4;
            this.startFormLogo.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 377);
            this.ControlBox = false;
            this.Controls.Add(this.startFormLogo);
            this.Controls.Add(this.startForm_Label);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.newOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.startFormLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label startForm_Label;
        private System.Windows.Forms.PictureBox startFormLogo;
    }
}