namespace WindowsFormsApplication1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnEmailReport = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportReport
            // 
            this.btnExportReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.Location = new System.Drawing.Point(16, 83);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(131, 39);
            this.btnExportReport.TabIndex = 0;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(16, 38);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(131, 39);
            this.btnViewReport.TabIndex = 1;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnEmailReport
            // 
            this.btnEmailReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailReport.Location = new System.Drawing.Point(16, 128);
            this.btnEmailReport.Name = "btnEmailReport";
            this.btnEmailReport.Size = new System.Drawing.Size(131, 39);
            this.btnEmailReport.TabIndex = 2;
            this.btnEmailReport.Text = "Email Report";
            this.btnEmailReport.UseVisualStyleBackColor = true;
            this.btnEmailReport.Click += new System.EventHandler(this.btnEmailReport_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AccessibleName = "WelcomeLabel";
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(452, 24);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to the Snacks on Racks Sales Report!";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SnacksOnRacksSalesReport.Properties.Resources.SOR_logo;
            this.pictureBox1.Location = new System.Drawing.Point(208, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AccessibleName = "Main";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 182);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnEmailReport);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.btnExportReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Snacks on Racks Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnEmailReport;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

