namespace COMP1004_DOLLARS_RAILL
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.splashScreenMainLabel = new System.Windows.Forms.Label();
            this.splashScreenSellLabel = new System.Windows.Forms.Label();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // splashScreenMainLabel
            // 
            this.splashScreenMainLabel.AutoSize = true;
            this.splashScreenMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.splashScreenMainLabel.Font = new System.Drawing.Font("Britannic Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashScreenMainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.splashScreenMainLabel.Location = new System.Drawing.Point(38, 109);
            this.splashScreenMainLabel.Name = "splashScreenMainLabel";
            this.splashScreenMainLabel.Size = new System.Drawing.Size(764, 62);
            this.splashScreenMainLabel.TabIndex = 0;
            this.splashScreenMainLabel.Text = "Welcome to Dollar Computers";
            // 
            // splashScreenSellLabel
            // 
            this.splashScreenSellLabel.AutoSize = true;
            this.splashScreenSellLabel.BackColor = System.Drawing.Color.Transparent;
            this.splashScreenSellLabel.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashScreenSellLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.splashScreenSellLabel.Location = new System.Drawing.Point(130, 303);
            this.splashScreenSellLabel.Name = "splashScreenSellLabel";
            this.splashScreenSellLabel.Size = new System.Drawing.Size(259, 36);
            this.splashScreenSellLabel.TabIndex = 1;
            this.splashScreenSellLabel.Text = "We Sell For Less!";
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 3500;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP1004_DOLLARS_RAILL.Properties.Resources.startformLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 533);
            this.Controls.Add(this.splashScreenSellLabel);
            this.Controls.Add(this.splashScreenMainLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label splashScreenMainLabel;
        private System.Windows.Forms.Label splashScreenSellLabel;
        private System.Windows.Forms.Timer splashScreenTimer;
    }
}